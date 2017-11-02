namespace JogoDosAnimais.Interfaces
{
    public interface IInteracao
    {
        string ObterRespostaUsuario(string tituloDialog, string pergunta);
        bool Perguntar(string pergunta);
        void MostrarVitoria();
    }
}