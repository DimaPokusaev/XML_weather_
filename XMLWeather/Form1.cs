using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // list to hold day objects
        public static List<Day> days = new List<Day>();
        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            //Open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        //Method for finding information for the forcast window
        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");
            int dt = 0;
            while (reader.Read())
            {
                //Create a day object
                Day d = new Day();
                
                //Fill day object with required data
                //Record the day
                d.date = DateTime.Now.AddDays(dt).ToString("dddd");

                //Find weather conditions
                reader.ReadToFollowing("symbol");
                d.condition = reader.GetAttribute("number");

                //Find temperature minimums and maximums
                reader.ReadToFollowing("temperature");
                d.tempHigh = Convert.ToDouble(reader.GetAttribute("max")).ToString("0.0°C");
                d.tempLow = Convert.ToDouble(reader.GetAttribute("min")).ToString("0.0°C");


                //if day object not null add to the days list
                if (d.date != null)
                {
                    days.Add(d);
                }
                dt++;
            }
            reader.Close();
        }

        //Method for finding information for the current window
        private void ExtractCurrent()
        {
            //Current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //Record the name of current city
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            //Record information in regards to temperature
            reader.ReadToFollowing("temperature");
            days[0].tempHigh = Convert.ToDouble(reader.GetAttribute("max")).ToString("0.0°C");
            days[0].tempLow = Convert.ToDouble(reader.GetAttribute("min")).ToString("0.0°C");
            days[0].currentTemp = Convert.ToDouble(reader.GetAttribute("value")).ToString("0.0");

            reader.ReadToFollowing("speed");
            days[0].windSpeed = reader.GetAttribute("name");
            reader.ReadToFollowing("direction");
            days[0].windDirection = reader.GetAttribute("code");

            //Record current day
            days[0].date = DateTime.Now.ToString("dddd");

            //Record current weather condition
            reader.ReadToFollowing("weather");
            days[0].condition = reader.GetAttribute("number");

            reader.Close();
        }
    }
}
