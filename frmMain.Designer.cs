using System.Drawing;
using System.Windows.Forms;

namespace Education_Manager
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhânCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLoạiCSVCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýCSVCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhenThưởngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThờiKhóaBiểuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoHọcKỳToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblWelcome = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnQuanLyNganh = new System.Windows.Forms.Button();
            this.btnQuanLyKhoa = new System.Windows.Forms.Button();
            this.btnQuanLyThoiKhoaBieu = new System.Windows.Forms.Button();
            this.btnQuanLyNguoiDung = new System.Windows.Forms.Button();
            this.btnQuanLyKhenThuong = new System.Windows.Forms.Button();
            this.btnQuanLyCSVC = new System.Windows.Forms.Button();
            this.btnQuanLyKhoi = new System.Windows.Forms.Button();
            this.btnQuanLyLoaiCSVC = new System.Windows.Forms.Button();
            this.btnQuanLyPhanCong = new System.Windows.Forms.Button();
            this.btnQuanLyDiem = new System.Windows.Forms.Button();
            this.btnQuanLyMonHoc = new System.Windows.Forms.Button();
            this.btnQuanLyLop = new System.Windows.Forms.Button();
            this.btnQuanLyGiaoVien = new System.Windows.Forms.Button();
            this.btnQuanLyHocSinh = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnQuanLyTaiChinh = new System.Windows.Forms.Button();
            this.quảnLýTàiChínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.thốngKêBáoCáoToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1333, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hệThốngToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hệThốngToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(187, 32);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(187, 32);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSinhViênToolStripMenuItem,
            this.quảnLýGiáoViênToolStripMenuItem,
            this.quảnLýLớpToolStripMenuItem,
            this.quảnLýMônHọcToolStripMenuItem,
            this.quảnLýĐiểmToolStripMenuItem,
            this.quảnLýPhânCôngToolStripMenuItem,
            this.quảnLýLoạiCSVCToolStripMenuItem,
            this.quảnLýCSVCToolStripMenuItem,
            this.quảnLýKhoiToolStripMenuItem,
            this.quảnLýKhenThưởngToolStripMenuItem,
            this.quảnLýNgườiDùngToolStripMenuItem,
            this.quảnLýThờiKhóaBiểuToolStripMenuItem,
            this.quảnLýTàiChínhToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quảnLýToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(93, 32);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(340, 32);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Quản lý Thông tin Sinh Viên";
            this.quảnLýSinhViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHọcSinhToolStripMenuItem_Click);
            // 
            // quảnLýGiáoViênToolStripMenuItem
            // 
            this.quảnLýGiáoViênToolStripMenuItem.Name = "quảnLýGiáoViênToolStripMenuItem";
            this.quảnLýGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(340, 32);
            this.quảnLýGiáoViênToolStripMenuItem.Text = "Quản lý Giáo viên";
            this.quảnLýGiáoViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýGiáoViênToolStripMenuItem_Click);
            // 
            // quảnLýLớpToolStripMenuItem
            // 
            this.quảnLýLớpToolStripMenuItem.Name = "quảnLýLớpToolStripMenuItem";
            this.quảnLýLớpToolStripMenuItem.Size = new System.Drawing.Size(340, 32);
            this.quảnLýLớpToolStripMenuItem.Text = "Quản lý Lớp";
            this.quảnLýLớpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLớpToolStripMenuItem_Click);
            // 
            // quảnLýMônHọcToolStripMenuItem
            // 
            this.quảnLýMônHọcToolStripMenuItem.Name = "quảnLýMônHọcToolStripMenuItem";
            this.quảnLýMônHọcToolStripMenuItem.Size = new System.Drawing.Size(340, 32);
            this.quảnLýMônHọcToolStripMenuItem.Text = "Quản lý Môn học";
            this.quảnLýMônHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMônHọcToolStripMenuItem_Click);
            // 
            // quảnLýĐiểmToolStripMenuItem
            // 
            this.quảnLýĐiểmToolStripMenuItem.Name = "quảnLýĐiểmToolStripMenuItem";
            this.quảnLýĐiểmToolStripMenuItem.Size = new System.Drawing.Size(340, 32);
            this.quảnLýĐiểmToolStripMenuItem.Text = "Quản lý Kết quả học tập";
            this.quảnLýĐiểmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐiểmToolStripMenuItem_Click);
            // 
            // quảnLýPhânCôngToolStripMenuItem
            // 
            this.quảnLýPhânCôngToolStripMenuItem.Name = "quảnLýPhânCôngToolStripMenuItem";
            this.quảnLýPhânCôngToolStripMenuItem.Size = new System.Drawing.Size(340, 32);
            this.quảnLýPhânCôngToolStripMenuItem.Text = "Quản lý Phân công";
            this.quảnLýPhânCôngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýPhânCôngToolStripMenuItem_Click);
            // 
            // quảnLýLoạiCSVCToolStripMenuItem
            // 
            this.quảnLýLoạiCSVCToolStripMenuItem.Name = "quảnLýLoạiCSVCToolStripMenuItem";
            this.quảnLýLoạiCSVCToolStripMenuItem.Size = new System.Drawing.Size(340, 32);
            this.quảnLýLoạiCSVCToolStripMenuItem.Text = "Quản lý loại CSVC";
            this.quảnLýLoạiCSVCToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLoạiCSVCToolStripMenuItem_Click);
            // 
            // quảnLýCSVCToolStripMenuItem
            // 
            this.quảnLýCSVCToolStripMenuItem.Name = "quảnLýCSVCToolStripMenuItem";
            this.quảnLýCSVCToolStripMenuItem.Size = new System.Drawing.Size(340, 32);
            this.quảnLýCSVCToolStripMenuItem.Text = "Quản lý Khối";
            this.quảnLýCSVCToolStripMenuItem.Click += new System.EventHandler(this.quảnLýCSVCToolStripMenuItem_Click_1);
            // 
            // quảnLýKhoiToolStripMenuItem
            // 
            this.quảnLýKhoiToolStripMenuItem.Name = "quảnLýKhoiToolStripMenuItem";
            this.quảnLýKhoiToolStripMenuItem.Size = new System.Drawing.Size(340, 32);
            this.quảnLýKhoiToolStripMenuItem.Text = "Quản lý CSVC";
            this.quảnLýKhoiToolStripMenuItem.Click += new System.EventHandler(this.quảnLýCSVCToolStripMenuItem_Click);
            // 
            // quảnLýKhenThưởngToolStripMenuItem
            // 
            this.quảnLýKhenThưởngToolStripMenuItem.Name = "quảnLýKhenThưởngToolStripMenuItem";
            this.quảnLýKhenThưởngToolStripMenuItem.Size = new System.Drawing.Size(340, 32);
            this.quảnLýKhenThưởngToolStripMenuItem.Text = "Quản lý Khen thưởng";
            this.quảnLýKhenThưởngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKhenThưởngToolStripMenuItem_Click);
            // 
            // quảnLýNgườiDùngToolStripMenuItem
            // 
            this.quảnLýNgườiDùngToolStripMenuItem.Name = "quảnLýNgườiDùngToolStripMenuItem";
            this.quảnLýNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(340, 32);
            this.quảnLýNgườiDùngToolStripMenuItem.Text = "Quản lý Người dùng";
            this.quảnLýNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNgườiDùngToolStripMenuItem_Click);
            // 
            // quảnLýThờiKhóaBiểuToolStripMenuItem
            // 
            this.quảnLýThờiKhóaBiểuToolStripMenuItem.Name = "quảnLýThờiKhóaBiểuToolStripMenuItem";
            this.quảnLýThờiKhóaBiểuToolStripMenuItem.Size = new System.Drawing.Size(340, 32);
            this.quảnLýThờiKhóaBiểuToolStripMenuItem.Text = "Quản lý Thời Khóa Biểu";
            this.quảnLýThờiKhóaBiểuToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThờiKhóaBiểuToolStripMenuItem_Click);
            // 
            // thốngKêBáoCáoToolStripMenuItem
            // 
            this.thốngKêBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêĐiểmToolStripMenuItem,
            this.báoCáoHọcKỳToolStripMenuItem});
            this.thốngKêBáoCáoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thốngKêBáoCáoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.thốngKêBáoCáoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.thốngKêBáoCáoToolStripMenuItem.Name = "thốngKêBáoCáoToolStripMenuItem";
            this.thốngKêBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(182, 32);
            this.thốngKêBáoCáoToolStripMenuItem.Text = "Thống kê báo cáo";
            // 
            // thốngKêĐiểmToolStripMenuItem
            // 
            this.thốngKêĐiểmToolStripMenuItem.Name = "thốngKêĐiểmToolStripMenuItem";
            this.thốngKêĐiểmToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.thốngKêĐiểmToolStripMenuItem.Text = "Thống kê điểm";
            this.thốngKêĐiểmToolStripMenuItem.Click += new System.EventHandler(this.thốngKêĐiểmToolStripMenuItem_Click);
            // 
            // báoCáoHọcKỳToolStripMenuItem
            // 
            this.báoCáoHọcKỳToolStripMenuItem.Name = "báoCáoHọcKỳToolStripMenuItem";
            this.báoCáoHọcKỳToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.báoCáoHọcKỳToolStripMenuItem.Text = "Báo cáo học kỳ";
            this.báoCáoHọcKỳToolStripMenuItem.Click += new System.EventHandler(this.báoCáoHọcKỳToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trợGiúpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.trợGiúpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(98, 32);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblWelcome,
            this.toolStripStatusLabel1,
            this.lblDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 848);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1333, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblWelcome
            // 
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1313, 16);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // lblDateTime
            // 
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 16);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelSidebar.Controls.Add(this.btnQuanLyTaiChinh);
            this.panelSidebar.Controls.Add(this.btnQuanLyNganh);
            this.panelSidebar.Controls.Add(this.btnQuanLyKhoa);
            this.panelSidebar.Controls.Add(this.btnQuanLyThoiKhoaBieu);
            this.panelSidebar.Controls.Add(this.btnQuanLyNguoiDung);
            this.panelSidebar.Controls.Add(this.btnQuanLyKhenThuong);
            this.panelSidebar.Controls.Add(this.btnQuanLyCSVC);
            this.panelSidebar.Controls.Add(this.btnQuanLyKhoi);
            this.panelSidebar.Controls.Add(this.btnQuanLyLoaiCSVC);
            this.panelSidebar.Controls.Add(this.btnQuanLyPhanCong);
            this.panelSidebar.Controls.Add(this.btnQuanLyDiem);
            this.panelSidebar.Controls.Add(this.btnQuanLyMonHoc);
            this.panelSidebar.Controls.Add(this.btnQuanLyLop);
            this.panelSidebar.Controls.Add(this.btnQuanLyGiaoVien);
            this.panelSidebar.Controls.Add(this.btnQuanLyHocSinh);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 36);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(293, 812);
            this.panelSidebar.TabIndex = 4;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // btnQuanLyNganh
            // 
            this.btnQuanLyNganh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyNganh.FlatAppearance.BorderSize = 0;
            this.btnQuanLyNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNganh.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyNganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNganh.Location = new System.Drawing.Point(0, 715);
            this.btnQuanLyNganh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyNganh.Name = "btnQuanLyNganh";
            this.btnQuanLyNganh.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQuanLyNganh.Size = new System.Drawing.Size(293, 55);
            this.btnQuanLyNganh.TabIndex = 13;
            this.btnQuanLyNganh.Text = "  Quản lý Ngành";
            this.btnQuanLyNganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNganh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyNganh.UseVisualStyleBackColor = true;
            this.btnQuanLyNganh.Click += new System.EventHandler(this.btnQuanLyNganh_Click);
            // 
            // btnQuanLyKhoa
            // 
            this.btnQuanLyKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyKhoa.FlatAppearance.BorderSize = 0;
            this.btnQuanLyKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKhoa.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyKhoa.Location = new System.Drawing.Point(0, 660);
            this.btnQuanLyKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyKhoa.Name = "btnQuanLyKhoa";
            this.btnQuanLyKhoa.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQuanLyKhoa.Size = new System.Drawing.Size(293, 55);
            this.btnQuanLyKhoa.TabIndex = 12;
            this.btnQuanLyKhoa.Text = "  Quản lý Khoa";
            this.btnQuanLyKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyKhoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyKhoa.UseVisualStyleBackColor = true;
            this.btnQuanLyKhoa.Click += new System.EventHandler(this.btnQuanLyKhoa_Click);
            // 
            // btnQuanLyThoiKhoaBieu
            // 
            this.btnQuanLyThoiKhoaBieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyThoiKhoaBieu.FlatAppearance.BorderSize = 0;
            this.btnQuanLyThoiKhoaBieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyThoiKhoaBieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyThoiKhoaBieu.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyThoiKhoaBieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyThoiKhoaBieu.Location = new System.Drawing.Point(0, 605);
            this.btnQuanLyThoiKhoaBieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyThoiKhoaBieu.Name = "btnQuanLyThoiKhoaBieu";
            this.btnQuanLyThoiKhoaBieu.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQuanLyThoiKhoaBieu.Size = new System.Drawing.Size(293, 55);
            this.btnQuanLyThoiKhoaBieu.TabIndex = 11;
            this.btnQuanLyThoiKhoaBieu.Text = "  Quản lý Thời Khóa Biểu";
            this.btnQuanLyThoiKhoaBieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyThoiKhoaBieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyThoiKhoaBieu.UseVisualStyleBackColor = true;
            this.btnQuanLyThoiKhoaBieu.Click += new System.EventHandler(this.btnQuanLyThoiKhoaBieu_Click);
            // 
            // btnQuanLyNguoiDung
            // 
            this.btnQuanLyNguoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnQuanLyNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNguoiDung.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyNguoiDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNguoiDung.Location = new System.Drawing.Point(0, 550);
            this.btnQuanLyNguoiDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyNguoiDung.Name = "btnQuanLyNguoiDung";
            this.btnQuanLyNguoiDung.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQuanLyNguoiDung.Size = new System.Drawing.Size(293, 55);
            this.btnQuanLyNguoiDung.TabIndex = 10;
            this.btnQuanLyNguoiDung.Text = "  Quản lý Người dùng";
            this.btnQuanLyNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNguoiDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyNguoiDung.UseVisualStyleBackColor = true;
            this.btnQuanLyNguoiDung.Click += new System.EventHandler(this.quảnLýNgườiDùngToolStripMenuItem_Click);
            // 
            // btnQuanLyKhenThuong
            // 
            this.btnQuanLyKhenThuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyKhenThuong.FlatAppearance.BorderSize = 0;
            this.btnQuanLyKhenThuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyKhenThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKhenThuong.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyKhenThuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyKhenThuong.Location = new System.Drawing.Point(0, 495);
            this.btnQuanLyKhenThuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyKhenThuong.Name = "btnQuanLyKhenThuong";
            this.btnQuanLyKhenThuong.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQuanLyKhenThuong.Size = new System.Drawing.Size(293, 55);
            this.btnQuanLyKhenThuong.TabIndex = 9;
            this.btnQuanLyKhenThuong.Text = "  Quản lý Khen thưởng";
            this.btnQuanLyKhenThuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyKhenThuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyKhenThuong.UseVisualStyleBackColor = true;
            this.btnQuanLyKhenThuong.Click += new System.EventHandler(this.quảnLýKhenThưởngToolStripMenuItem_Click);
            // 
            // btnQuanLyCSVC
            // 
            this.btnQuanLyCSVC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyCSVC.FlatAppearance.BorderSize = 0;
            this.btnQuanLyCSVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyCSVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyCSVC.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyCSVC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyCSVC.Location = new System.Drawing.Point(0, 440);
            this.btnQuanLyCSVC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyCSVC.Name = "btnQuanLyCSVC";
            this.btnQuanLyCSVC.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQuanLyCSVC.Size = new System.Drawing.Size(293, 55);
            this.btnQuanLyCSVC.TabIndex = 8;
            this.btnQuanLyCSVC.Text = "  Quản lý CSVC";
            this.btnQuanLyCSVC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyCSVC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyCSVC.UseVisualStyleBackColor = true;
            this.btnQuanLyCSVC.Click += new System.EventHandler(this.quảnLýCSVCToolStripMenuItem_Click);
            // 
            // btnQuanLyKhoi
            // 
            this.btnQuanLyKhoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyKhoi.FlatAppearance.BorderSize = 0;
            this.btnQuanLyKhoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKhoi.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyKhoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyKhoi.Location = new System.Drawing.Point(0, 385);
            this.btnQuanLyKhoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyKhoi.Name = "btnQuanLyKhoi";
            this.btnQuanLyKhoi.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQuanLyKhoi.Size = new System.Drawing.Size(293, 55);
            this.btnQuanLyKhoi.TabIndex = 7;
            this.btnQuanLyKhoi.Text = "  Quản lý Khối";
            this.btnQuanLyKhoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyKhoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyKhoi.UseVisualStyleBackColor = true;
            this.btnQuanLyKhoi.Click += new System.EventHandler(this.quảnLýCSVCToolStripMenuItem_Click_1);
            // 
            // btnQuanLyLoaiCSVC
            // 
            this.btnQuanLyLoaiCSVC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyLoaiCSVC.FlatAppearance.BorderSize = 0;
            this.btnQuanLyLoaiCSVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyLoaiCSVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyLoaiCSVC.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyLoaiCSVC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyLoaiCSVC.Location = new System.Drawing.Point(0, 330);
            this.btnQuanLyLoaiCSVC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyLoaiCSVC.Name = "btnQuanLyLoaiCSVC";
            this.btnQuanLyLoaiCSVC.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQuanLyLoaiCSVC.Size = new System.Drawing.Size(293, 55);
            this.btnQuanLyLoaiCSVC.TabIndex = 6;
            this.btnQuanLyLoaiCSVC.Text = "  Quản lý Loại CSVC";
            this.btnQuanLyLoaiCSVC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyLoaiCSVC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyLoaiCSVC.UseVisualStyleBackColor = true;
            this.btnQuanLyLoaiCSVC.Click += new System.EventHandler(this.quảnLýLoạiCSVCToolStripMenuItem_Click);
            // 
            // btnQuanLyPhanCong
            // 
            this.btnQuanLyPhanCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyPhanCong.FlatAppearance.BorderSize = 0;
            this.btnQuanLyPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyPhanCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyPhanCong.Location = new System.Drawing.Point(0, 275);
            this.btnQuanLyPhanCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyPhanCong.Name = "btnQuanLyPhanCong";
            this.btnQuanLyPhanCong.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQuanLyPhanCong.Size = new System.Drawing.Size(293, 55);
            this.btnQuanLyPhanCong.TabIndex = 5;
            this.btnQuanLyPhanCong.Text = "  Quản lý Phân công";
            this.btnQuanLyPhanCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyPhanCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyPhanCong.UseVisualStyleBackColor = true;
            this.btnQuanLyPhanCong.Click += new System.EventHandler(this.quảnLýPhânCôngToolStripMenuItem_Click);
            // 
            // btnQuanLyDiem
            // 
            this.btnQuanLyDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyDiem.FlatAppearance.BorderSize = 0;
            this.btnQuanLyDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDiem.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyDiem.Location = new System.Drawing.Point(0, 220);
            this.btnQuanLyDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyDiem.Name = "btnQuanLyDiem";
            this.btnQuanLyDiem.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQuanLyDiem.Size = new System.Drawing.Size(293, 55);
            this.btnQuanLyDiem.TabIndex = 4;
            this.btnQuanLyDiem.Text = "  Quản lý Kết quả học tập";
            this.btnQuanLyDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyDiem.UseVisualStyleBackColor = true;
            this.btnQuanLyDiem.Click += new System.EventHandler(this.quảnLýĐiểmToolStripMenuItem_Click);
            // 
            // btnQuanLyMonHoc
            // 
            this.btnQuanLyMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyMonHoc.FlatAppearance.BorderSize = 0;
            this.btnQuanLyMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyMonHoc.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyMonHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyMonHoc.Location = new System.Drawing.Point(0, 165);
            this.btnQuanLyMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyMonHoc.Name = "btnQuanLyMonHoc";
            this.btnQuanLyMonHoc.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQuanLyMonHoc.Size = new System.Drawing.Size(293, 55);
            this.btnQuanLyMonHoc.TabIndex = 3;
            this.btnQuanLyMonHoc.Text = "  Quản lý Môn học";
            this.btnQuanLyMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyMonHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyMonHoc.UseVisualStyleBackColor = true;
            this.btnQuanLyMonHoc.Click += new System.EventHandler(this.quảnLýMônHọcToolStripMenuItem_Click);
            // 
            // btnQuanLyLop
            // 
            this.btnQuanLyLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyLop.FlatAppearance.BorderSize = 0;
            this.btnQuanLyLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyLop.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyLop.Location = new System.Drawing.Point(0, 110);
            this.btnQuanLyLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyLop.Name = "btnQuanLyLop";
            this.btnQuanLyLop.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQuanLyLop.Size = new System.Drawing.Size(293, 55);
            this.btnQuanLyLop.TabIndex = 2;
            this.btnQuanLyLop.Text = "  Quản lý Lớp";
            this.btnQuanLyLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyLop.UseVisualStyleBackColor = true;
            this.btnQuanLyLop.Click += new System.EventHandler(this.quảnLýLớpToolStripMenuItem_Click);
            // 
            // btnQuanLyGiaoVien
            // 
            this.btnQuanLyGiaoVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyGiaoVien.FlatAppearance.BorderSize = 0;
            this.btnQuanLyGiaoVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyGiaoVien.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyGiaoVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyGiaoVien.Location = new System.Drawing.Point(0, 55);
            this.btnQuanLyGiaoVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyGiaoVien.Name = "btnQuanLyGiaoVien";
            this.btnQuanLyGiaoVien.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQuanLyGiaoVien.Size = new System.Drawing.Size(293, 55);
            this.btnQuanLyGiaoVien.TabIndex = 1;
            this.btnQuanLyGiaoVien.Text = "  Quản lý Giáo viên";
            this.btnQuanLyGiaoVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyGiaoVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyGiaoVien.UseVisualStyleBackColor = true;
            this.btnQuanLyGiaoVien.Click += new System.EventHandler(this.quảnLýGiáoViênToolStripMenuItem_Click);
            // 
            // btnQuanLyHocSinh
            // 
            this.btnQuanLyHocSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyHocSinh.FlatAppearance.BorderSize = 0;
            this.btnQuanLyHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyHocSinh.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyHocSinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyHocSinh.Location = new System.Drawing.Point(0, 0);
            this.btnQuanLyHocSinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyHocSinh.Name = "btnQuanLyHocSinh";
            this.btnQuanLyHocSinh.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQuanLyHocSinh.Size = new System.Drawing.Size(293, 55);
            this.btnQuanLyHocSinh.TabIndex = 0;
            this.btnQuanLyHocSinh.Text = "  Quản lý Thông tin Sinh Viên";
            this.btnQuanLyHocSinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyHocSinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyHocSinh.UseVisualStyleBackColor = true;
            this.btnQuanLyHocSinh.Click += new System.EventHandler(this.quảnLýHọcSinhToolStripMenuItem_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.lblAppName);
            this.panelHeader.Controls.Add(this.pictureBoxLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(293, 36);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1040, 123);
            this.panelHeader.TabIndex = 5;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(160, 43);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(628, 39);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "PHẦN MỀM QUẢN LÝ TRƯỜNG HỌC";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(27, 18);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(107, 86);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnQuanLyTaiChinh
            // 
            this.btnQuanLyTaiChinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyTaiChinh.FlatAppearance.BorderSize = 0;
            this.btnQuanLyTaiChinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyTaiChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTaiChinh.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyTaiChinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyTaiChinh.Location = new System.Drawing.Point(0, 770);
            this.btnQuanLyTaiChinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyTaiChinh.Name = "btnQuanLyTaiChinh";
            this.btnQuanLyTaiChinh.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnQuanLyTaiChinh.Size = new System.Drawing.Size(293, 55);
            this.btnQuanLyTaiChinh.TabIndex = 14;
            this.btnQuanLyTaiChinh.Text = "  Quản lý Tài Chính";
            this.btnQuanLyTaiChinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyTaiChinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyTaiChinh.UseVisualStyleBackColor = true;
            this.btnQuanLyTaiChinh.Click += new System.EventHandler(this.btnQuanLyTaiChinh_Click);
            // 
            // quảnLýTàiChínhToolStripMenuItem
            // 
            this.quảnLýTàiChínhToolStripMenuItem.Name = "quảnLýTàiChínhToolStripMenuItem";
            this.quảnLýTàiChínhToolStripMenuItem.Size = new System.Drawing.Size(340, 32);
            this.quảnLýTàiChínhToolStripMenuItem.Text = "Quản lý Tài Chính";
            this.quảnLýTàiChínhToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiChínhToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 870);
            this.ControlBox = false;
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý trường học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýGiáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhânCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhenThưởngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoHọcKỳToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblWelcome;
        private System.Windows.Forms.ToolStripStatusLabel lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCSVCToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem quảnLýLoạiCSVCToolStripMenuItem;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnQuanLyHocSinh;
        private System.Windows.Forms.Button btnQuanLyGiaoVien;
        private System.Windows.Forms.Button btnQuanLyLop;
        private System.Windows.Forms.Button btnQuanLyMonHoc;
        private System.Windows.Forms.Button btnQuanLyDiem;
        private System.Windows.Forms.Button btnQuanLyPhanCong;
        private System.Windows.Forms.Button btnQuanLyLoaiCSVC;
        private System.Windows.Forms.Button btnQuanLyKhoi;
        private System.Windows.Forms.Button btnQuanLyCSVC;
        private System.Windows.Forms.Button btnQuanLyKhenThuong;
        private System.Windows.Forms.Button btnQuanLyNguoiDung;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem quảnLýThờiKhóaBiểuToolStripMenuItem;
        private Button btnQuanLyThoiKhoaBieu;
        private Button btnQuanLyNganh;
        private Button btnQuanLyKhoa;
        private ToolStripMenuItem quảnLýTàiChínhToolStripMenuItem;
        private Button btnQuanLyTaiChinh;
    }
}