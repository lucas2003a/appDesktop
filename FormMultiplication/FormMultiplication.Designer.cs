namespace appDesktop.FormMultiplication
{
    partial class FormMultiplication
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
            LiMultiplicationTable = new ListBox();
            TxtNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // LiMultiplicationTable
            // 
            LiMultiplicationTable.FormattingEnabled = true;
            LiMultiplicationTable.ItemHeight = 15;
            LiMultiplicationTable.Location = new Point(48, 99);
            LiMultiplicationTable.Name = "LiMultiplicationTable";
            LiMultiplicationTable.ScrollAlwaysVisible = true;
            LiMultiplicationTable.Size = new Size(118, 94);
            LiMultiplicationTable.TabIndex = 0;
            // 
            // TxtNumber
            // 
            TxtNumber.Location = new Point(48, 41);
            TxtNumber.Name = "TxtNumber";
            TxtNumber.Size = new Size(100, 23);
            TxtNumber.TabIndex = 1;
            TxtNumber.TextChanged += TxtNumber_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 23);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 81);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Tabla:";
            // 
            // FormMultiplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 215);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtNumber);
            Controls.Add(LiMultiplicationTable);
            Name = "FormMultiplication";
            Text = "Multiplicación";
            Load += LiMulriplicattionTable_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LiMultiplicationTable;
        private TextBox TxtNumber;
        private Label label1;
        private Label label2;
    }
}