namespace appDesktop
{
    partial class FormMonths
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CmbNumberMonth = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            TxtNameMonth = new TextBox();
            SuspendLayout();
            // 
            // CmbNumberMonth
            // 
            CmbNumberMonth.FormattingEnabled = true;
            CmbNumberMonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            CmbNumberMonth.Location = new Point(131, 33);
            CmbNumberMonth.Name = "CmbNumberMonth";
            CmbNumberMonth.Size = new Size(121, 23);
            CmbNumberMonth.TabIndex = 0;
            CmbNumberMonth.SelectedIndexChanged += CmbNumberMonth_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 36);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Número del mes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 67);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre del mes:";
            // 
            // TxtNameMonth
            // 
            TxtNameMonth.Location = new Point(131, 64);
            TxtNameMonth.Name = "TxtNameMonth";
            TxtNameMonth.Size = new Size(121, 23);
            TxtNameMonth.TabIndex = 2;
            // 
            // FormMonths
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 101);
            Controls.Add(TxtNameMonth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CmbNumberMonth);
            Name = "FormMonths";
            Text = "FormMonths";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CmbNumberMonth;
        private Label label1;
        private Label label2;
        private TextBox TxtNameMonth;
    }
}