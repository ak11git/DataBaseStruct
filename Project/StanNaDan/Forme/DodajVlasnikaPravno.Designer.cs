namespace StanNaDan.Forme
{
    partial class DodajVlasnikaPravno
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
            button11 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(255, 192, 128);
            button11.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button11.Location = new Point(192, 220);
            button11.Name = "button11";
            button11.Size = new Size(188, 53);
            button11.TabIndex = 14;
            button11.Text = "Dodaj Vlasnika";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(278, 24);
            label1.TabIndex = 15;
            label1.Text = "Osnovni podaci o Vlasniku:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label2.Location = new Point(64, 85);
            label2.Name = "label2";
            label2.Size = new Size(54, 24);
            label2.TabIndex = 16;
            label2.Text = "Ime:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 31);
            textBox1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label3.Location = new Point(33, 131);
            label3.Name = "label3";
            label3.Size = new Size(85, 24);
            label3.TabIndex = 19;
            label3.Text = "Drzava:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label4.Location = new Point(60, 175);
            label4.Name = "label4";
            label4.Size = new Size(58, 24);
            label4.TabIndex = 20;
            label4.Text = "PIB:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 31);
            textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 31);
            textBox3.TabIndex = 22;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // DodajVlasnika
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(394, 283);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button11);
            Name = "DodajVlasnika";
            Text = "DodajVlasnika";
            Load += DodajVlasnika_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button11;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}