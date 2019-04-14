using System;
using System.Drawing;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            //Enter data colected on form1 into apropret labels 
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Form1.days[0].currentTemp + "°C";
            dateOutput.Text = Form1.days[0].date;
            maxMinOutput.Text = "MIN: " + Form1.days[0].tempLow +  "    MAX: " + Form1.days[0].tempHigh;
            windInfo.Text = Form1.days[0].windSpeed + "\n" + Form1.days[0].windDirection;

            //Finds an apropriet icon for the information provided by the 'condition' number of the day 
            //Turing 'condition' number into a char array allows for selection of the first charecter.
            string plh = Form1.days[0].condition.ToString();
            plh.ToCharArray();
            switch (plh[0])
            {
                case '2':
                    iconOutput.Image = Properties.Resources.thunderstorm;
                    break;
                case '3':
                    iconOutput.Image = Properties.Resources.rain;
                    break;
                case '5':
                    iconOutput.Image = Properties.Resources.heavyrain;
                    break;
                case '6':
                    iconOutput.Image = Properties.Resources.snow;
                    break;
                case '8':
                    //Since there are two potential outcomes for the first charecter being '8', there ios a need to check for the last charecter as well
                    if (plh[2] == 0)
                    {
                        iconOutput.Image = Properties.Resources.clear;
                    }
                    else
                    {
                        iconOutput.Image = Properties.Resources.clouds;
                    }
                    break;
            }

            //Change the screen color based on outside temperature
            if (Convert.ToDouble(Form1.days[0].currentTemp) > 0)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.Blue;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
