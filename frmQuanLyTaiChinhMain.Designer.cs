namespace Education_Manager
{
    partial class frmQuanLyTaiChinhMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQlyHocPhiSV = new System.Windows.Forms.Button();
            this.btnQlyHocPhiNganh = new System.Windows.Forms.Button();
            this.btnQlyPhieuThu = new System.Windows.Forms.Button();
            this.btnQlyThuChi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TÀI CHÍNH";
            // 
            // btnQlyHocPhiSV
            // 
            this.btnQlyHocPhiSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQlyHocPhiSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlyHocPhiSV.Location = new System.Drawing.Point(259, 234);
            this.btnQlyHocPhiSV.Name = "btnQlyHocPhiSV";
            this.btnQlyHocPhiSV.Size = new System.Drawing.Size(248, 63);
            this.btnQlyHocPhiSV.TabIndex = 2;
            this.btnQlyHocPhiSV.Text = "Quản lý học phí sinh viên";
            this.btnQlyHocPhiSV.UseVisualStyleBackColor = true;
            this.btnQlyHocPhiSV.Click += new System.EventHandler(this.btnQlyHocPhiSV_Click);
            // 
            // btnQlyHocPhiNganh
            // 
            this.btnQlyHocPhiNganh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQlyHocPhiNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlyHocPhiNganh.Location = new System.Drawing.Point(686, 234);
            this.btnQlyHocPhiNganh.Name = "btnQlyHocPhiNganh";
            this.btnQlyHocPhiNganh.Size = new System.Drawing.Size(248, 63);
            this.btnQlyHocPhiNganh.TabIndex = 3;
            this.btnQlyHocPhiNganh.Text = "Quản lý học phí ngành";
            this.btnQlyHocPhiNganh.UseVisualStyleBackColor = true;
            this.btnQlyHocPhiNganh.Click += new System.EventHandler(this.btnQlyHocPhiNganh_Click);
            // 
            // btnQlyPhieuThu
            // 
            this.btnQlyPhieuThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQlyPhieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlyPhieuThu.Location = new System.Drawing.Point(686, 382);
            this.btnQlyPhieuThu.Name = "btnQlyPhieuThu";
            this.btnQlyPhieuThu.Size = new System.Drawing.Size(248, 63);
            this.btnQlyPhieuThu.TabIndex = 4;
            this.btnQlyPhieuThu.Text = "Quản lý Phiếu Thu";
            this.btnQlyPhieuThu.UseVisualStyleBackColor = true;
            this.btnQlyPhieuThu.Click += new System.EventHandler(this.btnQlyPhieuThu_Click);
            // 
            // btnQlyThuChi
            // 
            this.btnQlyThuChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQlyThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlyThuChi.Location = new System.Drawing.Point(259, 382);
            this.btnQlyThuChi.Name = "btnQlyThuChi";
            this.btnQlyThuChi.Size = new System.Drawing.Size(248, 63);
            this.btnQlyThuChi.TabIndex = 5;
            this.btnQlyThuChi.Text = "Quản lý loại thu chi";
            this.btnQlyThuChi.UseVisualStyleBackColor = true;
            this.btnQlyThuChi.Click += new System.EventHandler(this.btnQlyThuChi_Click);
            // 
            // frmQuanLyTaiChinhMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 669);
            this.Controls.Add(this.btnQlyThuChi);
            this.Controls.Add(this.btnQlyPhieuThu);
            this.Controls.Add(this.btnQlyHocPhiNganh);
            this.Controls.Add(this.btnQlyHocPhiSV);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyTaiChinhMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyTaiChinhMain";
            this.Load += new System.EventHandler(this.frmQuanLyTaiChinhMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQlyHocPhiSV;
        private System.Windows.Forms.Button btnQlyHocPhiNganh;
        private System.Windows.Forms.Button btnQlyPhieuThu;
        private System.Windows.Forms.Button btnQlyThuChi;
    }
}