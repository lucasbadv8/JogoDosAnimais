
using JogoDosAnimais.Interfaces;

namespace JogoDosAnimais
{
    public class Pergunta : IConhecimento
    {
        private readonly string _nome;

        public Pergunta(string nomeAnimal)
        {
            _nome = nomeAnimal;
        }

        public IConhecimento Catalogar(IInteracao acaoUsuario)
        {
            if (acaoUsuario.Perguntar($"O animal que você pensou é {_nome}?"))
            {
                acaoUsuario.MostrarVitoria();
                return this;
            }

            var nomeAnimal = acaoUsuario.ObterRespostaUsuario("Desisto","Qual o animal que você pensou?");
            var caracteristicaAnimal = acaoUsuario.ObterRespostaUsuario("Complete",$"Um(a) {nomeAnimal} _______, mas um(a) {_nome} não.");
            var novaPergunta = new Pergunta(nomeAnimal);

            return new Catalogo(caracteristicaAnimal,novaPergunta,this);
        }
    }
}
