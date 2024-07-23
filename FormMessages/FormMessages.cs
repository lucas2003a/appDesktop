using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appDesktop.FormMultiplication;

namespace appDesktop.FormMessages
{
    public partial class FormMessages : Form 
    {
        private string Message { get; set; } = string.Empty;
        private int QuantityMessage { get; set; }
        public FormMessages()
        {
            InitializeComponent();
        }

        private void BtnToReplicate_Click(object sender, EventArgs e)
        {
            CheckText();
        }

        private void NumQuantityMessages_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CheckText()
        {
            string message = TxtMessage.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                Message = message;
                QuantityMessage = (int)NumQuantityMessages.Value;
                RenderList();
            }
            else
            {
                MessageBox.Show("El mensaje está vacío","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Bucle while
        /*private void RenderList()
        {
            int quantity = this.QuantityMessage;
            string message = this.Message;
            int counter = 1;

            LiMessages.Items.Clear();
            while (quantity > 0) 
            {
                LiMessages.Items.Add(
                    $"{counter}._{message}."
                    );

                quantity--;
                counter++;
            }
        }*/

        //Bucle do while
        private void RenderList()
        {
            int quantity = this.QuantityMessage;
            string message = this.Message;
            int counter = 1;

            LiMessages.Items.Clear();
            do
            {
                LiMessages.Items.Add(
                    $"{counter}._{message}."
                    );

                quantity--;
                counter++;
            }
            while (quantity > 0);
            
        }
    }
}
