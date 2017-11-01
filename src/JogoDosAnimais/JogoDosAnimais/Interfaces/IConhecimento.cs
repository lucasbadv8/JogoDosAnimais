using JogoDosAnimais.Interfaces;

namespace JogoDosAnimais
{
    public interface IConhecimento
    {
        IConhecimento ExecutarAcao(IInteracao acaoUsuario);
    }
}
