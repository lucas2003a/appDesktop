namespace appDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnShowMessage = new Button();
            TxtMessage = new TextBox();
            SuspendLayout();
            // 
            // BtnShowMessage
            // 
            BtnShowMessage.Location = new Point(91, 113);
            BtnShowMessage.Name = "BtnShowMessage";
            BtnShowMessage.Size = new Size(93, 23);
            BtnShowMessage.TabIndex = 0;
            BtnShowMessage.Text = "Ver mensaje";
            BtnShowMessage.UseVisualStyleBackColor = true;
            BtnShowMessage.Click += BtnShowMessage_Click;
            // 
            // TxtMessage
            // 
            TxtMessage.Location = new Point(25, 71);
            TxtMessage.Name = "TxtMessage";
            TxtMessage.PlaceholderText = "Mensaje";
            TxtMessage.Size = new Size(202, 23);
            TxtMessage.TabIndex = 1;
            // 
            // Form1
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(TxtMessage);
            Controls.Add(BtnShowMessage);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnShowMessage;
        private TextBox TxtMessage;
    }
}
