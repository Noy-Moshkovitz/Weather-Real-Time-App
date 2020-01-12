using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Model
{
    class WeeklyModel
    {
        MyBL myBL { get; set; }

        public WeeklyModel(string city)
        {
            myBL = new MyBL();
        }


        public WeatherDB getWeeklyForecast(string city)
        {
            return myBL.getWeeklyForecast(city);
        }
    }
}
