using System.Windows;
using JogoDosAnimais.UI;

namespace JogoDosAnimais
{
    public class Interacao : IInteracao
    {
        public string InserirNovo(string pergunta)
        {
            var teste = new Desisto();
            teste.ShowDialog();

            return teste.Caracteristica;
        }
        public void Perguntar(string pergunta)
        {
            
        }

        
    }
}
