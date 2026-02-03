namespace PersonelSistemi
{
    partial class DepartmentForm
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
            this.txtYeniDep = new System.Windows.Forms.TextBox();
            this.btnDepEkle = new System.Windows.Forms.Button();
            this.dgvDepartmanlar = new System.Windows.Forms.DataGridView();
            this.cmbDepSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmanlar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtYeniDep
            // 
            this.txtYeniDep.Location = new System.Drawing.Point(154, 21);
            this.txtYeniDep.Name = "txtYeniDep";
            this.txtYeniDep.Size = new System.Drawing.Size(143, 22);
            this.txtYeniDep.TabIndex = 0;
            // 
            // btnDepEkle
            // 
            this.btnDepEkle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDepEkle.Location = new System.Drawing.Point(193, 49);
            this.btnDepEkle.Name = "btnDepEkle";
            this.btnDepEkle.Size = new System.Drawing.Size(84, 23);
            this.btnDepEkle.TabIndex = 1;
            this.btnDepEkle.Text = "EKLE";
            this.btnDepEkle.UseVisualStyleBackColor = false;
            this.btnDepEkle.Click += new System.EventHandler(this.btnDepEkle_Click);
            // 
            // dgvDepartmanlar
            // 
            this.dgvDepartmanlar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDepartmanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmanlar.Location = new System.Drawing.Point(35, 77);
            this.dgvDepartmanlar.Name = "dgvDepartmanlar";
            this.dgvDepartmanlar.RowHeadersWidth = 51;
            this.dgvDepartmanlar.RowTemplate.Height = 24;
            this.dgvDepartmanlar.Size = new System.Drawing.Size(617, 323);
            this.dgvDepartmanlar.TabIndex = 2;
            // 
            // cmbDepSec
            // 
            this.cmbDepSec.FormattingEnabled = true;
            this.cmbDepSec.Location = new System.Drawing.Point(461, 16);
            this.cmbDepSec.Name = "cmbDepSec";
            this.cmbDepSec.Size = new System.Drawing.Size(143, 24);
            this.cmbDepSec.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(321, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "DEPARTMAN SEÇ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "YENİ DEPARTMAN:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(35, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 50);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(464, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "PERSONEL SAYISI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "DEPARTMAN ADI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbDepSec);
            this.panel2.Controls.Add(this.btnDepEkle);
            this.panel2.Controls.Add(this.txtYeniDep);
            this.panel2.Location = new System.Drawing.Point(35, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 124);
            this.panel2.TabIndex = 7;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSil.Location = new System.Drawing.Point(483, 49);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(84, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDepartmanlar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "DepartmentForm";
            this.Text = "DEPARTMAN VE BİRİM YÖNETİMİ";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmanlar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtYeniDep;
        private System.Windows.Forms.Button btnDepEkle;
        private System.Windows.Forms.DataGridView dgvDepartmanlar;
        private System.Windows.Forms.ComboBox cmbDepSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSil;
    }
}