namespace WeatherApp1.Views;

public partial class AllWeathers : ContentPage
{
	public AllWeathers()
	{
		InitializeComponent();
	}

    private async void GoToAllWeathers(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AllWeathers));
    }

    private async void GoToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}