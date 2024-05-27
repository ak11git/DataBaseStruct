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
            listView1 = new ListView();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
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
            // listView1
            // 
            listView1.Location = new Point(16, 31);
            listView1.Name = "listView1";
            listView1.Size = new Size(695, 448);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            button2.Location = new Point(802, 281);
            button2.Name = "button2";
            button2.Size = new Size(243, 53);
            button2.TabIndex = 4;
            button2.Text = "Obriši Vlasnika";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label1.Location = new Point(802, 128);
            label1.Name = "label1";
            label1.Size = new Size(243, 138);
            label1.TabIndex = 5;
            label1.Text = "NAPOMENA: Brisanjem vlasnika iz ove tabele nepovratno ga izbacujete iz sistema!";
            // 
            // label2
            // 
            label2.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label2.Location = new Point(802, 17);
            label2.Name = "label2";
            label2.Size = new Size(243, 74);
            label2.TabIndex = 6;
            label2.Text = "Svi vlasnici svojih nekretnina su prikazani u tabeli. ";
            // 
            // label3
            // 
            label3.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            label3.Location = new Point(874, 412);
            label3.Name = "label3";
            label3.Size = new Size(142, 50);
            label3.TabIndex = 18;
            label3.Text = "Ukupan broj Vlasnika:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(973, 465);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(72, 31);
            textBox1.TabIndex = 17;
            // 
            // VlasniciForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1078, 524);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "VlasniciForm";
            Text = "VlasniciForm";
            Load += VlasniciForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
    }
}