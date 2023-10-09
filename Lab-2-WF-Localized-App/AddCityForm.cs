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
    public partial class AddCityForm : Form
    {
        private MainForm _mainForm;

        public AddCityForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void OnSubmit(object sender, EventArgs e)
        {
            if(ValidateInput())
            {
                Console.WriteLine($"{CityInput.Text} | {int.Parse(TimeShiftInput.Value.ToString())} | {int.Parse(IntervalInput.Value.ToString())} | {int.Parse(MaxTicksInput.Value.ToString())}");
                _mainForm.HandleInput(CityInput.Text, int.Parse(TimeShiftInput.Value.ToString()), int.Parse(IntervalInput.Value.ToString()), int.Parse(MaxTicksInput.Value.ToString()));
            }
        }

        private bool ValidateInput()
        {
            if(CityInput.Text == "")
            {
                MessageBox.Show(MainResources.InvalidCityInput, MainResources.InvalidInputCaption);
                return false;
            }

            return true;
        }
    }
}
