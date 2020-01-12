using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
    /// <summary>
    /// daily weather info class
    /// </summary>
    public class WeatherInfo
    {
        public class Coord
        {
            public double lon { get; set; } = 0;
            public double lat { get; set; } = 0;
        }

        public class Sys
        {
            public string country { get; set; } = string.Empty;
        }

        public class Weather
        {
            public int id { get; set; } = 0;
            public string main { get; set; } = string.Empty;
            public string description { get; set; } = string.Empty;
            public string icon { get; set; } = string.Empty;
        }

        public class Main
        {
            public double temp { get; set; } = 0;
            public double pressure { get; set; } = 0;
            public double humidity { get; set; } = 0;
            public double temp_min { get; set; } = 0;
            public double temp_max { get; set; } = 0;
        }

        public class Wind
        {
            public double speed { get; set; } = 0;
            public double deg { get; set; } = 0;
        }

        public class Clouds
        {
            public int all { get; set; } = 0;
        }

        public class WeatherRoot//the instance
        {
            public Coord coord { get; set; } = new Coord();
            public Sys sys { get; set; } = new Sys();
            public List<Weather> weather { get; set; } = new List<Weather>();
            public Main main { get; set; } = new Main();
            public Wind wind { get; set; } = new Wind();
            public Clouds clouds { get; set; } = new Clouds();
            public int id { get; set; } = 0;
            public string name { get; set; } = string.Empty;
            public string dt { get; set; } = string.Empty;
        }

        public class WeatherForecastRoot
        {
            public City city { get; set; }
            public string cod { get; set; }
            public double message { get; set; }
            public int cnt { get; set; }
            public List<WeatherRoot> list { get; set; }
        }

        public class City
        {
            public int id { get; set; }
            public string name { get; set; }
            public Coord coord { get; set; }
            public string country { get; set; }
            public int population { get; set; }
            public Sys sys { get; set; }
        }

    }

    /// <summary>
    /// weekly weather info class
    /// </summary>    /// 
    public class WeeklyWeatherInfo//the instance 
    {
        public City city { get; set; }
        public List<list> list { get; set; }
    }

    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
    }

    public class Temp
    {

        public double day { get; set; }
        public double min { get; set; }
        public double max { get; set; }
        public double night { get; set; }
        public double eve { get; set; }
        public double morn { get; set; }
    }

    public class list
    {
        public int dt { get; set; }
        public Temp temp { get; set; }
        public double pressure { get; set; }
        public int humidity { get; set; }
        public List<Weather> weather { get; set; }
        public double speed { get; set; }
        public double deg { get; set; }
        public int clouds { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Coord
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class RootObject
    {
        public string cod { get; set; }
        public double message { get; set; }
        public int cnt { get; set; }
        public List<list> list { get; set; }
        public City city { get; set; }
    }
}
