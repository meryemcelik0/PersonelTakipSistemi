namespace PersonelSistemi
{
    partial class IzinOnayForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBekleyenIzinler = new System.Windows.Forms.DataGridView();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnReddet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBekleyenIzinler)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBekleyenIzinler
            // 
            this.dgvBekleyenIzinler.BackgroundColor = System.Drawing.Color.White;
            this.dgvBekleyenIzinler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBekleyenIzinler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBekleyenIzinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBekleyenIzinler.EnableHeadersVisualStyles = false;
            this.dgvBekleyenIzinler.Location = new System.Drawing.Point(120, 123);
            this.dgvBekleyenIzinler.Name = "dgvBekleyenIzinler";
            this.dgvBekleyenIzinler.RowHeadersWidth = 51;
            this.dgvBekleyenIzinler.RowTemplate.Height = 24;
            this.dgvBekleyenIzinler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBekleyenIzinler.Size = new System.Drawing.Size(558, 252);
            this.dgvBekleyenIzinler.TabIndex = 0;
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnOnayla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOnayla.Location = new System.Drawing.Point(162, 396);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(225, 41);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "İZİN ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnReddet
            // 
            this.btnReddet.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnReddet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReddet.Location = new System.Drawing.Point(426, 396);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(223, 41);
            this.btnReddet.TabIndex = 2;
            this.btnReddet.Text = "İZİN REDDET";
            this.btnReddet.UseVisualStyleBackColor = false;
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 106);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(155, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEKLEYEN İZİN TALEPLERİ";
            // 
            // IzinOnayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dgvBekleyenIzinler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "IzinOnayForm";
            this.Text = "İZİN ONAYLAMA FORMU";
            this.Load += new System.EventHandler(this.IzinOnayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBekleyenIzinler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBekleyenIzinler;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnReddet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}