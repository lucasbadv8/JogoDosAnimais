using System.Windows;
using JogoDosAnimais.Interfaces;

namespace JogoDosAnimais.UI
{
    public class Interacao : IInteracao
    {
        public string ObterRespostaUsuario(string tituloDialog,string pergunta)
        {
            var inputDialog = new InputDialog(tituloDialog, pergunta);
            inputDialog.ShowDialog();
            
            return inputDialog.RetornarTextoInformado();
        }
        public bool Perguntar(string pergunta)
            => MessageBox.Show(pergunta, "Confirme", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes;

        public void MostrarVitoria() 
            => MessageBox.Show("Acertei de novo!", "Vitória", MessageBoxButton.OK, MessageBoxImage.Exclamation);

    }
}
