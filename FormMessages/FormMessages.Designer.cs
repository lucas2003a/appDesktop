namespace appDesktop.FormMessages
{
    partial class FormMessages
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
            TxtMessage = new TextBox();
            NumQuantityMessages = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            BtnToReplicate = new Button();
            LiMessages = new ListBox();
            ((System.ComponentModel.ISupportInitialize)NumQuantityMessages).BeginInit();
            SuspendLayout();
            // 
            // TxtMessage
            // 
            TxtMessage.Location = new Point(39, 104);
            TxtMessage.Multiline = true;
            TxtMessage.Name = "TxtMessage";
            TxtMessage.ScrollBars = ScrollBars.Vertical;
            TxtMessage.Size = new Size(266, 23);
            TxtMessage.TabIndex = 2;
            // 
            // NumQuantityMessages
            // 
            NumQuantityMessages.Location = new Point(160, 44);
            NumQuantityMessages.Name = "NumQuantityMessages";
            NumQuantityMessages.Size = new Size(120, 23);
            NumQuantityMessages.TabIndex = 1;
            NumQuantityMessages.ValueChanged += NumQuantityMessages_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 46);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 2;
            label1.Text = "Cantidad de mensajes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 86);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 2;
            label2.Text = "Mensaje a replicar:";
            // 
            // BtnToReplicate
            // 
            BtnToReplicate.Location = new Point(124, 133);
            BtnToReplicate.Name = "BtnToReplicate";
            BtnToReplicate.Size = new Size(75, 23);
            BtnToReplicate.TabIndex = 3;
            BtnToReplicate.Text = "Replicar";
            BtnToReplicate.UseVisualStyleBackColor = true;
            BtnToReplicate.Click += BtnToReplicate_Click;
            // 
            // LiMessages
            // 
            LiMessages.FormattingEnabled = true;
            LiMessages.ItemHeight = 15;
            LiMessages.Items.AddRange(new object[] { "Mensajes" });
            LiMessages.Location = new Point(40, 175);
            LiMessages.Name = "LiMessages";
            LiMessages.ScrollAlwaysVisible = true;
            LiMessages.Size = new Size(265, 244);
            LiMessages.TabIndex = 4;
            // 
            // FormMessages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 450);
            Controls.Add(LiMessages);
            Controls.Add(BtnToReplicate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NumQuantityMessages);
            Controls.Add(TxtMessage);
            Name = "FormMessages";
            Text = "Mensajes";
            ((System.ComponentModel.ISupportInitialize)NumQuantityMessages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtMessage;
        private NumericUpDown NumQuantityMessages;
        private Label label1;
        private Label label2;
        private Button BtnToReplicate;
        private ListBox LiMessages;
    }
}