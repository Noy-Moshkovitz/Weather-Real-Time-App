using BE;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PL.View
{
    /// <summary>
    /// Interaction logic for WeeklyChart.xaml
    /// </summary>
    public partial class WeeklyChart : UserControl
    {
        public WeeklyChart()
        {
            InitializeComponent();
        }
    }

    public partial class DayTemp
    {
        public string Day { get; set; }
        public double Temp { get; set; }
    }


    public partial class MyChart
    {
        public List<DayTemp> Data { get; set; }

        public MyChart()
        {
            const string appid = "542ffd081e67f4512b705f89d2a611b2";//"7f5d69c2acf1f8f804ce97dec852c703";
            const string city = "JERUSALEM";//"London";
            using (WebClient web = new WebClient())
            {
                String url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&appid={1}&units=metric&cnt=7", city, appid);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeeklyWeatherInfo>(json);

                WeeklyWeatherInfo forecast = result;
                Data = new List<DayTemp>()
                {
                    new DayTemp { Day = string.Format("{0}", getDate(forecast.list[0].dt.ToString()).DayOfWeek), Temp = forecast.list[0].temp.day},
                    new DayTemp { Day = string.Format("{0}", getDate(forecast.list[1].dt.ToString()).DayOfWeek), Temp = forecast.list[1].temp.day },
                    new DayTemp { Day = string.Format("{0}", getDate(forecast.list[2].dt.ToString()).DayOfWeek), Temp = forecast.list[2].temp.day },
                    new DayTemp { Day = string.Format("{0}", getDate(forecast.list[3].dt.ToString()).DayOfWeek), Temp = forecast.list[3].temp.day },
                    new DayTemp { Day = string.Format("{0}", getDate(forecast.list[4].dt.ToString()).DayOfWeek), Temp = forecast.list[4].temp.day },
                    new DayTemp { Day = string.Format("{0}", getDate(forecast.list[5].dt.ToString()).DayOfWeek), Temp = forecast.list[5].temp.day },
                    new DayTemp { Day = string.Format("{0}", getDate(forecast.list[6].dt.ToString()).DayOfWeek), Temp = forecast.list[6].temp.day }
                };
            }
            DateTime getDate(string milisconds)
            {
                DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
                day = day.AddSeconds(Convert.ToDouble(milisconds)).ToLocalTime();
                return day;
            }
        }
    }
}
