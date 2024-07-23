namespace appDesktop
{
    partial class FormNumber
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
            NumInput = new NumericUpDown();
            BtnEvaluateNumber = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)NumInput).BeginInit();
            SuspendLayout();
            // 
            // NumInput
            // 
            NumInput.Location = new Point(98, 51);
            NumInput.Name = "NumInput";
            NumInput.Size = new Size(120, 23);
            NumInput.TabIndex = 0;
            NumInput.ValueChanged += NumInput_ValueChanged;
            // 
            // BtnEvaluateNumber
            // 
            BtnEvaluateNumber.Location = new Point(245, 51);
            BtnEvaluateNumber.Name = "BtnEvaluateNumber";
            BtnEvaluateNumber.Size = new Size(75, 23);
            BtnEvaluateNumber.TabIndex = 2;
            BtnEvaluateNumber.Text = "Evaluar número";
            BtnEvaluateNumber.UseVisualStyleBackColor = true;
            BtnEvaluateNumber.Click += BtnEvaluateNumber_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 53);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Número:";
            // 
            // FormNumber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 214);
            Controls.Add(label1);
            Controls.Add(BtnEvaluateNumber);
            Controls.Add(NumInput);
            Name = "FormNumber";
            Text = "FormNumber";
            ((System.ComponentModel.ISupportInitialize)NumInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumInput;
        private Button BtnEvaluateNumber;
        private Label label1;
    }
}