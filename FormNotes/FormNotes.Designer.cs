namespace appDesktop
{
    partial class FormNotes
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
            Lbl_note1 = new Label();
            LblNote2 = new Label();
            LblNote3 = new Label();
            LblAverage = new Label();
            NumNote1 = new NumericUpDown();
            NumNote2 = new NumericUpDown();
            NumNote3 = new NumericUpDown();
            NumAverage = new NumericUpDown();
            BtnCalculateAverage = new Button();
            ((System.ComponentModel.ISupportInitialize)NumNote1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumNote2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumNote3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumAverage).BeginInit();
            SuspendLayout();
            // 
            // Lbl_note1
            // 
            Lbl_note1.AutoSize = true;
            Lbl_note1.Location = new Point(43, 49);
            Lbl_note1.Name = "Lbl_note1";
            Lbl_note1.Size = new Size(42, 15);
            Lbl_note1.TabIndex = 0;
            Lbl_note1.Text = "Nota 1";
            // 
            // LblNote2
            // 
            LblNote2.AutoSize = true;
            LblNote2.Location = new Point(43, 78);
            LblNote2.Name = "LblNote2";
            LblNote2.Size = new Size(42, 15);
            LblNote2.TabIndex = 1;
            LblNote2.Text = "Nota 2";
            // 
            // LblNote3
            // 
            LblNote3.AutoSize = true;
            LblNote3.Location = new Point(43, 107);
            LblNote3.Name = "LblNote3";
            LblNote3.Size = new Size(42, 15);
            LblNote3.TabIndex = 1;
            LblNote3.Text = "Nota 3";
            // 
            // LblAverage
            // 
            LblAverage.AutoSize = true;
            LblAverage.Location = new Point(43, 136);
            LblAverage.Name = "LblAverage";
            LblAverage.Size = new Size(59, 15);
            LblAverage.TabIndex = 1;
            LblAverage.Text = "Promedio";
            // 
            // NumNote1
            // 
            NumNote1.DecimalPlaces = 1;
            NumNote1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NumNote1.Location = new Point(115, 47);
            NumNote1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NumNote1.Name = "NumNote1";
            NumNote1.Size = new Size(120, 23);
            NumNote1.TabIndex = 1;
            // 
            // NumNote2
            // 
            NumNote2.DecimalPlaces = 1;
            NumNote2.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NumNote2.Location = new Point(115, 76);
            NumNote2.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NumNote2.Name = "NumNote2";
            NumNote2.Size = new Size(120, 23);
            NumNote2.TabIndex = 2;
            // 
            // NumNote3
            // 
            NumNote3.DecimalPlaces = 1;
            NumNote3.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NumNote3.Location = new Point(115, 105);
            NumNote3.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NumNote3.Name = "NumNote3";
            NumNote3.Size = new Size(120, 23);
            NumNote3.TabIndex = 3;
            // 
            // NumAverage
            // 
            NumAverage.DecimalPlaces = 1;
            NumAverage.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NumAverage.Location = new Point(115, 134);
            NumAverage.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NumAverage.Name = "NumAverage";
            NumAverage.ReadOnly = true;
            NumAverage.Size = new Size(120, 23);
            NumAverage.TabIndex = 4;
            // 
            // BtnCalculateAverage
            // 
            BtnCalculateAverage.BackColor = SystemColors.GradientActiveCaption;
            BtnCalculateAverage.ForeColor = SystemColors.ControlText;
            BtnCalculateAverage.Location = new Point(115, 174);
            BtnCalculateAverage.Name = "BtnCalculateAverage";
            BtnCalculateAverage.Size = new Size(120, 23);
            BtnCalculateAverage.TabIndex = 4;
            BtnCalculateAverage.Text = "Calcular promedio";
            BtnCalculateAverage.UseVisualStyleBackColor = false;
            BtnCalculateAverage.Click += BtnCalculateAverage_Click;
            // 
            // FormNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 236);
            Controls.Add(BtnCalculateAverage);
            Controls.Add(NumAverage);
            Controls.Add(NumNote3);
            Controls.Add(NumNote2);
            Controls.Add(NumNote1);
            Controls.Add(LblAverage);
            Controls.Add(LblNote3);
            Controls.Add(LblNote2);
            Controls.Add(Lbl_note1);
            Name = "FormNotes";
            Text = "Calcular promedio";
            ((System.ComponentModel.ISupportInitialize)NumNote1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumNote2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumNote3).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumAverage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_note1;
        private Label LblNote2;
        private Label LblNote3;
        private Label LblAverage;
        private NumericUpDown NumNote1;
        private NumericUpDown NumNote2;
        private NumericUpDown NumNote3;
        private NumericUpDown NumAverage;
        private Button BtnCalculateAverage;
    }
}