using SistemaDeGestaoDeAtivos.Pages;

namespace SistemaDeGestaoDeAtivos
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Btn_Login(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            //Desabilita Botão 
            btn.IsEnabled = false;

            // O usuário já está autenticado; permitir o acesso às áreas restritas.
            await Shell.Current.GoToAsync($"{nameof(PageLoading)}");

            //Reabilita Botão
            btn.IsEnabled = true;
        }


        //Comportamento de Focar e Desfocar das Entries - ReturnType - Done
        private void _entryNome_Focused(object sender, FocusEventArgs e)
        {
            _entryNome.Completed += (s, e) =>
            {
                _entrySenha.Focus();
            };
        }
        private void _entrySenha_Focused(object sender, FocusEventArgs e)
        {
            _entrySenha.Completed += (s, e) =>
            {
                _entrySenha.IsEnabled = false;
                _entrySenha.Unfocus();
                _entrySenha.IsEnabled = true;
            };
        }
    }
}
