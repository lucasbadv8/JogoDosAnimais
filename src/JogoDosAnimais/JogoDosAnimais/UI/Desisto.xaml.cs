using System.Windows;


namespace JogoDosAnimais.UI
{
    /// <summary>
    /// Interaction logic for Desisto.xaml
    /// </summary>
    public partial class Desisto : Window
    {
        public string Caracteristica;
        public Desisto(string pergunta)
        {
            InitializeComponent();
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Ok(object sender, RoutedEventArgs e)
        {
            Caracteristica = TxCaracteristica.Text;
            Close();
        }
    }
}
