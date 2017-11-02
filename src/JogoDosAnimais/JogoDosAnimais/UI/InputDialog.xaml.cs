using System.Windows;
using JogoDosAnimais.ViewModel;

namespace JogoDosAnimais.UI
{
    /// <summary>
    /// Interaction logic for Desisto.xaml
    /// </summary>
    public partial class InputDialog : Window
    {
        private readonly InputDialogVm _viewModel;
        public InputDialog(string titulo,string pergunta)
        {
            InitializeComponent();
            _viewModel = new InputDialogVm(titulo, pergunta);
            DataContext = _viewModel;
        }

        public string RetornarTextoInformado() 
            => _viewModel.RetornarTextoInfomado();

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Ok(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
