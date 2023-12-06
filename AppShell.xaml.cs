using SistemaDeGestaoDeAtivos.Pages;

namespace SistemaDeGestaoDeAtivos
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

		 //teste
            
            Routing.RegisterRoute(nameof(PageLoading), typeof(PageLoading));

        }
    }
}
