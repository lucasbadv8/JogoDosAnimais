using System.Windows;
using JogoDosAnimais.UI;

namespace JogoDosAnimais.ViewModel
{
    public class Jogo
    {

        public void Jogar()
        {
            
            var sobreAnimalAquatico = new Pergunta("Tubarão");
            var sobreAnimalTerrestre = new Pergunta("Macaco");
            var acaoUsuario = new Interacao();
            var conhecimento = new Catalogo("vive na água",sobreAnimalTerrestre, sobreAnimalAquatico);

            do
            {
                conhecimento.Catalogar(acaoUsuario);
            } while (true);

            //MessageBox.Show("Teste","Testando",MessageBoxButton.YesNo,MessageBoxImage.Question);

            
        }

    }

}
