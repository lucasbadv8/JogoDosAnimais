
using JogoDosAnimais.Interfaces;

namespace JogoDosAnimais.Estrutura
{
    public class Pergunta : IConhecimento
    {
        private readonly string _textoPergunta;
        private readonly string _nomeAnimal;

        public Pergunta(string texto,string nomeAnimal)
        {
            _textoPergunta = texto;
            _nomeAnimal = nomeAnimal;
        }

        public IConhecimento ExecutarAcao(IInteracao acaoUsuario)
        {
            if (!acaoUsuario.Perguntar(_textoPergunta))
                return ObterNovaPergunta(acaoUsuario);

            acaoUsuario.MostrarVitoria();
            return this;
        }

        private IConhecimento ObterNovaPergunta(IInteracao acaoUsuario)
        {
            var novoAnimal = acaoUsuario.ObterRespostaUsuario("Desisto", "Qual o animal que você pensou?");
            if (string.IsNullOrWhiteSpace(novoAnimal)) return this;

            var caracteristicaAnimal = acaoUsuario.ObterRespostaUsuario("Complete", $"Um(a) {novoAnimal} _______, mas um(a) {_nomeAnimal} não.");
            if (string.IsNullOrWhiteSpace(caracteristicaAnimal)) return this;

            var novoTexto = $"O animal que você pensou é {novoAnimal}?";
            var novaPergunta = new Pergunta(novoTexto, novoAnimal);

            return new Catalogo(caracteristicaAnimal, novaPergunta, this);
        }
    }
}
