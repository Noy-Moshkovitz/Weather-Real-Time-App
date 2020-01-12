using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class MyBL    {
        MyDal dal=new MyDal();
        
        public WeatherDB getWeeklyForecast(string city)
        {
            return dal.getWeather(city);
        }
       // public MyBL() { dal =  }
        /*public WeatherDB getCurrentWeather(string city)
        {
            return dal.getWeather(city);
        }
        public WeatherDB getWeeklyForecast(string city)
        {
            return dal.getWeather(city);
        }*/

    }
}
