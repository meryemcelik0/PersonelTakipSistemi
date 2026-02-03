namespace PersonelSistemi
{
    partial class PerformanceForm
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
            this.cmbPersoneller = new System.Windows.Forms.ComboBox();
            this.numPuan = new System.Windows.Forms.NumericUpDown();
            this.txtYorum = new System.Windows.Forms.TextBox();
            this.btnPuanVer = new System.Windows.Forms.Button();
            this.dgvPerformans = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformans)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPersoneller
            // 
            this.cmbPersoneller.FormattingEnabled = true;
            this.cmbPersoneller.Location = new System.Drawing.Point(83, 54);
            this.cmbPersoneller.Name = "cmbPersoneller";
            this.cmbPersoneller.Size = new System.Drawing.Size(136, 24);
            this.cmbPersoneller.TabIndex = 0;
            // 
            // numPuan
            // 
            this.numPuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPuan.Location = new System.Drawing.Point(83, 95);
            this.numPuan.Name = "numPuan";
            this.numPuan.Size = new System.Drawing.Size(136, 22);
            this.numPuan.TabIndex = 1;
            // 
            // txtYorum
            // 
            this.txtYorum.Location = new System.Drawing.Point(57, 164);
            this.txtYorum.Multiline = true;
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.Size = new System.Drawing.Size(249, 130);
            this.txtYorum.TabIndex = 2;
            // 
            // btnPuanVer
            // 
            this.btnPuanVer.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPuanVer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPuanVer.Location = new System.Drawing.Point(57, 300);
            this.btnPuanVer.Name = "btnPuanVer";
            this.btnPuanVer.Size = new System.Drawing.Size(117, 35);
            this.btnPuanVer.TabIndex = 3;
            this.btnPuanVer.Text = "PUAN VER";
            this.btnPuanVer.UseVisualStyleBackColor = false;
            this.btnPuanVer.Click += new System.EventHandler(this.btnPuanVer_Click);
            // 
            // dgvPerformans
            // 
            this.dgvPerformans.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPerformans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerformans.Location = new System.Drawing.Point(351, 81);
            this.dgvPerformans.Name = "dgvPerformans";
            this.dgvPerformans.RowHeadersWidth = 51;
            this.dgvPerformans.RowTemplate.Height = 24;
            this.dgvPerformans.Size = new System.Drawing.Size(408, 254);
            this.dgvPerformans.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "PUAN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "YORUM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "PERSONEL ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(351, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 51);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(127, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "PERFORMANS ";
            // 
            // PerformanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPerformans);
            this.Controls.Add(this.btnPuanVer);
            this.Controls.Add(this.txtYorum);
            this.Controls.Add(this.numPuan);
            this.Controls.Add(this.cmbPersoneller);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "PerformanceForm";
            this.Text = "PERSONEL PERFORMANS GİRİŞ";
            this.Load += new System.EventHandler(this.PerformanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformans)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPersoneller;
        private System.Windows.Forms.NumericUpDown numPuan;
        private System.Windows.Forms.TextBox txtYorum;
        private System.Windows.Forms.Button btnPuanVer;
        private System.Windows.Forms.DataGridView dgvPerformans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}