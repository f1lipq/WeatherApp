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
            public int Temperature { get; set; }
        }

		public class WeatherWeekly
		{
			public string Date { get; set; }
			public string Icon { get; set; }
			public int HTemp { get; set; }
            public int LTemp { get; set; }
		}

		private async void GoToAllWeathers(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(AllWeathers));
        }

        private async void GoToMainPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(MainPage));
        }


        public ObservableCollection<WeatherHourly> HourlyWeather { get; set; }
        public ObservableCollection<WeatherWeekly> WeeklyWeather { get; set; }
        public MainPage()
        {
            InitializeComponent();

			HourlyWeather = new ObservableCollection<WeatherHourly>
            {
                new WeatherHourly { Time = "1 AM", Icon = "pixel_moon.png", Temperature = 18 },
                new WeatherHourly { Time = "2 AM", Icon = "pixel_moon.png", Temperature = 17 },
                new WeatherHourly { Time = "3 AM", Icon = "pixel_moon.png", Temperature = 16 },
                new WeatherHourly { Time = "4 AM", Icon = "pixel_moon.png", Temperature = 16 },
                new WeatherHourly { Time = "5 AM", Icon = "pixel_moon.png", Temperature = 17 },
                new WeatherHourly { Time = "6 AM", Icon = "pixel_cloud_rain.png", Temperature = 19 },
                new WeatherHourly { Time = "7 AM", Icon = "pixel_cloud_rain.png", Temperature = 21 },
                new WeatherHourly { Time = "8 AM", Icon = "pixel_cloud_rain.png", Temperature = 23 },
                new WeatherHourly { Time = "9 AM", Icon = "pixel_clouds.png", Temperature = 25 },
                new WeatherHourly { Time = "10 AM", Icon = "pixel_cloud_rain.png", Temperature = 19 },
                new WeatherHourly { Time = "11 AM", Icon = "pixel_cloud_rain.png", Temperature = 21 },
                new WeatherHourly { Time = "12 AM", Icon = "pixel_clouds.png", Temperature = 19 },
                new WeatherHourly { Time = "1 PM", Icon = "pixel_sun.png", Temperature = 18 },
                new WeatherHourly { Time = "2 PM", Icon = "pixel_sun.png", Temperature = 17 },
                new WeatherHourly { Time = "3 PM", Icon = "pixel_sun.png", Temperature = 16 },
                new WeatherHourly { Time = "4 PM", Icon = "pixel_sun.png", Temperature = 16 },
                new WeatherHourly { Time = "5 PM", Icon = "pixel_sun.png", Temperature = 17 },
                new WeatherHourly { Time = "6 PM", Icon = "pixel_clouds.png", Temperature = 19 },
                new WeatherHourly { Time = "7 PM", Icon = "pixel_cloud_rain.png", Temperature = 21 },
                new WeatherHourly { Time = "8 PM", Icon = "pixel_cloud_rain.png", Temperature = 23 },
                new WeatherHourly { Time = "9 PM", Icon = "pixel_clouds.png", Temperature = 25 },
                new WeatherHourly { Time = "10 PM", Icon = "pixel_cloud_rain.png", Temperature = 19 },
                new WeatherHourly { Time = "11 PM", Icon = "pixel_cloud_rain.png", Temperature = 21 },
                new WeatherHourly { Time = "12 PM", Icon = "pixel_cloud_rain.png", Temperature = 23 }
            };

            WeeklyWeather = new ObservableCollection<WeatherWeekly>
            {
                new WeatherWeekly { Date = "10.12", Icon = "pixel_clouds.png", HTemp = 22, LTemp = 18 },
                new WeatherWeekly { Date = "11.12", Icon = "pixel_sun.png", HTemp = 18, LTemp = 11 },
				new WeatherWeekly { Date = "13.12", Icon = "pixel_clouds.png", HTemp = 22, LTemp = 18 },
				new WeatherWeekly { Date = "14.12", Icon = "pixel_sun.png", HTemp = 18, LTemp = 11 },
				new WeatherWeekly { Date = "15.12", Icon = "pixel_clouds.png", HTemp = 22, LTemp = 18 },
				new WeatherWeekly { Date = "16.12", Icon = "pixel_sun.png", HTemp = 18, LTemp = 11 },
				new WeatherWeekly { Date = "15.12", Icon = "pixel_clouds.png", HTemp = 22, LTemp = 18 },
				new WeatherWeekly { Date = "16.12", Icon = "pixel_sun.png", HTemp = 18, LTemp = 11 },
				new WeatherWeekly { Date = "15.12", Icon = "pixel_clouds.png", HTemp = 22, LTemp = 18 },
				new WeatherWeekly { Date = "17.12", Icon = "pixel_clouds.png", HTemp = 22, LTemp = 18 }

			};

            BindingContext = this;

        }
    }
}