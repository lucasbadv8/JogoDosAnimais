namespace JogoDosAnimais.Interfaces
{
    public interface IInteracao
    {
        /// <summary>
        /// Faz uma pergunta ao usuário e obtem a resposta.
        /// </summary>
        /// <param name="tituloDialog"> Titulo da caixa de mensagem</param>
        /// <param name="pergunta"> Pergunta que será feita ao usuário</param>
        /// <returns>a resposta inserida pelo usuário</returns>
        string ObterRespostaUsuario(string tituloDialog, string pergunta);
        /// <summary>
        /// Pergunta objetiva (Sim, não) ao usuário
        /// </summary>
        /// <param name="pergunta">Pergunta relacionada ao animal</param>
        /// <returns>Sim ou nâo</returns>
        bool Perguntar(string pergunta);
        /// <summary>
        /// Exibe a mensagem de vitória ao usuário
        /// </summary>
        void MostrarVitoria();
    }
}