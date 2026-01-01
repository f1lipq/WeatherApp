using Newtonsoft.Json;
using System.Diagnostics;

namespace WeatherApp1.Services
{
    public class WeatherService
    {
        private const string API_KEY = "5edab990d91be218706f75a0886d091c";
        private const string BASE_URL = "https://api.openweathermap.org/data/2.5/";
        private readonly HttpClient _httpClient;

        public WeatherService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<WeatherData> GetCurrentWeather(string city)
        {
            string url = $"{BASE_URL}weather?q={city}&units=metric&appid={API_KEY}";
            try
            {
                var response = await _httpClient.GetStringAsync(url);
                return JsonConvert.DeserializeObject<WeatherData>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error fetching weather: {ex.Message}");
                return null;
            }
        }

        public async Task<ForecastData> GetForecast(string city)
        {
            string url = $"{BASE_URL}forecast?q={city}&units=metric&appid={API_KEY}";
            try
            {
                var response = await _httpClient.GetStringAsync(url);
                return JsonConvert.DeserializeObject<ForecastData>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error fetching forecast: {ex.Message}");
                return null;
            }
        }

        public static string GetIconForCondition(string iconCode)
        {
            if (iconCode.Contains("01")) return "pixel_sun.png";
            if (iconCode.Contains("02")) return "pixel_clouds.png";
            if (iconCode.Contains("03") || iconCode.Contains("04")) return "pixel_clouds.png";
            if (iconCode.Contains("09") || iconCode.Contains("10")) return "pixel_cloud_rain.png";
            if (iconCode.Contains("11")) return "pixel_cloud_rain.png";
            if (iconCode.Contains("13")) return "pixel_clouds.png";
            if (iconCode.Contains("50")) return "pixel_clouds.png";
            return "pixel_moon.png";
        }
    }
}