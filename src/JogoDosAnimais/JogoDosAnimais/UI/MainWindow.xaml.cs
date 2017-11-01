using System.Windows;
using JogoDosAnimais.ViewModel;

namespace JogoDosAnimais
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Jogo _viewModel;
        public MainWindow()
        {
            _viewModel = new Jogo();
            InitializeComponent();
            DataContext = _viewModel;
        }

        private void IniciarJogo(object sender, RoutedEventArgs e)
        {
            _viewModel.Jogar();
        }
    }
}
