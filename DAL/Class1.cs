using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BE;
using System.Data.Entity;

namespace DAL
{
    public class MyDal
    {
        public class WeatherContext : DbContext
        {
            public DbSet<WeatherDB> forc { get; set; }
        }
        // const string appid= "7f5d69c2acf1f8f804ce97dec852c703";
        // const string city = "JERUSALEM";// "London";

        const string appid = "542ffd081e67f4512b705f89d2a611b2";

        public WeatherDB getWeather(String city)///noy
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    ///for current
                    String url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&&units=metric", city, appid);
                    var json = web.DownloadString(url);
                    var result = JsonConvert.DeserializeObject<WeatherInfo.WeatherRoot>(json);

                    WeatherInfo.WeatherRoot output = result;

                    string cityN = output.name;
                    double humdity = output.main.humidity;
                    double lonCoord = output.coord.lon;
                    double latCoord = output.coord.lat;
                    /// <summary>
                    /// for a week
                    /// </summary>

                    String weeklyUrl = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&appid={1}&units=metric&cnt=7", city, appid);
                    var weeklyJson = web.DownloadString(weeklyUrl);
                    var weeklyResult = JsonConvert.DeserializeObject<WeeklyWeatherInfo>(weeklyJson);

                    WeeklyWeatherInfo forecast = weeklyResult;
                    
                    string day_0 = trim(getDate(forecast.list[0].dt.ToString()).DayOfWeek.ToString());
                    double temp_0 = forecast.list[0].temp.day;
                    double windSpeed_0 = forecast.list[0].speed;
                    string description_0 = forecast.list[0].weather[0].description;
                    string icon_0 = forecast.list[0].weather[0].icon;
                    string cond_0 = forecast.list[0].weather[0].main;
                   
                    string day_1 = trim(getDate(forecast.list[1].dt.ToString()).DayOfWeek.ToString());
                    double temp_1 = forecast.list[1].temp.day;                    
                    double windSpeed_1 = forecast.list[1].speed;
                    string description_1 = forecast.list[1].weather[0].description;
                    string icon_1 = forecast.list[1].weather[0].icon;
                    string cond_1 = forecast.list[1].weather[0].main;

                    string day_2 = trim(getDate(forecast.list[2].dt.ToString()).DayOfWeek.ToString());
                    double temp_2 = forecast.list[2].temp.day;
                    double windSpeed_2 = forecast.list[2].speed;
                    string description_2 = forecast.list[2].weather[0].description;
                    string icon_2 = forecast.list[2].weather[0].icon;
                    string cond_2 = forecast.list[2].weather[0].main;

                    string day_3 = trim(getDate(forecast.list[3].dt.ToString()).DayOfWeek.ToString());
                    double temp_3 = forecast.list[3].temp.day;
                    double windSpeed_3 = forecast.list[3].speed;
                    string description_3 = forecast.list[3].weather[0].description;
                    string icon_3 = forecast.list[3].weather[0].icon;
                    string cond_3 = forecast.list[3].weather[0].main;

                    string day_4 = trim(getDate(forecast.list[4].dt.ToString()).DayOfWeek.ToString());
                    double temp_4 = forecast.list[4].temp.day;
                    double windSpeed_4 = forecast.list[4].speed;
                    string description_4 = forecast.list[4].weather[0].description;
                    string icon_4 = forecast.list[4].weather[0].icon;
                    string cond_4 = forecast.list[4].weather[0].main;

                    string day_5 = trim(getDate(forecast.list[5].dt.ToString()).DayOfWeek.ToString());
                    double temp_5 = forecast.list[5].temp.day;
                    double windSpeed_5 = forecast.list[5].speed;
                    string description_5 = forecast.list[5].weather[0].description;
                    string icon_5 = forecast.list[5].weather[0].icon;
                    string cond_5 = forecast.list[5].weather[0].main;

                    string day_6 = trim(getDate(forecast.list[6].dt.ToString()).DayOfWeek.ToString());
                    double temp_6 = forecast.list[6].temp.day;
                    double windSpeed_6 = forecast.list[6].speed;
                    string description_6 = forecast.list[6].weather[0].description;
                    string icon_6 = forecast.list[6].weather[0].icon;
                    string cond_6 = forecast.list[6].weather[0].main;

                    WeatherDB weatherDBinst = new WeatherDB(cityN, humdity, lonCoord, latCoord, day_0, temp_0, windSpeed_0, description_0, icon_0, cond_0, day_1, temp_1, windSpeed_1, description_1, icon_1, cond_1,
                day_2, temp_2, windSpeed_2, description_2, icon_2, cond_2, day_3, temp_3, windSpeed_3, description_3, icon_3, cond_3, day_4, temp_4, windSpeed_4, description_4, icon_4, cond_4,
                day_5, temp_5, windSpeed_5, description_5, icon_5, cond_5, day_6, temp_6, windSpeed_6, description_6, icon_6, cond_6);
       
                    /*
                    using (var db = new WeatherContext())
                    {
                        if (db.forc.Any(W => W.cityN == city))
                        {
                            var query = (from b in db.forc
                                         where b.cityN == city
                                         select b).FirstOrDefault();

                            db.forc.Remove(query);

                            db.forc.Add(weatherDBinst);
                            db.SaveChanges();

                        }
                        else//if the city isn't exist in the data base
                        {
                            db.forc.Add(weatherDBinst);
                            db.SaveChanges();

                        }

                    }*/
                    return weatherDBinst;
                }
                catch (Exception)//if there isn't connection to internet
                {
                    using (var db = new WeatherContext())
                    {
                        var query = (from b in db.forc
                                     where b.cityN == city
                                     select b).FirstOrDefault();
                        return query;


                    }
                }
                DateTime getDate(string milisconds)
                {
                    DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
                    day = day.AddSeconds(Convert.ToDouble(milisconds)).ToLocalTime();
                    return day;
                }

                string trim(string day)
                {
                    string shortDay = "";
                    if (day == "Sunday")
                        shortDay = "Sun";
                    if (day == "Monday")
                        shortDay = "Mon";
                    if (day == "Tuesday")
                        shortDay = "Tue";
                    if (day == "Wednesday")
                        shortDay = "Wed";
                    if (day == "Thursday")
                        shortDay = "Thur";
                    if (day == "Friday")
                        shortDay = "Fri";
                    if (day == "Saturday")
                        shortDay = "Sat";
                    return shortDay;
                }
            }

        }


    }
}
