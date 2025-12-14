using System.Collections.ObjectModel;
using static WeatherApp1.Views.MainPage;

namespace WeatherApp1.Views;

public partial class AllWeathers : ContentPage
{

    public class AllWeathersData
    {
        public string Location { get; set; }
        public string Icon { get; set; }
        public int Temperature { get; set; }

        public int HTemp { get; set; }

        public int LTemp { get; set; }
        
        public string TempInfo { get; set; }
    }

    public ObservableCollection<AllWeathersData> WeathersAll { get; set; }

    public AllWeathers()
	{
		InitializeComponent();

        WeathersAll = new ObservableCollection<AllWeathersData>
            {
                new AllWeathersData { Location = "Krakow", Icon = "big_night_cloud_rain.png", Temperature = 19, HTemp = 21, LTemp = 15, TempInfo = "cloudy" },
                new AllWeathersData { Location = "Tokyo", Icon = "big_tornado.png", Temperature = 18,HTemp = 21, LTemp = 15, TempInfo = "tornado"},
                new AllWeathersData { Location = "Montreal", Icon = "big_day_cloud_rain1.png", Temperature = 17, HTemp = 24, LTemp = 15 },
                new AllWeathersData { Location = "Barcelona", Icon = "big_tornado.png", Temperature = 16, HTemp = 18, LTemp = 15 },
                new AllWeathersData { Location = "London", Icon = "big_night_cloud_rain.png", Temperature = 16, HTemp = 20, LTemp = 11 },
                new AllWeathersData { Location = "Paris, France", Icon = "big_night_cloud_wind.png", Temperature = 17, HTemp = 26, LTemp = 17 },
                new AllWeathersData { Location = "Warsaw, Poland", Icon = "big_day_cloud_rain1.png", Temperature = 19, HTemp = 21, LTemp = 14 },
                new AllWeathersData { Location = "Berlin, Germany", Icon = "big_day_cloud_rain1.png", Temperature = 21, HTemp = 28, LTemp = 20 },
                new AllWeathersData { Location = "Lizbona, Portugal", Icon = "big_day_cloud_rain2.png", Temperature = 23, HTemp = 25, LTemp = 22 },
                new AllWeathersData { Location = "Rome, Italy", Icon = "big_tornado.png", Temperature = 25, HTemp = 27, LTemp = 18}
            };

        BindingContext = this;
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