using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;
using System.Collections.ObjectModel;

namespace WeatherApp1.Views
{
    public partial class MainPage : ContentPage
    {
        public class WeatherHourly
        {
            public string Time { get; set; }
            public string Icon { get; set; }
            public string Temperature { get; set; }
        }

        private async void GoToAllWeathers(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(AllWeathers));
        }

        private async void GoToMainPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(MainPage));
        }

        public class AllWeathersData
        {
            public string Location { get; set; }
            public string Icon { get; set; }
            public string Temperature { get; set; }
        }

        public ObservableCollection<WeatherHourly> HourlyWeather { get; set; }
        public ObservableCollection<AllWeathersData> WeathersAll { get; set; }

        public MainPage()
        {
            InitializeComponent();

            HourlyWeather = new ObservableCollection<WeatherHourly>
            {
                new WeatherHourly { Time = "12 AM", Icon = "weathericonnight1.png", Temperature = "19℃" },
                new WeatherHourly { Time = "1 AM", Icon = "weathericonnight1.png", Temperature = "18℃" },
                new WeatherHourly { Time = "2 AM", Icon = "weathericonnight1.png", Temperature = "17℃" },
                new WeatherHourly { Time = "3 AM", Icon = "weathericonnight1.png", Temperature = "16℃" },
                new WeatherHourly { Time = "4 AM", Icon = "weathericonnight1.png", Temperature = "16℃" },
                new WeatherHourly { Time = "5 AM", Icon = "weathericonnight1.png", Temperature = "17℃" },
                new WeatherHourly { Time = "6 AM", Icon = "weathericonnight1.png", Temperature = "19℃" },
                new WeatherHourly { Time = "7 AM", Icon = "weathericonnight1.png", Temperature = "21℃" },
                new WeatherHourly { Time = "8 AM", Icon = "weathericonnight1.png", Temperature = "23℃" },
                new WeatherHourly { Time = "9 AM", Icon = "weathericonnight1.png", Temperature = "25℃" }
            };

            WeathersAll = new ObservableCollection<AllWeathersData>
            {
                new AllWeathersData { Location = "Krakow, Poland", Icon = "weathericonnight1.png", Temperature = "19℃" },
                new AllWeathersData { Location = "Tokyo, Japan", Icon = "weathericonnight1.png", Temperature = "18℃" },
                new AllWeathersData { Location = "Montreal, Canada", Icon = "weathericonnight1.png", Temperature = "17℃" },
                new AllWeathersData { Location = "Barcelona, Spain", Icon = "weathericonnight1.png", Temperature = "16℃" },
                new AllWeathersData { Location = "London, England", Icon = "weathericonnight1.png", Temperature = "16℃" },
                new AllWeathersData { Location = "Paris, France", Icon = "weathericonnight1.png", Temperature = "17℃" },
                new AllWeathersData { Location = "Warsaw, Poland", Icon = "weathericonnight1.png", Temperature = "19℃" },
                new AllWeathersData { Location = "Berlin, Germany", Icon = "weathericonnight1.png", Temperature = "21℃" },
                new AllWeathersData { Location = "Lizbona, Portugal", Icon = "weathericonnight1.png", Temperature = "23℃" },
                new AllWeathersData { Location = "Rome, Italy", Icon = "weathericonnight1.png", Temperature = "25℃" }
            };

            BindingContext = this;
        }
    }
}