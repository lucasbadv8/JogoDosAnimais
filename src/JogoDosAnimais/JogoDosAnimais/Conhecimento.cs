namespace JogoDosAnimais
{
    public class Conhecimento : IConhecimento
    {

        private string caracteristicaDoAnimal;

        private IConhecimento _conhecimentoSim;
        private IConhecimento _conhecimentoNao;

        public Conhecimento(string caracteristicaInformada, IConhecimento conhecimentoSim, IConhecimento conhecimentoNao)
        {
            caracteristicaDoAnimal = caracteristicaInformada;
            _conhecimentoSim = conhecimentoSim;
            _conhecimentoNao = conhecimentoNao;
        }

        public IConhecimento AprenderCom(Interacao acaoUsuario)
        {

            return this;
        }
    }
}
