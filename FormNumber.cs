using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDesktop
{
    public partial class FormNumber : Form
    {
        public FormNumber()
        {
            InitializeComponent();
        }

        private void BtnEvaluateNumber_Click(object sender, EventArgs e)
        {
            int number = (int)NumInput.Value;
            EvaluateNumber(number);
        }

        private void EvaluateNumber(int number)
        {
            if(number % 2 == 0)
            {
                ShowMessage($"EL número {number} es par", "Es par", MessageBoxIcon.Information);
            }
            else
            {
                ShowMessage($"EL número {number} es impar", "Es impar", MessageBoxIcon.Error);
            }
        }

        private void ShowMessage(string message, string title, MessageBoxIcon icon) 
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }
    }
}
