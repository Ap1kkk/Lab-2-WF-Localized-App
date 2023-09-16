using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public MainForm()
        {
            InitializeComponent();

            _clock = new Clock(1000);

            _clock.SecondTick += HandleSecondTick;

            _clock.AddCity(_london, new TimeSpan());
            _clock.AddCity(_moscow, new TimeSpan(3, 0, 0));
            _clock.AddCity(_vladivostok, new TimeSpan(10, 0, 0));

        }
        ~MainForm()
        {
            _clock.SecondTick -= HandleSecondTick;
        }

        private void HandleSecondTick()
        {
            LondonTimeBox.Text = _clock.GetCityTime(_london);
            MoscowTimeBox.Text = _clock.GetCityTime(_moscow);
            VladivostokTimeBox.Text = _clock.GetCityTime(_vladivostok);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if((keyData & Keys.W) == Keys.W)
            {
                Console.WriteLine("Хуй");
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
