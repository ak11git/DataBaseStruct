namespace StanNaDan.Forme
{
    partial class IzmeniVlasnikaPravno
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button11 = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(115, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 31);
            textBox3.TabIndex = 30;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(115, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 31);
            textBox2.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label4.Location = new Point(51, 160);
            label4.Name = "label4";
            label4.Size = new Size(58, 24);
            label4.TabIndex = 28;
            label4.Text = "PIB:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label3.Location = new Point(24, 116);
            label3.Name = "label3";
            label3.Size = new Size(85, 24);
            label3.TabIndex = 27;
            label3.Text = "Drzava:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 31);
            textBox1.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label2.Location = new Point(55, 70);
            label2.Name = "label2";
            label2.Size = new Size(54, 24);
            label2.TabIndex = 25;
            label2.Text = "Ime:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 24);
            label1.TabIndex = 24;
            label1.Text = "Osnovni podaci o Vlasniku:";
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(255, 192, 128);
            button11.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button11.Location = new Point(173, 205);
            button11.Name = "button11";
            button11.Size = new Size(198, 53);
            button11.TabIndex = 23;
            button11.Text = "Izmeni Vlasnika";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // IzmeniVlasnikaPravno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(385, 273);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button11);
            Name = "IzmeniVlasnikaPravno";
            Text = "IzmeniVlasnikaPravno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button11;
    }
}