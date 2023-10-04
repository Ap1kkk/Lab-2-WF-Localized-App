using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_WF_Localized_App
{
    internal class Clock
    {
        public event Action SecondTick;
        public event Action<string> TimerEnded;
        public string DefaultValue { get; private set; } = "00 : 00 : 00";

        private Dictionary<int, Timer> _timers = new Dictionary<int, Timer>();
        private DateTime _dateTime = DateTime.UtcNow;

        private Dictionary<string, TimeSpan> _citiesTimeShift = new Dictionary<string, TimeSpan>();
        private Dictionary<string, string> _citiesTimes = new Dictionary<string, string>();
        private Dictionary<int, List<string>> _citiesIntervals = new Dictionary<int, List<string>>();
        private Dictionary<int, int> _intervalsTicks = new Dictionary<int, int>();

        public Clock()
        {
        }
        ~Clock()
        {
            foreach (var timer in _timers.Values)
            {
                timer.Tick -= HandleTimerTick;
            }
        }

        public void Start()
        {
            foreach (var timer in _timers.Values)
            {
                timer.Start();
            }
        }

        public void Stop()
        {
            foreach (var timer in _timers.Values)
            {
                timer.Stop();
            }
        }

        public string GetCityTime(string city)
        {
            string formatedTime = DefaultValue;
            if (!_citiesTimes.ContainsKey(city))
            {
                return formatedTime;
            }
            return _citiesTimes[city];
        }

        public void AddCity(string city, TimeSpan timeShift, int interval)
        {
            if(_citiesTimeShift.ContainsKey(city))
            {
                string errorMessage = "Cannot add city. This city already added";
                Console.WriteLine(errorMessage);
                throw new ArgumentException(errorMessage, city);
            }

            _citiesTimes.Add(city, DefaultValue);
            _citiesTimeShift.Add(city, timeShift);
            AddCityInterval(interval, city);
            AddTimer(interval);
        }

        private void HandleTimerTick(object sender, EventArgs e)
        {
            Timer currentTimer = sender as Timer;
            if (currentTimer != null)
            {
                UpdateCityTimes(currentTimer.Interval);
            }
        }

        private void UpdateCityTimes(int interval)
        {
            _dateTime = DateTime.UtcNow;

            int ticksAmount = _intervalsTicks[interval];
            bool isEnded = false;
            _intervalsTicks[interval] = ++ticksAmount;
            if(ticksAmount == 10)
            {
                isEnded= true;
            }

            var cities = _citiesIntervals[interval];
            foreach (var city in cities)
            {
                DateTime shiftedTime = _dateTime + _citiesTimeShift[city];
                _citiesTimes[city] = shiftedTime.ToString("HH : mm : ss");
                if(isEnded)
                {
                    TimerEnded?.Invoke(city);
                }
            }
            
            SecondTick?.Invoke();
            
        }

        private void AddTimer(int interval)
        {
            if(_timers.ContainsKey(interval))
            {
                return;
            }
            Timer newtimer = new Timer { Interval = interval };
            newtimer.Tick += HandleTimerTick;
            _intervalsTicks.Add(interval, 0);
            _timers.Add(interval, newtimer);
        }

        private void AddCityInterval(int interval, string city)
        {
            if(!_citiesIntervals.ContainsKey(interval))
            {
                _citiesIntervals.Add(interval, new List<string> { city });
            }
            else
            {
                _citiesIntervals[interval].Add(city);
            }
        }
    }
}
