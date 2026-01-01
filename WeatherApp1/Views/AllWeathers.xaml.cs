using System.Collections.ObjectModel;
using WeatherApp1.Services;

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

    public ObservableCollection<AllWeathersData> WeathersAll { get; set; } = new ObservableCollection<AllWeathersData>();
    private readonly WeatherService _weatherService = new WeatherService();
    private readonly List<string> _citiesToCheck = new List<string> 
    { 
        "Krakow", "Tokyo", "Montreal", "Barcelona", "London", 
        "Paris", "Warsaw", "Berlin", "Lisbon", "Rome" 
    };

    public AllWeathers()
    {
        InitializeComponent();
        BindingContext = this;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (WeathersAll.Count == 0)
        {
            await LoadAllCities();
        }
    }

    private async Task LoadAllCities()
    {
        foreach (var city in _citiesToCheck)
        {
            var data = await _weatherService.GetCurrentWeather(city);
            if (data != null)
            {
                WeathersAll.Add(new AllWeathersData
                {
                    Location = data.name,
                    Temperature = (int)data.main.temp,
                    HTemp = (int)data.main.temp_max,
                    LTemp = (int)data.main.temp_min,
                    TempInfo = data.weather[0].description,
                    Icon = WeatherService.GetIconForCondition(data.weather[0].icon)
                });
            }
        }
    }

    private async void SearchCity(object sender, EventArgs e)
    {
        string cityName = CityName.Text;
        if (!string.IsNullOrWhiteSpace(cityName))
        {
            await Shell.Current.GoToAsync($"///MainPage?city={cityName}");
            CityName.Text = string.Empty;
        }
    }

    private async void GoToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}