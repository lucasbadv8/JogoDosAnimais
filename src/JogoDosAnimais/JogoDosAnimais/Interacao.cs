using System.Windows;
using JogoDosAnimais.Interfaces;
using JogoDosAnimais.UI;

namespace JogoDosAnimais
{
    public class Interacao : IInteracao
    {
        public string ObterRespostaUsuario(string tituloDialog,string pergunta)
        {
            var inputDialog = new InputDialog(tituloDialog, pergunta);
            inputDialog.ShowDialog();
            
            return inputDialog.RetornarTextoInformado();
        }
        public bool Perguntar(string pergunta) =>
             MessageBox.Show(pergunta, "Confirme", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes;

        public void MostrarVitoria() => 
            MessageBox.Show("Vitória", "Acertei de novo!", MessageBoxButton.OK, MessageBoxImage.Exclamation);

    }
}
