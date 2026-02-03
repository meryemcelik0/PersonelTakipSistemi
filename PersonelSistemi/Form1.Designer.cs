namespace PersonelSistemi
{
    partial class Form1
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
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.personelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gorev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaasMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.numMaas = new System.Windows.Forms.NumericUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnIzinGit = new System.Windows.Forms.Button();
            this.btnIzinOnaylama = new System.Windows.Forms.Button();
            this.btnPerformans = new System.Windows.Forms.Button();
            this.cmbDepartmanlar = new System.Windows.Forms.ComboBox();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMaasForm = new System.Windows.Forms.Button();
            this.btnDepForm = new System.Windows.Forms.Button();
            this.lblSeciliId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelID,
            this.name,
            this.lastName,
            this.Gorev,
            this.TcNo,
            this.departmanId,
            this.MaasMiktar});
            this.dgvPersonel.Location = new System.Drawing.Point(238, 154);
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.RowHeadersWidth = 51;
            this.dgvPersonel.RowTemplate.Height = 24;
            this.dgvPersonel.Size = new System.Drawing.Size(622, 307);
            this.dgvPersonel.TabIndex = 0;
            this.dgvPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonel_CellClick);
            // 
            // personelID
            // 
            this.personelID.DataPropertyName = "personelID";
            this.personelID.HeaderText = "P.No";
            this.personelID.MinimumWidth = 6;
            this.personelID.Name = "personelID";
            this.personelID.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Ad";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "lastName";
            this.lastName.HeaderText = "Soyad";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.Width = 125;
            // 
            // Gorev
            // 
            this.Gorev.DataPropertyName = "Gorev";
            this.Gorev.HeaderText = "Görev";
            this.Gorev.MinimumWidth = 6;
            this.Gorev.Name = "Gorev";
            this.Gorev.Width = 125;
            // 
            // TcNo
            // 
            this.TcNo.DataPropertyName = "TcNo";
            this.TcNo.HeaderText = "TC";
            this.TcNo.MinimumWidth = 6;
            this.TcNo.Name = "TcNo";
            this.TcNo.Width = 125;
            // 
            // departmanId
            // 
            this.departmanId.DataPropertyName = "departmanId";
            this.departmanId.HeaderText = "Departman";
            this.departmanId.MinimumWidth = 6;
            this.departmanId.Name = "departmanId";
            this.departmanId.Width = 125;
            // 
            // MaasMiktar
            // 
            this.MaasMiktar.DataPropertyName = "MaasMiktar";
            this.MaasMiktar.HeaderText = "Maaş";
            this.MaasMiktar.MinimumWidth = 6;
            this.MaasMiktar.Name = "MaasMiktar";
            this.MaasMiktar.Width = 125;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnListele.Location = new System.Drawing.Point(500, 486);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(84, 44);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Personel Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(129, 74);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(134, 22);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(129, 102);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(134, 22);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(129, 130);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(134, 22);
            this.txtTc.TabIndex = 4;
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(129, 158);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(134, 22);
            this.txtGorev.TabIndex = 5;
            // 
            // numMaas
            // 
            this.numMaas.DecimalPlaces = 2;
            this.numMaas.Location = new System.Drawing.Point(129, 216);
            this.numMaas.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numMaas.Name = "numMaas";
            this.numMaas.Size = new System.Drawing.Size(135, 22);
            this.numMaas.TabIndex = 6;
            this.numMaas.ThousandsSeparator = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnKaydet.Location = new System.Drawing.Point(73, 244);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(97, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSil.Location = new System.Drawing.Point(176, 244);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuncelle.Location = new System.Drawing.Point(129, 273);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(97, 23);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnIzinGit
            // 
            this.btnIzinGit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIzinGit.Location = new System.Drawing.Point(16, 84);
            this.btnIzinGit.Name = "btnIzinGit";
            this.btnIzinGit.Size = new System.Drawing.Size(164, 23);
            this.btnIzinGit.TabIndex = 12;
            this.btnIzinGit.Text = "İZİN YAZ";
            this.btnIzinGit.UseVisualStyleBackColor = false;
            this.btnIzinGit.Click += new System.EventHandler(this.btnIzinGit_Click);
            // 
            // btnIzinOnaylama
            // 
            this.btnIzinOnaylama.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIzinOnaylama.Location = new System.Drawing.Point(16, 282);
            this.btnIzinOnaylama.Name = "btnIzinOnaylama";
            this.btnIzinOnaylama.Size = new System.Drawing.Size(164, 23);
            this.btnIzinOnaylama.TabIndex = 13;
            this.btnIzinOnaylama.Text = "İZİN YÖNETİMİ";
            this.btnIzinOnaylama.UseVisualStyleBackColor = false;
            this.btnIzinOnaylama.Click += new System.EventHandler(this.btnIzinYönetim_Click);
            // 
            // btnPerformans
            // 
            this.btnPerformans.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPerformans.Location = new System.Drawing.Point(16, 125);
            this.btnPerformans.Name = "btnPerformans";
            this.btnPerformans.Size = new System.Drawing.Size(164, 23);
            this.btnPerformans.TabIndex = 14;
            this.btnPerformans.Text = "PERFORMANS";
            this.btnPerformans.UseVisualStyleBackColor = false;
            this.btnPerformans.Click += new System.EventHandler(this.btnPerformansGit_Click);
            // 
            // cmbDepartmanlar
            // 
            this.cmbDepartmanlar.FormattingEnabled = true;
            this.cmbDepartmanlar.Location = new System.Drawing.Point(129, 186);
            this.cmbDepartmanlar.Name = "cmbDepartmanlar";
            this.cmbDepartmanlar.Size = new System.Drawing.Size(134, 24);
            this.cmbDepartmanlar.TabIndex = 15;
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRaporlar.Location = new System.Drawing.Point(16, 163);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(164, 23);
            this.btnRaporlar.TabIndex = 16;
            this.btnRaporlar.Text = "RAPORLAR";
            this.btnRaporlar.UseVisualStyleBackColor = false;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporGit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(82, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "İSİM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(51, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "SOYİSİM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(92, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(59, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "GÖREV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(17, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "DEPARTMAN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(70, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "MAAŞ:";
            // 
            // btnMaasForm
            // 
            this.btnMaasForm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMaasForm.Location = new System.Drawing.Point(16, 202);
            this.btnMaasForm.Name = "btnMaasForm";
            this.btnMaasForm.Size = new System.Drawing.Size(164, 23);
            this.btnMaasForm.TabIndex = 23;
            this.btnMaasForm.Text = "MAAŞ YÖNETİMİ";
            this.btnMaasForm.UseVisualStyleBackColor = false;
            this.btnMaasForm.Click += new System.EventHandler(this.btnMaasForm_Click);
            // 
            // btnDepForm
            // 
            this.btnDepForm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDepForm.Location = new System.Drawing.Point(16, 242);
            this.btnDepForm.Name = "btnDepForm";
            this.btnDepForm.Size = new System.Drawing.Size(166, 23);
            this.btnDepForm.TabIndex = 24;
            this.btnDepForm.Text = "DEPARTMANLAR";
            this.btnDepForm.UseVisualStyleBackColor = false;
            this.btnDepForm.Click += new System.EventHandler(this.btnDepForm_Click);
            // 
            // lblSeciliId
            // 
            this.lblSeciliId.AutoSize = true;
            this.lblSeciliId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSeciliId.Location = new System.Drawing.Point(291, 3);
            this.lblSeciliId.Name = "lblSeciliId";
            this.lblSeciliId.Size = new System.Drawing.Size(11, 16);
            this.lblSeciliId.TabIndex = 25;
            this.lblSeciliId.Text = ".";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnIzinGit);
            this.panel1.Controls.Add(this.btnIzinOnaylama);
            this.panel1.Controls.Add(this.btnDepForm);
            this.panel1.Controls.Add(this.btnPerformans);
            this.panel1.Controls.Add(this.btnMaasForm);
            this.panel1.Controls.Add(this.btnRaporlar);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 501);
            this.panel1.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(57, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "SİSTEMİ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(47, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "PERSONEL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "PERSONEL ARA:";
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(368, 114);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(492, 27);
            this.txtArama.TabIndex = 29;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(69, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "PERSONEL";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(91, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "      BİLGİLERİ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbDepartmanlar);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtAd);
            this.panel2.Controls.Add(this.lblSeciliId);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.txtSoyad);
            this.panel2.Controls.Add(this.btnKaydet);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTc);
            this.panel2.Controls.Add(this.numMaas);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtGorev);
            this.panel2.Location = new System.Drawing.Point(906, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 343);
            this.panel2.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(235, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(452, 48);
            this.label10.TabIndex = 33;
            this.label10.Text = "PERSONEL YÖNETİMİ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1235, 544);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgvPersonel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "PERSONEL YÖNETİMİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.NumericUpDown numMaas;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnIzinGit;
        private System.Windows.Forms.Button btnIzinOnaylama;
        private System.Windows.Forms.Button btnPerformans;
        private System.Windows.Forms.ComboBox cmbDepartmanlar;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMaasForm;
        private System.Windows.Forms.Button btnDepForm;
        private System.Windows.Forms.Label lblSeciliId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gorev;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaasMiktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

