using JogoDosAnimais.Estrutura;
using JogoDosAnimais.UI;

namespace JogoDosAnimais.ViewModel
{
    public class Jogo
    {
        private Catalogo _conhecimento;
        private Interacao _acaoUsuario;

        public Jogo() {PrimeiroConhecimento();}

        public void Jogar()
            => _conhecimento.ExecutarAcao(_acaoUsuario);

        private void PrimeiroConhecimento()
        {
            var sobreAnimalAquatico = new Pergunta("O animal que você pensou é Tubarão?", "Tubarão");
            var sobreAnimalTerrestre = new Pergunta("O animal que você pensou é Macaco?", "Macaco");
            _acaoUsuario = new Interacao();
            _conhecimento = new Catalogo("vive na água", sobreAnimalAquatico, sobreAnimalTerrestre);
        }
    }

}
