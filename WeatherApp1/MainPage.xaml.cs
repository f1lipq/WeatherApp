using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;

namespace WeatherApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CreateWeatherBoxes();
        }

        private void CreateWeatherBoxes()
        {
            // Dane przykładowe - możesz je pobrać z API lub innego źródła
            var weatherData = new[]
            {
                new { Time = "12 AM", Icon = "weathericonnight1.png", Temp = "19℃" },
                new { Time = "1 AM", Icon = "weathericonnight1.png", Temp = "18℃" },
                new { Time = "2 AM", Icon = "weathericonnight1.png", Temp = "17℃" },
                new { Time = "3 AM", Icon = "weathericonnight2.png", Temp = "16℃" },
                new { Time = "4 AM", Icon = "weathericonday1.png", Temp = "17℃" },
                new { Time = "5 AM", Icon = "weathericonday1.png", Temp = "19℃" },
                new { Time = "6 AM", Icon = "weathericonday2.png", Temp = "21℃" },
                new { Time = "7 AM", Icon = "weathericonday2.png", Temp = "23℃" }
            };

            // Zakładając, że w XAML masz HorizontalStackLayout lub ScrollView z nazwą "WeatherContainer"
            // Jeśli nie masz - zobacz opcję 2 poniżej
            foreach (var weather in weatherData)
            {
                var box = CreateWeatherBox(weather.Time, weather.Icon, weather.Temp);
                WeatherContainer.Children.Add(box);
            }
        }

        private Border CreateWeatherBox(string time, string iconSource, string temperature)
        {
            // Tworzenie głównego Border
            var border = new Border
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                HeightRequest = 120,
                WidthRequest = 60,
                Stroke = Color.FromArgb("#1F1D47"),
                StrokeThickness = 3,
                StrokeShape = new RoundRectangle { CornerRadius = new CornerRadius(60) }
            };

            // Tworzenie gradientu
            var gradient = new LinearGradientBrush
            {
                StartPoint = new Point(0, 0),
                EndPoint = new Point(1, 1)
            };
            gradient.GradientStops.Add(new GradientStop { Color = Color.FromArgb("#E65A6490"), Offset = 0 });
            gradient.GradientStops.Add(new GradientStop { Color = Color.FromArgb("#E61F1D47"), Offset = 1 });

            border.Background = gradient;

            // Tworzenie zawartości
            var stackLayout = new VerticalStackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(0, 10, 0, 10)
            };

            // Label z czasem
            var timeLabel = new Label
            {
                Text = time,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Colors.White
            };

            // Ikona pogody
            var weatherIcon = new Image
            {
                Source = iconSource,
                HeightRequest = 50,
                WidthRequest = 50
            };

            // Label z temperaturą
            var tempLabel = new Label
            {
                Text = temperature,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Colors.White
            };

            // Dodanie elementów do stackLayout
            stackLayout.Children.Add(timeLabel);
            stackLayout.Children.Add(weatherIcon);
            stackLayout.Children.Add(tempLabel);

            // Ustawienie zawartości Border
            border.Content = stackLayout;

            return border;
        }
    }
}