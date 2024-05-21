namespace StanNaDan.Forme
{
    partial class NajmoviForm
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
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            groupBox2 = new GroupBox();
            button11 = new Button();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(29, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(731, 523);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Najmova";
            // 
            // listView1
            // 
            listView1.Location = new Point(19, 30);
            listView1.Name = "listView1";
            listView1.Size = new Size(691, 474);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button11);
            groupBox2.Location = new Point(777, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 270);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Podaci o Najmovima";
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(255, 192, 128);
            button11.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button11.Location = new Point(22, 30);
            button11.Name = "button11";
            button11.Size = new Size(223, 53);
            button11.TabIndex = 13;
            button11.Text = "Dodaj Najam";
            button11.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button1.Location = new Point(22, 89);
            button1.Name = "button1";
            button1.Size = new Size(223, 53);
            button1.TabIndex = 14;
            button1.Text = "Obriši Najam";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button2.Location = new Point(22, 148);
            button2.Name = "button2";
            button2.Size = new Size(223, 53);
            button2.TabIndex = 15;
            button2.Text = "Izmeni Najam";
            button2.UseVisualStyleBackColor = false;
            // 
            // NajmoviForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1054, 563);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NajmoviForm";
            Text = "NajmoviForm";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private Button button11;
    }
}