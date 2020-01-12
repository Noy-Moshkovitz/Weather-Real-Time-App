using BE;
using PL.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PL.MainWindowViewModel1
{
   public class SmallWeeklyViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Model.SmallWeeklyModel smallWeeklyModel { get; set; }
        WeatherDB weatherDB;

        public SearchCommand SearchCommand { get; set; }

        public SmallWeeklyViewModel()
        {
            smallWeeklyModel = new Model.SmallWeeklyModel(userCity);
            UserCity = "jerusalem";
            weatherDB = smallWeeklyModel.getWeeklyForecast(UserCity);
            SearchCommand = new Command.SearchCommand(this);
        }



        public SmallWeeklyViewModel(string city)
        {
            smallWeeklyModel = new Model.SmallWeeklyModel(city);
            UserCity = city;
            weatherDB = smallWeeklyModel.getWeeklyForecast(city);
            SearchCommand = new Command.SearchCommand(this);            
        }

        private void SmallWeeklyViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "userCity")
            {
                weatherDB = smallWeeklyModel.getWeeklyForecast(UserCity);
                string ic;
                CityN = weatherDB.cityN;
                ic = weatherDB.icon_0;
                Icon_0 = setIcon(ic);

                //day0
                Day_0 = weatherDB.day_0;
                Temp_0 = weatherDB.temp_0.ToString() + "\u00B0" + " C";
               

                //day1          
                Day_1 = weatherDB.day_1;
                Temp_1 = weatherDB.temp_1.ToString() + "\u00B0" + " C";
                
                //day2
                Day_2 = weatherDB.day_2;
                Temp_2 = weatherDB.temp_2.ToString() + "\u00B0" + " C";
                

                //day3
                Day_3 = weatherDB.day_3;
                Temp_3 = weatherDB.temp_3.ToString() + "\u00B0" + " C";
                

                //day4
                Day_4 = weatherDB.day_4;
                Temp_4 = weatherDB.temp_4.ToString() + "\u00B0" + " C";
                

                //day5
                Day_5 = weatherDB.day_5;
                Temp_5 = weatherDB.temp_5.ToString() + "\u00B0" + " C";
                

                //day6
                Day_6 = weatherDB.day_6;
                Temp_6 = weatherDB.temp_6.ToString() + "\u00B0" + " C";
                
            }
        }


        private string userCity;
        private string cityN;
        private string day_0, day_1, day_2, day_3, day_4, day_5, day_6;
        private string temp_0, temp_1, temp_2, temp_3, temp_4, temp_5, temp_6;
        
        private BitmapImage icon_0;


        public string UserCity
        {
            get
            {
                return userCity;
            }
            set
            {
                userCity = value;
                PropertyChanged += SmallWeeklyViewModel_PropertyChanged;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("userCity"));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {

            PropertyChangedEventHandler handler = PropertyChanged;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public string CityN
        {
            get
            {
                return weatherDB.cityN;
            }
            set
            {
                cityN = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        public string Day_0
        {
            get
            {
                return weatherDB.day_0;
            }
            set
            {
                day_0 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Day_1
        {
            get
            {
                return weatherDB.day_1;
            }
            set
            {
                day_1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Day_2
        {
            get
            {
                return weatherDB.day_2;
            }
            set
            {
                day_2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Day_3
        {
            get
            {
                return weatherDB.day_3;
            }
            set
            {
                day_3 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Day_4
        {
            get
            {
                return weatherDB.day_4;
            }
            set
            {
                day_4 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Day_5
        {
            get
            {
                return weatherDB.day_5;
            }
            set
            {
                day_5 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Day_6
        {
            get
            {
                return weatherDB.day_6;
            }
            set
            {
                day_6 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        public string Temp_0
        {
            get
            {
                return weatherDB.temp_0.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_0 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_1
        {
            get
            {
                return weatherDB.temp_1.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_2
        {
            get
            {
                return weatherDB.temp_2.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_3
        {
            get
            {
                return weatherDB.temp_3.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_3 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_4
        {
            get
            {
                return weatherDB.temp_4.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_4 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_5
        {
            get
            {
                return weatherDB.temp_5.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_5 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_6
        {
            get
            {
                return weatherDB.temp_6.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_6 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        

        public BitmapImage Icon_0
        {
            get
            {
                string ic = weatherDB.icon_0;

                return setIcon(ic);
            }
            set
            {
                icon_0 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
       

        BitmapImage setIcon(string iconId)
        {
            string iconName = findIcon(iconId);
            string img_location = @"C:\Users\DELL\Desktop\Academic\3rd year 2nd sem\windows project\perfectGraph 3d\WeatherApp_7109\PL\Icons\" + iconName;
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(img_location);
            //picture.Source = image;
            image.EndInit();
            return image;
        }

        string findIcon(string iconId)
        {
            string iconName = "";
            if (iconId == "01d")
                iconName = "sunny.png";
            else if (iconId == "02d")
                iconName = "partly_cloudy.png";
            else if (iconId == "03d")
                iconName = "cloudy.png";
            else if (iconId == "04d")
                iconName = "cloudy.png";
            else if (iconId == "09d")
                iconName = "rain.png";
            else if (iconId == "10d")
                iconName = "rain.png";
            else if (iconId == "11d")
                iconName = "thunderstorm.png";
            else if (iconId == "13d")
                iconName = "snow.png";
            else if (iconId == "50d")
                iconName = "mist.png";
            else if (iconId == "01n")
                iconName = "sunny_night.png";
            else if (iconId == "02n")
                iconName = "partly_cloudy_night.png";
            else if (iconId == "03n")
                iconName = "cloudy.png";
            else if (iconId == "04n")
                iconName = "cloudy.png";
            else if (iconId == "09n")
                iconName = "rain.png";
            else if (iconId == "10n")
                iconName = "rain.png";
            else if (iconId == "11n")
                iconName = "thunderstorm.png";
            else if (iconId == "13n")
                iconName = "snow.png";
            else if (iconId == "50n")
                iconName = "mist_night.png";
            else
                iconName = "partly_cloudy.png";
            return iconName;
        }
}
}
