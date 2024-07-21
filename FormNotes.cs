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
    public partial class FormNotes : Form
    {
        public FormNotes()
        {
            InitializeComponent();

        }

        private void BtnCalculateAverage_Click(object sender, EventArgs e)
        {
            NumAverage.Value = CalculateAverage();
        }

        private decimal CalculateAverage() 
        {
            decimal note1, note2, note3, sum, average;

            note1 = NumNote1.Value;
            note2 = NumNote2.Value;
            note3 = NumNote3.Value;

            sum = note1 + note2 + note3;
            average = sum / 3;

            return average;
        }
    }
}
