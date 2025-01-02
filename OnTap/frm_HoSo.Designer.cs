namespace OnTap
{
    partial class frm_HoSo
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
            this.lb_TTCN = new System.Windows.Forms.Label();
            this.lb_TenGV = new System.Windows.Forms.Label();
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.cb_TenGV = new System.Windows.Forms.ComboBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.date_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Dong = new System.Windows.Forms.Button();
            this.dt_KhachHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dt_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TTCN
            // 
            this.lb_TTCN.AutoSize = true;
            this.lb_TTCN.Location = new System.Drawing.Point(302, 40);
            this.lb_TTCN.Name = "lb_TTCN";
            this.lb_TTCN.Size = new System.Drawing.Size(94, 13);
            this.lb_TTCN.TabIndex = 0;
            this.lb_TTCN.Text = "Thông tin cá nhân";
            this.lb_TTCN.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_TenGV
            // 
            this.lb_TenGV.AutoSize = true;
            this.lb_TenGV.Location = new System.Drawing.Point(106, 84);
            this.lb_TenGV.Name = "lb_TenGV";
            this.lb_TenGV.Size = new System.Drawing.Size(75, 13);
            this.lb_TenGV.TabIndex = 1;
            this.lb_TenGV.Text = "Tên Giáo Viên";
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.AutoSize = true;
            this.lb_MaKH.Location = new System.Drawing.Point(106, 135);
            this.lb_MaKH.Name = "lb_MaKH";
            this.lb_MaKH.Size = new System.Drawing.Size(85, 13);
            this.lb_MaKH.TabIndex = 2;
            this.lb_MaKH.Text = "Mã Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(459, 135);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(40, 13);
            this.lb_DiaChi.TabIndex = 4;
            this.lb_DiaChi.Text = "Địa chỉ";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Location = new System.Drawing.Point(106, 197);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(43, 13);
            this.lb_HoTen.TabIndex = 5;
            this.lb_HoTen.Text = "Họ Tên";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(202, 128);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(175, 20);
            this.txt_MaKH.TabIndex = 6;
            // 
            // cb_TenGV
            // 
            this.cb_TenGV.FormattingEnabled = true;
            this.cb_TenGV.Location = new System.Drawing.Point(202, 84);
            this.cb_TenGV.Name = "cb_TenGV";
            this.cb_TenGV.Size = new System.Drawing.Size(175, 21);
            this.cb_TenGV.TabIndex = 7;
            this.cb_TenGV.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(202, 197);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(467, 20);
            this.txt_HoTen.TabIndex = 8;
            // 
            // date_NgaySinh
            // 
            this.date_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.date_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgaySinh.Location = new System.Drawing.Point(533, 81);
            this.date_NgaySinh.Name = "date_NgaySinh";
            this.date_NgaySinh.Size = new System.Drawing.Size(200, 20);
            this.date_NgaySinh.TabIndex = 9;
            this.date_NgaySinh.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(533, 128);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(208, 61);
            this.txt_DiaChi.TabIndex = 10;
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(109, 258);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(48, 25);
            this.bt_Them.TabIndex = 11;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(258, 260);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(75, 23);
            this.bt_Sua.TabIndex = 12;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(434, 260);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(56, 25);
            this.bt_Xoa.TabIndex = 13;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // bt_Dong
            // 
            this.bt_Dong.Location = new System.Drawing.Point(579, 262);
            this.bt_Dong.Name = "bt_Dong";
            this.bt_Dong.Size = new System.Drawing.Size(75, 23);
            this.bt_Dong.TabIndex = 14;
            this.bt_Dong.Text = "Đóng";
            this.bt_Dong.UseVisualStyleBackColor = true;
            this.bt_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // dt_KhachHang
            // 
            this.dt_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_KhachHang.Location = new System.Drawing.Point(92, 305);
            this.dt_KhachHang.Name = "dt_KhachHang";
            this.dt_KhachHang.Size = new System.Drawing.Size(640, 119);
            this.dt_KhachHang.TabIndex = 11;
            this.dt_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_KhachHang_CellClick);
            // 
            // frm_HoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dt_KhachHang);
            this.Controls.Add(this.bt_Dong);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.date_NgaySinh);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.cb_TenGV);
            this.Controls.Add(this.txt_MaKH);
            this.Controls.Add(this.lb_HoTen);
            this.Controls.Add(this.lb_DiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_MaKH);
            this.Controls.Add(this.lb_TenGV);
            this.Controls.Add(this.lb_TTCN);
            this.Name = "frm_HoSo";
            this.Text = "frm_HoSo";
            this.Load += new System.EventHandler(this.frm_HoSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TTCN;
        private System.Windows.Forms.Label lb_TenGV;
        private System.Windows.Forms.Label lb_MaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.ComboBox cb_TenGV;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.DateTimePicker date_NgaySinh;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Dong;
        private System.Windows.Forms.DataGridView dt_KhachHang;
    }
}