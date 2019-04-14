using System;
using System.Drawing;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        int dt = 0;

        //Enter data colected on form1 into apropret labels 
        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            min1.Text = Form1.days[1].tempLow;
            max1.Text = Form1.days[1].tempHigh;
            dt++;
            icon1.Image = iconselect();

            date2.Text = Form1.days[2].date;
            min2.Text = Form1.days[2].tempLow;
            max2.Text = Form1.days[2].tempHigh;
            dt++;
            icon2.Image = iconselect();

            date3.Text = Form1.days[3].date;
            min3.Text = Form1.days[3].tempLow;
            max3.Text = Form1.days[3].tempHigh;
            dt++;
            icon3.Image = iconselect();

            date4.Text = Form1.days[4].date;
            min4.Text = Form1.days[4].tempLow;
            max4.Text = Form1.days[4].tempHigh;
            dt++;
            icon4.Image = iconselect();
        }

        //Finds an apropriet icon for the information provided by the 'condition' number of the day 
        public Bitmap iconselect()
        {
            //Turing 'condition' number into a char array allows for selection of the first charecter.
            string plh = Form1.days[dt].condition.ToString();
            plh.ToCharArray();
            switch (plh[0])
            {
                case '2':
                    return Properties.Resources.thunderstorm1;
                case '3':
                    return Properties.Resources.rain1;
                case '5':
                    return Properties.Resources.heavyrain1;
                case '6':
                    return Properties.Resources.snow1;
                case '8':
                    //Since there are two potential outcomes for the first charecter being '8', there ios a need to check for the last charecter as well
                    if (plh[2] == 0)
                    {
                        return Properties.Resources.clear1;
                    }
                    else
                    {
                        return Properties.Resources.clouds1;
                    }
            }
            return null;
        }
        
        //Swiches between screens
        private void currentLable_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen fs = new CurrentScreen();
            f.Controls.Add(fs);
        }
    }
}
