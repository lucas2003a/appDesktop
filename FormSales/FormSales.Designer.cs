namespace appDesktop
{
    partial class FormSales
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NumPrice = new NumericUpDown();
            BtnCalculateDiscount = new Button();
            NumDiscount = new NumericUpDown();
            NumTotal = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumTotal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 42);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Precio de venta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 76);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "Descuento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 111);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 0;
            label3.Text = "Total:";
            // 
            // NumPrice
            // 
            NumPrice.DecimalPlaces = 2;
            NumPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NumPrice.Location = new Point(161, 40);
            NumPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NumPrice.Name = "NumPrice";
            NumPrice.Size = new Size(120, 23);
            NumPrice.TabIndex = 1;
            // 
            // BtnCalculateDiscount
            // 
            BtnCalculateDiscount.Location = new Point(311, 38);
            BtnCalculateDiscount.Name = "BtnCalculateDiscount";
            BtnCalculateDiscount.Size = new Size(138, 23);
            BtnCalculateDiscount.TabIndex = 2;
            BtnCalculateDiscount.Text = "Calcular descuento";
            BtnCalculateDiscount.UseVisualStyleBackColor = true;
            BtnCalculateDiscount.Click += BtnCalculateDiscount_Click;
            // 
            // NumDiscount
            // 
            NumDiscount.DecimalPlaces = 2;
            NumDiscount.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NumDiscount.Location = new Point(161, 74);
            NumDiscount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NumDiscount.Name = "NumDiscount";
            NumDiscount.ReadOnly = true;
            NumDiscount.Size = new Size(120, 23);
            NumDiscount.TabIndex = 2;
            // 
            // NumTotal
            // 
            NumTotal.DecimalPlaces = 2;
            NumTotal.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NumTotal.Location = new Point(161, 109);
            NumTotal.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NumTotal.Name = "NumTotal";
            NumTotal.ReadOnly = true;
            NumTotal.Size = new Size(120, 23);
            NumTotal.TabIndex = 3;
            // 
            // FormSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 188);
            Controls.Add(BtnCalculateDiscount);
            Controls.Add(NumTotal);
            Controls.Add(NumDiscount);
            Controls.Add(NumPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSales";
            Text = "Formulario de venta";
            ((System.ComponentModel.ISupportInitialize)NumPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown NumPrice;
        private Button BtnCalculateDiscount;
        private NumericUpDown NumDiscount;
        private NumericUpDown NumTotal;
    }
}