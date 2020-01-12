using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class WeatherDB
    {
        [Key]       

        public string cityN { get; set; }        
        public double humdity { get; set; }
        public double lonCoord { get; set; }
        public double latCoord { get; set; }


        /// <summary>
        /// weekly weather data
        /// </summary>
        public string day_0 { get; set; }
        public double temp_0 { get; set; }
        public double windSpeed_0 { get; set; }
        public string description_0 { get; set; }        
        public string icon_0 { get; set; }        
        public string cond_0 { get; set; }

        public string day_1 { get; set; }
        public double temp_1 { get; set; }
        public double windSpeed_1 { get; set; }
        public string description_1 { get; set; }
        public string icon_1 { get; set; }
        public string cond_1 { get; set; }

        public string day_2 { get; set; }
        public double temp_2 { get; set; }
        public double windSpeed_2 { get; set; }
        public string description_2 { get; set; }
        public string icon_2 { get; set; }
        public string cond_2 { get; set; }

        public string day_3 { get; set; }
        public double temp_3 { get; set; }
        public double windSpeed_3 { get; set; }
        public string description_3 { get; set; }
        public string icon_3 { get; set; }
        public string cond_3 { get; set; }

        public string day_4 { get; set; }
        public double temp_4 { get; set; }
        public double windSpeed_4 { get; set; }
        public string description_4 { get; set; }
        public string icon_4 { get; set; }
        public string cond_4 { get; set; }

        public string day_5 { get; set; }
        public double temp_5 { get; set; }
        public double windSpeed_5 { get; set; }
        public string description_5 { get; set; }
        public string icon_5 { get; set; }
        public string cond_5 { get; set; }

        public string day_6 { get; set; }
        public double temp_6 { get; set; }
        public double windSpeed_6 { get; set; }
        public string description_6 { get; set; }        
        public string icon_6 { get; set; }        
        public string cond_6 { get; set; }

        /// <summary>
        /// constructors
        /// </summary>
        public WeatherDB() { }

        public WeatherDB(string cityN, double humdity, double lonCoord, double latCoord, string day_0, double temp_0, double windSpeed_0, string description_0, string icon_0, string cond_0, string day_1, double temp_1, double windSpeed_1, string description_1, string icon_1, string cond_1,
                string day_2, double temp_2, double windSpeed_2, string description_2, string icon_2, string cond_2, string day_3, double temp_3, double windSpeed_3, string description_3, string icon_3, string cond_3, string day_4, double temp_4, double windSpeed_4, string description_4, string icon_4, string cond_4,
                string day_5, double temp_5, double windSpeed_5, string description_5, string icon_5, string cond_5, string day_6, double temp_6, double windSpeed_6, string description_6, string icon_6, string cond_6)
        {
            this.cityN = cityN;
            this.humdity = humdity;
            this.lonCoord = lonCoord;
            this.latCoord = latCoord;

            this.day_0 = day_0;
            this.temp_0 = temp_0;
            this.windSpeed_0 = windSpeed_0;
            this.description_0 = description_0;
            this.icon_0 = icon_0;
            this.cond_0 = cond_0;

            this.day_1 = day_1;
            this.temp_1 = temp_1;
            this.windSpeed_1 = windSpeed_1;
            this.description_1 = description_1;
            this.icon_1 = icon_1;
            this.cond_1 = cond_1;

            this.day_2 = day_2;
            this.temp_2 = temp_2;
            this.windSpeed_2 = windSpeed_2;
            this.description_2 = description_2;
            this.icon_2 = icon_2;
            this.cond_2 = cond_2;

            this.day_3 = day_3;
            this.temp_3 = temp_3;
            this.windSpeed_3 = windSpeed_3;
            this.description_3 = description_3;
            this.icon_3 = icon_3;
            this.cond_3 = cond_3;

            this.day_4 = day_4;
            this.temp_4 = temp_4;
            this.windSpeed_4 = windSpeed_4;
            this.description_4 = description_4;
            this.icon_4 = icon_4;
            this.cond_4 = cond_4;

            this.day_5 = day_5;
            this.temp_5 = temp_5;
            this.windSpeed_5 = windSpeed_5;
            this.description_5 = description_5;
            this.icon_5 = icon_5;
            this.cond_5 = cond_5;

            this.day_6 = day_6;
            this.temp_6 = temp_6;
            this.windSpeed_6 = windSpeed_6;
            this.description_6 = description_6;
            this.icon_6 = icon_6;
            this.cond_6 = cond_6;
        }
    }
}
