using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_WF_Localized_App
{
    public partial class MainForm : Form
    {
        private struct ClockData
        {
            public int Interval;
            public int TicksToEnd;

            public ClockData(int interval, int ticksToEnd)
            {
                Interval = interval;
                TicksToEnd = ticksToEnd;
            }
        }

        private const string _london = "London";
        private const string _moscow = "Moscow";
        private const string _vladivostok = "Vladivostok";
        private const string _novosibirk = "Novosibirsk";
        private const string _newYork = "New York";

        private readonly string[] _locales = { "Ru-ru", "En-en" };
        private readonly string _initLocale = "Ru-ru";
        private bool _isDefaultLocale = true;

        private Dictionary<string, TimeView> _cityViews = new Dictionary<string, TimeView>();
        private Dictionary<ClockData, Clock> _clocks = new Dictionary<ClockData, Clock>();

        private int _fontSize = 14;
        private string _fontName = "Microsoft Sans Serif";

        public MainForm()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(_initLocale);

            InitializeComponent();

            LocaleButton.Text = _initLocale;

            InitializeForm();

            AddCity(_moscow, new TimeSpan(3, 0, 0), 1000, 10);
            //CreateTimeView(_moscow);
        }

        ~MainForm()
        {
            foreach (var clock in _clocks.Values)
            {
                clock.SecondTick -= HandleSecondTick;
                clock.TimerEnded -= OnTimerEnded;
            }
        }

        private void InitializeForm()
        {
            //LondonTimeBox.Text = _clock.GetCityTime(_london);
            //MoscowTimeBox.Text = _clock.GetCityTime(_moscow);
            //VladivostokTimeBox.Text = _clock.GetCityTime(_vladivostok);
            //NovosibirskTimeBox.Text = _clock.GetCityTime(_novosibirk);
            //NewYorkTimeBox.Text = _clock.GetCityTime(_newYork);
        }

        private void AddCity(string city, TimeSpan timeSpan, int interval, int ticksToEnd)
        {
            if(_cityViews.ContainsKey(city))
            {
                Console.WriteLine($"Cannot add city: {city} already exists");
                return;
            }

            TimeView timeView = CreateTimeView(city);
            _cityViews.Add(city, timeView);

            Clock clock = AddClock(new ClockData(interval, ticksToEnd));
            clock.SecondTick += HandleSecondTick;
            clock.TimerEnded += OnTimerEnded;
            clock.AddCity(city, timeSpan);
        }

        private TimeView CreateTimeView(string city)
        {
            Font font = new Font(_fontName, _fontSize);
            Label label = new Label()
            {
                Font = font,
                Size = new Size(163, 25),
                Location = new Point(3, 10),
                
                TextAlign = ContentAlignment.MiddleCenter,
            };

            TextBox timeBox = new TextBox()
            {
                Font = font,
                Size = new Size(163, 25),
                Location = new Point(3, 38),
                TextAlign = HorizontalAlignment.Center,
            };

            Panel panel = new Panel()
            {
                AutoSize = true,
            };

            panel.Controls.Add(label);
            panel.Controls.Add(timeBox);

            MainLayoutPanel.Controls.Add(panel);

            TimeView timeView = new TimeView(city, label, timeBox);

            return timeView;
        }

        private Clock AddClock(ClockData clockData)
        {
            if(_clocks.ContainsKey(clockData))
                return _clocks[clockData];

            Clock clock = new Clock(clockData.Interval, clockData.TicksToEnd);
            _clocks.Add(clockData, clock);
            return clock;
        }

        private void HandleSecondTick(Clock clock)
        {
            foreach (var city in clock.Cities)
            {
                _cityViews[city].UpdateText(clock.GetCityTime(city));
            }
        }
        private void OnTimerEnded(Clock clock)
        {
            foreach (var city in clock.Cities)
            {
                MessageBox.Show($"{city} has ended its work");
            }
        }

        private void SwitchLocale(object sender, EventArgs e)
        {
            _isDefaultLocale = !_isDefaultLocale;
            string locale = "";

            if (_isDefaultLocale)
            {
                locale = _locales[0];
            }
            else
            {
                locale = _locales[1];
            }

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(locale);

            Controls.Clear();
            InitializeComponent();
            LocaleButton.Text = locale;
            InitializeForm();
        }

        private void StartClock()
        {
            foreach (var clock in _clocks.Values)
            {
                clock.Start();
            }
        }

        private void StopClock()
        {

            foreach (var clock in _clocks.Values)
            {
                clock.Stop();
            }
        }


        private void MenuStartClock_Click(object sender, EventArgs e)
        {
            StartClock();
        }

        private void MenuStopClock_Click(object sender, EventArgs e)
        {
            StopClock();
        }

    }

    class TimeView
    {
        public readonly Label Label;
        public readonly TextBox TextBox;

        public TimeView(string city, Label label, TextBox textBox)
        {
            Label = label;
            TextBox = textBox;
            Label.Text = city;
            TextBox.Text = Clock.DefaultValue;
        }

        public void UpdateText(string timeString)
        {
            TextBox.Text = timeString;
        }
    }

}
