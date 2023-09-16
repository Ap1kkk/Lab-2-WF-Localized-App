using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_WF_Localized_App
{
    internal class Clock
    {
        public event Action SecondTick;

        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        private DateTime _dateTime = DateTime.Now;

        private Dictionary<string, TimeSpan> _citiesTimeShift = new Dictionary<string, TimeSpan>();

        public Clock(int interval)
        {
            _timer.Interval = interval;
            _timer.Start();
            _timer.Tick += HandleTimerTick;
        }
        ~Clock()
        {
            _timer.Tick -= HandleTimerTick;
        }

        public void AddCity(string city, TimeSpan timeShift)
        {
            if(_citiesTimeShift.ContainsKey(city))
            {
                string errorMessage = "Cannot add city. This city already added";
                Console.WriteLine(errorMessage);
                throw new ArgumentException(errorMessage, city);
            }

            _citiesTimeShift.Add(city, timeShift);
        }

        private void HandleTimerTick(object sender, EventArgs e)
        {
            _dateTime = DateTime.UtcNow;
            SecondTick?.Invoke();
        }

        public string GetCityTime(string city)
        {
            string formatedTime = "00 : 00 : 00";
            if (!_citiesTimeShift.ContainsKey(city))
            {
                return formatedTime;
            }

            DateTime shiftedTime = _dateTime + _citiesTimeShift[city];

            return shiftedTime.ToString("HH : mm : ss");
        }
    }
}
