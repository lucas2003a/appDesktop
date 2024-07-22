namespace appDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnShowMessage_Click(object sender, EventArgs e)
        {
            String message = TxtMessage.Text;
            MessageBox.Show($"Mensaje escrito: {message}"); 
        }
    }
}
