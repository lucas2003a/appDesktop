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
    public partial class FormMonths : Form
    {
        private int SelectedOption { get; set; }
        public FormMonths()
        {
            InitializeComponent();
        }

        private void CmbNumberMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedOption = int.Parse(CmbNumberMonth.SelectedItem.ToString());
            TxtNameMonth.Text = GetMonth(SelectedOption);
        }

        private string GetMonth(int NumberMonth)
        {
            switch (NumberMonth)
            {
                case 1:
                    return "Enero";

                case 2:
                    return "Febrero";

                case 3:
                    return "Marzo";

                case 4:
                    return "Abril";

                case 5:
                    return "Mayo";

                case 6:
                    return "Junio";

                case 7:
                    return "Julio";

                case 8:
                    return "Agosto";

                case 9:
                    return "Septiembre";
                    
                case 10:
                    return "Octubre";

                case 11:
                    return "Noviembre";

                case 12:
                    return "Diciembre";
                default:
                    return "No hay un mes seleccionado";
                
            }
        }
    }
}
