using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace appDesktop.FormMultiplication
{
    public partial class FormMultiplication : Form
    {
        private int Number { get; set; }

        public FormMultiplication()
        {
            InitializeComponent();
        }

        private void TxtNumber_TextChanged(object sender, EventArgs e)
        {
            string numberText = TxtNumber.Text;
            int number = 0;

            if (!string.IsNullOrWhiteSpace(numberText)) 
            { 
                 number = TransformString(numberText);
                checkRange(number);
            }
            else
            {
                ShowMessage("La cadena no debe de estar vacía",
                    "Error"
                    ,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            };
        }

        private void checkRange(int num)
        {

            if (num > 0)
            {
                RenderList(num);
            }
            else
            {
                ShowMessage("El número ingresado deber ser mayor a 0",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void RenderList(int num)
        {
            LiMultiplicationTable.Items.Clear(); //Limpia los elementos que contiene la lista

            for (int i = 1; i <= 12; i++)
            {
                //Agrega elementos a la lista
                LiMultiplicationTable.Items.Add(
                    $"{num} x {i} = {(num * i)}"
                    );
            }
        }

        private int TransformString(object num)
        {
            try
            {
                
                int number = int.Parse(num.ToString());
                return number;
            }
            catch (Exception error)
            {
                ShowMessage(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                ShowMessage($"el valor del número es: {num}",
                    "Datos"
                    ,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, buttons, icon);
        }

        private void LiMulriplicattionTable_Load(object sender, EventArgs e)
        {

        }
    }
}
