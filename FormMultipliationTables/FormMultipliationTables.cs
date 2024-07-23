using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDesktop.FormMultipliationTables
{
    public partial class FormMultipliationTables : Form
    {
        public FormMultipliationTables()
        {
            InitializeComponent();
        }

        private void LiTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormMultipliationTables_Load(object sender, EventArgs e)
        {
            RenderList();
        }

        private void RenderList()
        {
            int limitTables = 12;
            LiTables.Items.Clear();

            for (int multiplier = 1; multiplier <= limitTables; multiplier++)
            {
                LiTables.Items.Add("Tabla del " + multiplier);

                for(int multiplicand = 1; multiplicand <= limitTables; multiplicand++)
                {
                    LiTables.Items.Add(
                        $"{multiplier} x {multiplicand} = {(multiplier * multiplicand)}"
                        );
                }
                LiTables.Items.Add("");
            }
        }
    }
}
