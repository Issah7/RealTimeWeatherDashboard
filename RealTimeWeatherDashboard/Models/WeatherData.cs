namespace RealTimeWeatherDashboard.Models
{
    public class WeatherData
    {
        public Main Main { get; set; }
        public List<Weather> Weather { get; set; }
        public Wind Wind { get; set; }
        public string Name { get; set; } // City Name
        public Sys Sys { get; set; } // System Data (Country)
    }

    public class Main
    {
        public double Temp { get; set; }
        public int Humidity { get; set; }
    }

    public class Weather
    {
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
    }

    public class Sys
    {
        public string Country { get; set; }
    }

}
