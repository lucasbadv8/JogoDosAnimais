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
        private void OkClick(object sender, RoutedEventArgs e) 
            => Close();

        public string RetornarTextoInformado() 
            => _viewModel.RetornarTextoInfomado();

        private void CancelarClick(object sender, RoutedEventArgs e)
            => LimparCampoFecharTela();


        private void LimparCampoFecharTela()
        {
            _viewModel.LimparTextoInformado();
            Close();
        }

        private void InputDialog_OnKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
                Close();
            else if (e.Key == Key.Escape)
                LimparCampoFecharTela();

        }
    }
}
