using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_WF_Localized_App
{
    public partial class MainForm : Form
    {
        private Clock _clock;

        private const string _london = "London";
        private const string _moscow = "Moscow";
        private const string _vladivostok = "Vladivostok";
        private const string _novosibirk = "Novosibirsk";
        private const string _newYork = "New York";

        private readonly string[] _locales = { "Ru-ru", "En-en" };
        private readonly string _initLocale = "Ru-ru";
        private bool _isDefaultLocale = true;

        public MainForm()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(_initLocale);

            InitializeComponent();

            LocaleButton.Text = _initLocale;
            
            _clock = new Clock();

            _clock.SecondTick += HandleSecondTick;
            _clock.TimerEnded += OnTimerEnded;

            InitializeForm();
            AddCities();
        }

        private void OnTimerEnded(string city)
        {
            MessageBox.Show($"{city} has ended its work");
        }

        ~MainForm()
        {
            _clock.SecondTick -= HandleSecondTick;
            _clock.TimerEnded -= OnTimerEnded;
        }

        private void InitializeForm()
        {
            LondonTimeBox.Text = _clock.GetCityTime(_clock.DefaultValue);
            MoscowTimeBox.Text = _clock.GetCityTime(_clock.DefaultValue);
            VladivostokTimeBox.Text = _clock.GetCityTime(_clock.DefaultValue);
            NovosibirskTimeBox.Text = _clock.GetCityTime(_clock.DefaultValue);
            NewYorkTimeBox.Text = _clock.GetCityTime(_clock.DefaultValue);
        }

        private void AddCities()
        {
            _clock.AddCity(_london, new TimeSpan(), 1000);
            _clock.AddCity(_moscow, new TimeSpan(3, 0, 0), 1000);
            _clock.AddCity(_vladivostok, new TimeSpan(10, 0, 0), 1000);
            _clock.AddCity(_novosibirk, new TimeSpan(4, 0, 0), 5000);
            _clock.AddCity(_newYork, new TimeSpan(4, 0, 0), 10000);
        }

        private void HandleSecondTick()
        {
            LondonTimeBox.Text = _clock.GetCityTime(_london);
            MoscowTimeBox.Text = _clock.GetCityTime(_moscow);
            VladivostokTimeBox.Text = _clock.GetCityTime(_vladivostok);
            NovosibirskTimeBox.Text = _clock.GetCityTime(_novosibirk);
            NewYorkTimeBox.Text = _clock.GetCityTime(_newYork);
        }

        private void SwitchLocale(object sender, EventArgs e)
        {
            _isDefaultLocale = !_isDefaultLocale;
            string locale = "";

            if(_isDefaultLocale)
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
            _clock.Start();
        }

        private void StopClock()
        {
            _clock.Stop();
        }

        private void MenuStartClock_Click(object sender, EventArgs e)
        {
            StartClock();
        }

        private void MenuStopClock_Click(object sender, EventArgs e)
        {
            StopClock();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
