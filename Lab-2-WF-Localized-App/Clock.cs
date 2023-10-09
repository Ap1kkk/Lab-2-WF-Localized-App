using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_WF_Localized_App
{
    public class CityTime
    {
        public TimeSpan TimeSpan;
        public string TimeString;
    }

    internal class Clock
    {
        public static readonly string DefaultValue = "00 : 00 : 00";

        public event Action<Clock> SecondTick;
        public event Action<Clock> TimerEnded;
        public List<string> Cities => _cities.Keys.ToList();

        private readonly Dictionary<string, CityTime> _cities = new Dictionary<string, CityTime>();

        private Timer _timer;
        private int _ticksAmount = 0;
        private int _ticksMade = 0;

        public Clock(int interval, int ticksAmount)
        {
            _timer = new Timer();
            _timer.Interval = interval;
            _timer.Tick += UpdateCityTimes;
            _ticksAmount = ticksAmount;
        }
        ~Clock()
        {
            _timer.Tick -= UpdateCityTimes;
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        public string GetCityTime(string city)
        {
            string formatedTime = DefaultValue;
            if (!_cities.ContainsKey(city))
            {
                return formatedTime;
            }
            return _cities[city].TimeString;
        }

        public void AddCity(string city, TimeSpan timeShift)
        {
            if (_cities.ContainsKey(city))
            {
                string errorMessage = "Cannot add city. This city already added";
                Console.WriteLine(errorMessage);
                throw new ArgumentException(errorMessage, city);
            }
            var cityTime = new CityTime { TimeSpan = timeShift };
            _cities.Add(city, cityTime);
        }

        private void UpdateCityTimes(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow;

            foreach (var city in _cities.Values)
            {
                DateTime cityTime = dateTime + city.TimeSpan;
                city.TimeString = cityTime.ToString("HH : mm : ss");

            }

            SecondTick?.Invoke(this);

            ++_ticksMade;
            if (_ticksAmount == _ticksMade)
            {
                Stop();
                TimerEnded?.Invoke(this);
            }
        }
    }

}
