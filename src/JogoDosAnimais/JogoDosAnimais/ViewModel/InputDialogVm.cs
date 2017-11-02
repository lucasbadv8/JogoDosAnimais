namespace JogoDosAnimais.ViewModel
{
    public class InputDialogVm
    {
        public string Titulo { get; private set; }
        public string Mensagem { get; private set; }
        public string TextoInformado { get; set; }
        public string RetornarTextoInfomado() => TextoInformado;
        public InputDialogVm(string titulo,string mensagem)
        {
            Titulo = titulo;
            Mensagem = mensagem;
        }
    }
}
