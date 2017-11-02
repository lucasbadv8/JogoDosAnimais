using System.Windows;
using System.Windows.Input;
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

        private void FecharTela(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InputDialog_OnKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter || e.Key == Key.Escape)
                Close();
        }
    }
}
