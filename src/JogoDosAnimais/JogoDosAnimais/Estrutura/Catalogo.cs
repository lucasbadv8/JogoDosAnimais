using JogoDosAnimais.Interfaces;

namespace JogoDosAnimais.Estrutura
{
    public class Catalogo : IConhecimento
    {

        private readonly string _caracteristicaDoAnimal;

        private IConhecimento _conhecimentoSim;
        private IConhecimento _conhecimentoNao;

        public Catalogo(string caracteristicaInformada, IConhecimento conhecimentoSim, IConhecimento conhecimentoNao)
        {
            _caracteristicaDoAnimal = caracteristicaInformada;
            _conhecimentoSim = conhecimentoSim;
            _conhecimentoNao = conhecimentoNao;
        }

        public IConhecimento ExecutarAcao(IInteracao acaoUsuario)
        {
            if(acaoUsuario.Perguntar($"O animal que você pensou {_caracteristicaDoAnimal} ?"))
                _conhecimentoSim = _conhecimentoSim.ExecutarAcao(acaoUsuario);
            else
                _conhecimentoNao = _conhecimentoNao.ExecutarAcao(acaoUsuario);
            return this;
        }
    }
}
