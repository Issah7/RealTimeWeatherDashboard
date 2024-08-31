using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace RealTimeWeatherDashboard.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "";
        private readonly string _baseApiUrl = "https://api.openweathermap.org/data/2.5/weather";

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Models.WeatherData> GetWeatherDataAsync(string city)
        {
            var responce = await _httpClient.GetAsync($"{_baseApiUrl}?q={city}&appid={_apiKey}&units=metric");
            if (responce.IsSuccessStatusCode)
            {
                var json = await responce.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Models.WeatherData>(json);
            }

            return null;
        }
    }
}
