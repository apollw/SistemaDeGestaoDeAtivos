using SistemaDeGestaoDeAtivos.Pages;

namespace SistemaDeGestaoDeAtivos
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            Routing.RegisterRoute(nameof(PageLoading), typeof(PageLoading));

        }
    }
}
