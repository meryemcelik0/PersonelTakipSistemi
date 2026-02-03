namespace PersonelSistemi
{
    partial class IzinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIzinPersonelId = new System.Windows.Forms.TextBox();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.cmbIzinTuru = new System.Windows.Forms.ComboBox();
            this.btnIzinKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = " PERSONEL ID:";
            // 
            // txtIzinPersonelId
            // 
            this.txtIzinPersonelId.Location = new System.Drawing.Point(268, 63);
            this.txtIzinPersonelId.Name = "txtIzinPersonelId";
            this.txtIzinPersonelId.ReadOnly = true;
            this.txtIzinPersonelId.Size = new System.Drawing.Size(224, 22);
            this.txtIzinPersonelId.TabIndex = 1;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(268, 101);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(224, 22);
            this.dtpBaslangic.TabIndex = 2;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(268, 135);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(224, 22);
            this.dtpBitis.TabIndex = 3;
            // 
            // cmbIzinTuru
            // 
            this.cmbIzinTuru.FormattingEnabled = true;
            this.cmbIzinTuru.Items.AddRange(new object[] {
            "Yıllık İzin",
            "Sağlık İzni",
            "Mazeret İzni"});
            this.cmbIzinTuru.Location = new System.Drawing.Point(268, 168);
            this.cmbIzinTuru.Name = "cmbIzinTuru";
            this.cmbIzinTuru.Size = new System.Drawing.Size(224, 24);
            this.cmbIzinTuru.TabIndex = 4;
            // 
            // btnIzinKaydet
            // 
            this.btnIzinKaydet.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnIzinKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIzinKaydet.Location = new System.Drawing.Point(293, 198);
            this.btnIzinKaydet.Name = "btnIzinKaydet";
            this.btnIzinKaydet.Size = new System.Drawing.Size(174, 38);
            this.btnIzinKaydet.TabIndex = 5;
            this.btnIzinKaydet.Text = "İZİN AL";
            this.btnIzinKaydet.UseVisualStyleBackColor = false;
            this.btnIzinKaydet.Click += new System.EventHandler(this.btnIzinKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAŞLANGIÇ TARİHİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "BİTİŞ TARİHİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "İZİN TÜRÜ:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 126);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(236, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "İZİN TALEP SİSTEMİ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnIzinKaydet);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtIzinPersonelId);
            this.panel2.Controls.Add(this.dtpBaslangic);
            this.panel2.Controls.Add(this.cmbIzinTuru);
            this.panel2.Controls.Add(this.dtpBitis);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(67, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 336);
            this.panel2.TabIndex = 10;
            // 
            // IzinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(793, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "IzinForm";
            this.Text = "İZİN TALEP FORMU";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.ComboBox cmbIzinTuru;
        private System.Windows.Forms.Button btnIzinKaydet;
        public System.Windows.Forms.TextBox txtIzinPersonelId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}