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
    public partial class FormSales : Form
    {
        public FormSales()
        {
            InitializeComponent();
        }

        private void BtnCalculateDiscount_Click(object sender, EventArgs e)
        {
            getTotal();
        }

        private void getTotal()
        {
            decimal number = NumPrice.Value;

            decimal descuento = ProcesNumber(number);

            NumTotal.Value = descuento - number;
            NumDiscount.Value = descuento;

        }
        private decimal ProcesNumber(decimal number)
        {
            decimal descuento = 0;

            if (number > 100m) //La m al final del número, indica que es un tipo decimal
            {
                descuento = number * (decimal)0.05;

            }else if(number >= 150m)
            {
                descuento = number * (decimal)0.1;
            }else if(number >= 200m)
            {
                descuento = number * (decimal)0.15;
            }
            return descuento;
        }
    }
}
