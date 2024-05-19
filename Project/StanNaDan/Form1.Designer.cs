namespace StanNaDan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            prikaziBtn = new Button();
            dodajBtn = new Button();
            prikaziVlasnikaBtn = new Button();
            prikaziNekretnineVlasnikaBtn = new Button();
            dodajNekretninuIVlasnikaBtn = new Button();
            manyToManyNajamNekretnineBtn = new Button();
            poveziNajamNekretninaBtn = new Button();
            prikaziStanBtn = new Button();
            dodajStanBtn = new Button();
            ispitajTipNekretnineBtn = new Button();
            refreshVlasnikaBtn = new Button();
            imePrezimeVlasnikaBtn = new Button();
            prikaziPravnoLiceBtn = new Button();
            prikaziFizickoLiceBtn = new Button();
            prikaziNekretninuKvadraturaKuhinja = new Button();
            prikaziNekretninuSobaInternet = new Button();
            prikaziNekretninuParkingBtn = new Button();
            prikaziDrugih5NekretninaBtn = new Button();
            enumNekretnineBtn = new Button();
            prikaziKvartStanaVise20Btn = new Button();
            ukupnaKvSvihNekretninaBtn = new Button();
            prikaziBankRacuneVlasnikaBtn = new Button();
            SuspendLayout();
            // 
            // prikaziBtn
            // 
            prikaziBtn.Location = new Point(12, 12);
            prikaziBtn.Name = "prikaziBtn";
            prikaziBtn.Size = new Size(169, 34);
            prikaziBtn.TabIndex = 0;
            prikaziBtn.Text = "Prikazi Nekretninu";
            prikaziBtn.UseVisualStyleBackColor = true;
            prikaziBtn.Click += prikaziBtn_Click;
            // 
            // dodajBtn
            // 
            dodajBtn.Location = new Point(12, 52);
            dodajBtn.Name = "dodajBtn";
            dodajBtn.Size = new Size(169, 34);
            dodajBtn.TabIndex = 1;
            dodajBtn.Text = "Dodaj Nekretninu";
            dodajBtn.UseVisualStyleBackColor = true;
            dodajBtn.Click += dodajBtn_Click;
            // 
            // prikaziVlasnikaBtn
            // 
            prikaziVlasnikaBtn.Location = new Point(424, 12);
            prikaziVlasnikaBtn.Name = "prikaziVlasnikaBtn";
            prikaziVlasnikaBtn.Size = new Size(169, 34);
            prikaziVlasnikaBtn.TabIndex = 2;
            prikaziVlasnikaBtn.Text = "Prikazi Vlasnika";
            prikaziVlasnikaBtn.UseVisualStyleBackColor = true;
            prikaziVlasnikaBtn.Click += prikaziVlasnikaBtn_Click;
            // 
            // prikaziNekretnineVlasnikaBtn
            // 
            prikaziNekretnineVlasnikaBtn.Location = new Point(424, 212);
            prikaziNekretnineVlasnikaBtn.Name = "prikaziNekretnineVlasnikaBtn";
            prikaziNekretnineVlasnikaBtn.Size = new Size(253, 34);
            prikaziNekretnineVlasnikaBtn.TabIndex = 3;
            prikaziNekretnineVlasnikaBtn.Text = "Prikazi Nekretnine Vlasnika";
            prikaziNekretnineVlasnikaBtn.UseVisualStyleBackColor = true;
            prikaziNekretnineVlasnikaBtn.Click += prikaziNekretnineVlasnikaBtn_Click;
            // 
            // dodajNekretninuIVlasnikaBtn
            // 
            dodajNekretninuIVlasnikaBtn.Location = new Point(12, 212);
            dodajNekretninuIVlasnikaBtn.Name = "dodajNekretninuIVlasnikaBtn";
            dodajNekretninuIVlasnikaBtn.Size = new Size(250, 34);
            dodajNekretninuIVlasnikaBtn.TabIndex = 4;
            dodajNekretninuIVlasnikaBtn.Text = "Dodaj Nekretninu i Vlasnika";
            dodajNekretninuIVlasnikaBtn.UseVisualStyleBackColor = true;
            dodajNekretninuIVlasnikaBtn.Click += dodajNekretninuIVlasnikaBtn_Click;
            // 
            // manyToManyNajamNekretnineBtn
            // 
            manyToManyNajamNekretnineBtn.Location = new Point(12, 292);
            manyToManyNajamNekretnineBtn.Name = "manyToManyNajamNekretnineBtn";
            manyToManyNajamNekretnineBtn.Size = new Size(321, 34);
            manyToManyNajamNekretnineBtn.TabIndex = 5;
            manyToManyNajamNekretnineBtn.Text = "ManyToMany (Najam - Nekretnina)";
            manyToManyNajamNekretnineBtn.UseVisualStyleBackColor = true;
            manyToManyNajamNekretnineBtn.Click += manyToManyNajamNekretnineBtn_Click;
            // 
            // poveziNajamNekretninaBtn
            // 
            poveziNajamNekretninaBtn.Location = new Point(12, 252);
            poveziNajamNekretninaBtn.Name = "poveziNajamNekretninaBtn";
            poveziNajamNekretninaBtn.Size = new Size(250, 34);
            poveziNajamNekretninaBtn.TabIndex = 6;
            poveziNajamNekretninaBtn.Text = "Povezi Najam i Nekretninu";
            poveziNajamNekretninaBtn.UseVisualStyleBackColor = true;
            poveziNajamNekretninaBtn.Click += poveziNajamNekretninaBtn_Click;
            // 
            // prikaziStanBtn
            // 
            prikaziStanBtn.Location = new Point(12, 92);
            prikaziStanBtn.Name = "prikaziStanBtn";
            prikaziStanBtn.Size = new Size(169, 34);
            prikaziStanBtn.TabIndex = 7;
            prikaziStanBtn.Text = "Prikazi Stan";
            prikaziStanBtn.UseVisualStyleBackColor = true;
            prikaziStanBtn.Click += prikaziStanBtn_Click;
            // 
            // dodajStanBtn
            // 
            dodajStanBtn.Location = new Point(12, 132);
            dodajStanBtn.Name = "dodajStanBtn";
            dodajStanBtn.Size = new Size(169, 34);
            dodajStanBtn.TabIndex = 8;
            dodajStanBtn.Text = "Dodaj Stan";
            dodajStanBtn.UseVisualStyleBackColor = true;
            dodajStanBtn.Click += dodajStanBtn_Click;
            // 
            // ispitajTipNekretnineBtn
            // 
            ispitajTipNekretnineBtn.Location = new Point(12, 172);
            ispitajTipNekretnineBtn.Name = "ispitajTipNekretnineBtn";
            ispitajTipNekretnineBtn.Size = new Size(195, 34);
            ispitajTipNekretnineBtn.TabIndex = 9;
            ispitajTipNekretnineBtn.Text = "Ispitaj Tip Nekretnine";
            ispitajTipNekretnineBtn.UseVisualStyleBackColor = true;
            ispitajTipNekretnineBtn.Click += ispitajTipNekretnineBtn_Click;
            // 
            // refreshVlasnikaBtn
            // 
            refreshVlasnikaBtn.Location = new Point(424, 132);
            refreshVlasnikaBtn.Name = "refreshVlasnikaBtn";
            refreshVlasnikaBtn.Size = new Size(169, 34);
            refreshVlasnikaBtn.TabIndex = 10;
            refreshVlasnikaBtn.Text = "Refresh Vlasnika";
            refreshVlasnikaBtn.UseVisualStyleBackColor = true;
            refreshVlasnikaBtn.Click += refreshVlasnikaBtn_Click;
            // 
            // imePrezimeVlasnikaBtn
            // 
            imePrezimeVlasnikaBtn.Location = new Point(424, 172);
            imePrezimeVlasnikaBtn.Name = "imePrezimeVlasnikaBtn";
            imePrezimeVlasnikaBtn.Size = new Size(253, 34);
            imePrezimeVlasnikaBtn.TabIndex = 11;
            imePrezimeVlasnikaBtn.Text = "Ime i Prezime Vlasnika";
            imePrezimeVlasnikaBtn.UseVisualStyleBackColor = true;
            imePrezimeVlasnikaBtn.Click += imePrezimeVlasnikaBtn_Click;
            // 
            // prikaziPravnoLiceBtn
            // 
            prikaziPravnoLiceBtn.Location = new Point(424, 52);
            prikaziPravnoLiceBtn.Name = "prikaziPravnoLiceBtn";
            prikaziPravnoLiceBtn.Size = new Size(169, 34);
            prikaziPravnoLiceBtn.TabIndex = 12;
            prikaziPravnoLiceBtn.Text = "Prikazi Pravno Lice";
            prikaziPravnoLiceBtn.UseVisualStyleBackColor = true;
            prikaziPravnoLiceBtn.Click += prikaziPravnoLiceBtn_Click;
            // 
            // prikaziFizickoLiceBtn
            // 
            prikaziFizickoLiceBtn.Location = new Point(424, 92);
            prikaziFizickoLiceBtn.Name = "prikaziFizickoLiceBtn";
            prikaziFizickoLiceBtn.Size = new Size(169, 34);
            prikaziFizickoLiceBtn.TabIndex = 13;
            prikaziFizickoLiceBtn.Text = "Prikazi Fizicko Lice";
            prikaziFizickoLiceBtn.UseVisualStyleBackColor = true;
            prikaziFizickoLiceBtn.Click += prikaziFizickoLiceBtn_Click;
            // 
            // prikaziNekretninuKvadraturaKuhinja
            // 
            prikaziNekretninuKvadraturaKuhinja.Location = new Point(12, 532);
            prikaziNekretninuKvadraturaKuhinja.Name = "prikaziNekretninuKvadraturaKuhinja";
            prikaziNekretninuKvadraturaKuhinja.Size = new Size(321, 34);
            prikaziNekretninuKvadraturaKuhinja.TabIndex = 14;
            prikaziNekretninuKvadraturaKuhinja.Text = "Prikazi Nekretninu (200kv + kuhinja)";
            prikaziNekretninuKvadraturaKuhinja.UseVisualStyleBackColor = true;
            prikaziNekretninuKvadraturaKuhinja.Click += prikaziNekretninuKvadraturaKuhinja_Click;
            // 
            // prikaziNekretninuSobaInternet
            // 
            prikaziNekretninuSobaInternet.Location = new Point(12, 492);
            prikaziNekretninuSobaInternet.Name = "prikaziNekretninuSobaInternet";
            prikaziNekretninuSobaInternet.Size = new Size(321, 34);
            prikaziNekretninuSobaInternet.TabIndex = 15;
            prikaziNekretninuSobaInternet.Text = "Prikazi Nekretninu (Soba + internet)";
            prikaziNekretninuSobaInternet.UseVisualStyleBackColor = true;
            prikaziNekretninuSobaInternet.Click += prikaziNekretninuSobaInternet_Click;
            // 
            // prikaziNekretninuParkingBtn
            // 
            prikaziNekretninuParkingBtn.Location = new Point(12, 452);
            prikaziNekretninuParkingBtn.Name = "prikaziNekretninuParkingBtn";
            prikaziNekretninuParkingBtn.Size = new Size(321, 34);
            prikaziNekretninuParkingBtn.TabIndex = 16;
            prikaziNekretninuParkingBtn.Text = "Prikazi Nekretninu sa Parkingom";
            prikaziNekretninuParkingBtn.UseVisualStyleBackColor = true;
            prikaziNekretninuParkingBtn.Click += prikaziNekretninuParkingBtn_Click;
            // 
            // prikaziDrugih5NekretninaBtn
            // 
            prikaziDrugih5NekretninaBtn.Location = new Point(12, 412);
            prikaziDrugih5NekretninaBtn.Name = "prikaziDrugih5NekretninaBtn";
            prikaziDrugih5NekretninaBtn.Size = new Size(321, 34);
            prikaziDrugih5NekretninaBtn.TabIndex = 17;
            prikaziDrugih5NekretninaBtn.Text = "Prikazi drugih 5 Nekretnina";
            prikaziDrugih5NekretninaBtn.UseVisualStyleBackColor = true;
            prikaziDrugih5NekretninaBtn.Click += prikaziDrugih5NekretninaBtn_Click;
            // 
            // enumNekretnineBtn
            // 
            enumNekretnineBtn.Location = new Point(12, 572);
            enumNekretnineBtn.Name = "enumNekretnineBtn";
            enumNekretnineBtn.Size = new Size(321, 34);
            enumNekretnineBtn.TabIndex = 18;
            enumNekretnineBtn.Text = "Enumerable Nekretnine";
            enumNekretnineBtn.UseVisualStyleBackColor = true;
            enumNekretnineBtn.Click += enumNekretnineBtn_Click;
            // 
            // prikaziKvartStanaVise20Btn
            // 
            prikaziKvartStanaVise20Btn.Location = new Point(12, 372);
            prikaziKvartStanaVise20Btn.Name = "prikaziKvartStanaVise20Btn";
            prikaziKvartStanaVise20Btn.Size = new Size(321, 34);
            prikaziKvartStanaVise20Btn.TabIndex = 19;
            prikaziKvartStanaVise20Btn.Text = "Prikazi Kvart Stana >= 20kv";
            prikaziKvartStanaVise20Btn.UseVisualStyleBackColor = true;
            prikaziKvartStanaVise20Btn.Click += prikaziKvartStanaVise20Btn_Click;
            // 
            // ukupnaKvSvihNekretninaBtn
            // 
            ukupnaKvSvihNekretninaBtn.Location = new Point(12, 332);
            ukupnaKvSvihNekretninaBtn.Name = "ukupnaKvSvihNekretninaBtn";
            ukupnaKvSvihNekretninaBtn.Size = new Size(321, 34);
            ukupnaKvSvihNekretninaBtn.TabIndex = 20;
            ukupnaKvSvihNekretninaBtn.Text = "Ukupna kvadratura svih Nekretnina";
            ukupnaKvSvihNekretninaBtn.UseVisualStyleBackColor = true;
            ukupnaKvSvihNekretninaBtn.Click += ukupnaKvSvihNekretninaBtn_Click;
            // 
            // prikaziBankRacuneVlasnikaBtn
            // 
            prikaziBankRacuneVlasnikaBtn.Location = new Point(424, 252);
            prikaziBankRacuneVlasnikaBtn.Name = "prikaziBankRacuneVlasnikaBtn";
            prikaziBankRacuneVlasnikaBtn.Size = new Size(313, 34);
            prikaziBankRacuneVlasnikaBtn.TabIndex = 21;
            prikaziBankRacuneVlasnikaBtn.Text = "Prikazi Bankovne Racune Vlasnika";
            prikaziBankRacuneVlasnikaBtn.UseVisualStyleBackColor = true;
            prikaziBankRacuneVlasnikaBtn.Click += prikaziBankRacuneVlasnikaBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 609);
            Controls.Add(prikaziBankRacuneVlasnikaBtn);
            Controls.Add(ukupnaKvSvihNekretninaBtn);
            Controls.Add(prikaziKvartStanaVise20Btn);
            Controls.Add(enumNekretnineBtn);
            Controls.Add(prikaziDrugih5NekretninaBtn);
            Controls.Add(prikaziNekretninuParkingBtn);
            Controls.Add(prikaziNekretninuSobaInternet);
            Controls.Add(prikaziNekretninuKvadraturaKuhinja);
            Controls.Add(prikaziFizickoLiceBtn);
            Controls.Add(prikaziPravnoLiceBtn);
            Controls.Add(imePrezimeVlasnikaBtn);
            Controls.Add(refreshVlasnikaBtn);
            Controls.Add(ispitajTipNekretnineBtn);
            Controls.Add(dodajStanBtn);
            Controls.Add(prikaziStanBtn);
            Controls.Add(poveziNajamNekretninaBtn);
            Controls.Add(manyToManyNajamNekretnineBtn);
            Controls.Add(dodajNekretninuIVlasnikaBtn);
            Controls.Add(prikaziNekretnineVlasnikaBtn);
            Controls.Add(prikaziVlasnikaBtn);
            Controls.Add(dodajBtn);
            Controls.Add(prikaziBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button prikaziBtn;
        private Button dodajBtn;
        private Button prikaziVlasnikaBtn;
        private Button prikaziNekretnineVlasnikaBtn;
        private Button dodajNekretninuIVlasnikaBtn;
        private Button manyToManyNajamNekretnineBtn;
        private Button poveziNajamNekretninaBtn;
        private Button prikaziStanBtn;
        private Button dodajStanBtn;
        private Button ispitajTipNekretnineBtn;
        private Button refreshVlasnikaBtn;
        private Button imePrezimeVlasnikaBtn;
        private Button prikaziPravnoLiceBtn;
        private Button prikaziFizickoLiceBtn;
        private Button prikaziNekretninuKvadraturaKuhinja;
        private Button prikaziNekretninuSobaInternet;
        private Button prikaziNekretninuParkingBtn;
        private Button prikaziDrugih5NekretninaBtn;
        private Button enumNekretnineBtn;
        private Button prikaziKvartStanaVise20Btn;
        private Button ukupnaKvSvihNekretninaBtn;
        private Button prikaziBankRacuneVlasnikaBtn;
    }
}
