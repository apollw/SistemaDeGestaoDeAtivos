namespace SistemaDeGestaoDeAtivos.Pages;

public partial class PageLoading : ContentPage
{
	public PageLoading()
	{
		InitializeComponent();
	}

    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        await Task.Delay(1500);

        if (true)
        {
            await Shell.Current.GoToAsync($"//{nameof(PageInicio)}");
        }

    }
}

