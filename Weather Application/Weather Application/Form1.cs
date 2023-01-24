using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using Weather_App;
using static System.Net.WebRequestMethods;

namespace Weather_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "130f8036a0f2650d8b92dd83d666e912";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather(); 
            getForcast();
        }

        double lon;
        double lat;
        void getWeather() 
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                labCondition.Text = Info.weather[0].main;
                labDetails.Text = Info.weather[0].description;
                labSunset.Text = convertDateTime (Info.sys.sunset).ToShortTimeString();
                labSunrise.Text = convertDateTime (Info.sys.sunrise).ToShortTimeString();

                labWindSpeed.Text = Info.wind.speed.ToString();
                labPressure.Text = Info.main.pressure.ToString();

                lon = Info.coord.lon;
                lat = Info.coord.lat;  
            }
        }


        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisec).ToLocalTime(); 
            
            return day;
        }

        void getForcast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/3.0/onecall?lat={0}&lon={1}&exclude=current,minutely,hourly,alerts&appid={2}", lat, lon, APIKey);
                var json = web.DownloadString(url);
                WeatherForecast.ForecastInfo forecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);

                ForecastUC FUC;
                for(int i = 0; i < 8; i++)
                {
                    FUC = new ForecastUC();
                    FUC.picWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + forecastInfo.daily[i].weather[0].icon + ".png";
                    FUC.labMainWeahter.Text = forecastInfo.daily[i].weather[0].main;
                    FUC.labWeatherDescription.Text = forecastInfo.daily[i].weather[0].description;
                    FUC.labDT.Text =  convertDateTime(forecastInfo.daily[i].dt).DayOfWeek.ToString();

                    FLP.Controls.Add(FUC);
                }
            }
        }
    }
}
