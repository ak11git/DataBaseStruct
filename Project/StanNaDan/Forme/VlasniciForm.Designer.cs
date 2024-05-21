namespace StanNaDan.Forme
{
    partial class VlasniciForm
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
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(22, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(727, 495);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Vlasnika";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(770, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 244);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Podaci o Vlasnicima";
            // 
            // listView1
            // 
            listView1.Location = new Point(16, 31);
            listView1.Name = "listView1";
            listView1.Size = new Size(695, 448);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button1.Location = new Point(30, 31);
            button1.Name = "button1";
            button1.Size = new Size(223, 53);
            button1.TabIndex = 3;
            button1.Text = "Dodaj Vlasnika";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button2.Location = new Point(30, 90);
            button2.Name = "button2";
            button2.Size = new Size(223, 53);
            button2.TabIndex = 4;
            button2.Text = "Obriši Vlasnika";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button3.Location = new Point(30, 149);
            button3.Name = "button3";
            button3.Size = new Size(223, 53);
            button3.TabIndex = 5;
            button3.Text = "Izmeni Vlasnika";
            button3.UseVisualStyleBackColor = false;
            // 
            // VlasniciForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1078, 524);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "VlasniciForm";
            Text = "VlasniciForm";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView listView1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}