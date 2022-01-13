
namespace NetLibraryAdmin
{
    partial class administrator
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
            this.status_bar = new System.Windows.Forms.StatusStrip();
            this.status_id = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_nama = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_level = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_content = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_level = new System.Windows.Forms.Label();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_telp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_pengunjung = new System.Windows.Forms.Button();
            this.btn_pinjam = new System.Windows.Forms.Button();
            this.keluar = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.btn_petugas = new System.Windows.Forms.Button();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.btn_member = new System.Windows.Forms.Button();
            this.btn_rak = new System.Windows.Forms.Button();
            this.btn_buku = new System.Windows.Forms.Button();
            this.btn_beranda = new System.Windows.Forms.Button();
            this.status_bar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_bar
            // 
            this.status_bar.BackColor = System.Drawing.Color.White;
            this.status_bar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_bar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_id,
            this.status_nama,
            this.status_level});
            this.status_bar.Location = new System.Drawing.Point(0, 665);
            this.status_bar.Name = "status_bar";
            this.status_bar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.status_bar.Size = new System.Drawing.Size(1800, 35);
            this.status_bar.TabIndex = 6;
            this.status_bar.Text = "status_bar";
            // 
            // status_id
            // 
            this.status_id.Name = "status_id";
            this.status_id.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.status_id.Size = new System.Drawing.Size(63, 29);
            this.status_id.Text = "987654";
            // 
            // status_nama
            // 
            this.status_nama.Name = "status_nama";
            this.status_nama.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.status_nama.Size = new System.Drawing.Size(100, 29);
            this.status_nama.Text = "status_nama";
            // 
            // status_level
            // 
            this.status_level.Name = "status_level";
            this.status_level.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.status_level.Size = new System.Drawing.Size(91, 29);
            this.status_level.Text = "status_level";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn_pengunjung);
            this.panel1.Controls.Add(this.btn_pinjam);
            this.panel1.Controls.Add(this.keluar);
            this.panel1.Controls.Add(this.info);
            this.panel1.Controls.Add(this.btn_petugas);
            this.panel1.Controls.Add(this.btn_kembali);
            this.panel1.Controls.Add(this.btn_member);
            this.panel1.Controls.Add(this.btn_rak);
            this.panel1.Controls.Add(this.btn_buku);
            this.panel1.Controls.Add(this.btn_beranda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 665);
            this.panel1.TabIndex = 9;
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_content.Location = new System.Drawing.Point(283, 0);
            this.panel_content.Margin = new System.Windows.Forms.Padding(4);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(1168, 665);
            this.panel_content.TabIndex = 10;
            this.panel_content.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_content_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(84, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(249, 73);
            this.panel5.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(19, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Account";
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_level.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_level.Location = new System.Drawing.Point(116, 213);
            this.lbl_level.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(99, 23);
            this.lbl_level.TabIndex = 17;
            this.lbl_level.Text = "Administrator";
            // 
            // txt_alamat
            // 
            this.txt_alamat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_alamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_alamat.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alamat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_alamat.Location = new System.Drawing.Point(25, 282);
            this.txt_alamat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_alamat.Multiline = true;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.ReadOnly = true;
            this.txt_alamat.Size = new System.Drawing.Size(285, 101);
            this.txt_alamat.TabIndex = 15;
            this.txt_alamat.Text = "ini alamat cuman memang alamat";
            this.txt_alamat.TextChanged += new System.EventHandler(this.txt_alamat_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(21, 254);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Alamat :";
            // 
            // lbl_telp
            // 
            this.lbl_telp.AutoSize = true;
            this.lbl_telp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_telp.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_telp.Location = new System.Drawing.Point(149, 175);
            this.lbl_telp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telp.Name = "lbl_telp";
            this.lbl_telp.Size = new System.Drawing.Size(118, 23);
            this.lbl_telp.TabIndex = 13;
            this.lbl_telp.Text = "082238447443";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(23, 175);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "No. Telepon :";
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nama.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_nama.Location = new System.Drawing.Point(97, 134);
            this.lbl_nama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(77, 23);
            this.lbl_nama.TabIndex = 11;
            this.lbl_nama.Text = "Budi Dool";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(23, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nama :";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_id.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_id.Location = new System.Drawing.Point(133, 96);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(37, 23);
            this.lbl_id.TabIndex = 9;
            this.lbl_id.Text = "001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(23, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Pegawai :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btn_logout);
            this.panel4.Controls.Add(this.btn_profile);
            this.panel4.Controls.Add(this.lbl_level);
            this.panel4.Controls.Add(this.txt_alamat);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lbl_telp);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lbl_nama);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lbl_id);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1467, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 665);
            this.panel4.TabIndex = 11;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(200, 453);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "LogOut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(57, 453);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ubah Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(21, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Jabatan :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BackgroundImage = global::NetLibraryAdmin.Properties.Resources.freelance1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(1467, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 73);
            this.panel2.TabIndex = 21;
            // 
            // btn_logout
            // 
            this.btn_logout.BackgroundImage = global::NetLibraryAdmin.Properties.Resources.logout;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_logout.Location = new System.Drawing.Point(183, 391);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(100, 58);
            this.btn_logout.TabIndex = 19;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click_1);
            // 
            // btn_profile
            // 
            this.btn_profile.BackgroundImage = global::NetLibraryAdmin.Properties.Resources.user;
            this.btn_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_profile.Location = new System.Drawing.Point(59, 391);
            this.btn_profile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(100, 58);
            this.btn_profile.TabIndex = 18;
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click_1);
            // 
            // btn_pengunjung
            // 
            this.btn_pengunjung.BackColor = System.Drawing.Color.Transparent;
            this.btn_pengunjung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pengunjung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pengunjung.FlatAppearance.BorderSize = 0;
            this.btn_pengunjung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_pengunjung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_pengunjung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pengunjung.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pengunjung.Image = global::NetLibraryAdmin.Properties.Resources.Asset_1;
            this.btn_pengunjung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pengunjung.Location = new System.Drawing.Point(11, 537);
            this.btn_pengunjung.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pengunjung.Name = "btn_pengunjung";
            this.btn_pengunjung.Size = new System.Drawing.Size(227, 59);
            this.btn_pengunjung.TabIndex = 17;
            this.btn_pengunjung.Text = "Statisik";
            this.btn_pengunjung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pengunjung.UseVisualStyleBackColor = false;
            this.btn_pengunjung.Click += new System.EventHandler(this.btn_pengunjung_Click);
            // 
            // btn_pinjam
            // 
            this.btn_pinjam.BackColor = System.Drawing.Color.Transparent;
            this.btn_pinjam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pinjam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pinjam.FlatAppearance.BorderSize = 0;
            this.btn_pinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pinjam.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pinjam.Image = global::NetLibraryAdmin.Properties.Resources.Asset_5;
            this.btn_pinjam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pinjam.Location = new System.Drawing.Point(13, 235);
            this.btn_pinjam.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pinjam.Name = "btn_pinjam";
            this.btn_pinjam.Size = new System.Drawing.Size(227, 61);
            this.btn_pinjam.TabIndex = 14;
            this.btn_pinjam.Text = "Peminjaman";
            this.btn_pinjam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pinjam.UseVisualStyleBackColor = false;
            this.btn_pinjam.Click += new System.EventHandler(this.btn_pinjam_Click);
            // 
            // keluar
            // 
            this.keluar.BackColor = System.Drawing.Color.Transparent;
            this.keluar.BackgroundImage = global::NetLibraryAdmin.Properties.Resources.exit__1_;
            this.keluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keluar.Location = new System.Drawing.Point(225, 603);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(51, 59);
            this.keluar.TabIndex = 19;
            this.keluar.UseVisualStyleBackColor = false;
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.BackgroundImage = global::NetLibraryAdmin.Properties.Resources.about;
            this.info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.Location = new System.Drawing.Point(72, 603);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(57, 56);
            this.info.TabIndex = 18;
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_petugas
            // 
            this.btn_petugas.BackColor = System.Drawing.Color.Transparent;
            this.btn_petugas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_petugas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_petugas.FlatAppearance.BorderSize = 0;
            this.btn_petugas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_petugas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_petugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_petugas.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_petugas.Image = global::NetLibraryAdmin.Properties.Resources.Asset_2;
            this.btn_petugas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_petugas.Location = new System.Drawing.Point(15, 457);
            this.btn_petugas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_petugas.Name = "btn_petugas";
            this.btn_petugas.Size = new System.Drawing.Size(227, 59);
            this.btn_petugas.TabIndex = 16;
            this.btn_petugas.Text = "Pegawai";
            this.btn_petugas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_petugas.UseVisualStyleBackColor = false;
            this.btn_petugas.Click += new System.EventHandler(this.btn_petugas_Click);
            // 
            // btn_kembali
            // 
            this.btn_kembali.BackColor = System.Drawing.Color.Transparent;
            this.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kembali.FlatAppearance.BorderSize = 0;
            this.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kembali.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kembali.Image = global::NetLibraryAdmin.Properties.Resources.Asset_4;
            this.btn_kembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kembali.Location = new System.Drawing.Point(13, 314);
            this.btn_kembali.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(225, 57);
            this.btn_kembali.TabIndex = 15;
            this.btn_kembali.Text = "Pengembalian";
            this.btn_kembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kembali.UseVisualStyleBackColor = false;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // btn_member
            // 
            this.btn_member.BackColor = System.Drawing.Color.Transparent;
            this.btn_member.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_member.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_member.FlatAppearance.BorderSize = 0;
            this.btn_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_member.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_member.Image = global::NetLibraryAdmin.Properties.Resources.Asset_3;
            this.btn_member.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_member.Location = new System.Drawing.Point(13, 379);
            this.btn_member.Margin = new System.Windows.Forms.Padding(4);
            this.btn_member.Name = "btn_member";
            this.btn_member.Size = new System.Drawing.Size(225, 70);
            this.btn_member.TabIndex = 13;
            this.btn_member.Text = "Anggota";
            this.btn_member.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_member.UseVisualStyleBackColor = false;
            this.btn_member.Click += new System.EventHandler(this.btn_member_Click);
            // 
            // btn_rak
            // 
            this.btn_rak.BackColor = System.Drawing.Color.Transparent;
            this.btn_rak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rak.FlatAppearance.BorderSize = 0;
            this.btn_rak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rak.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rak.Image = global::NetLibraryAdmin.Properties.Resources.Asset_6;
            this.btn_rak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rak.Location = new System.Drawing.Point(13, 158);
            this.btn_rak.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rak.Name = "btn_rak";
            this.btn_rak.Size = new System.Drawing.Size(229, 56);
            this.btn_rak.TabIndex = 10;
            this.btn_rak.Text = "Ketagori Buku";
            this.btn_rak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_rak.UseVisualStyleBackColor = false;
            this.btn_rak.Click += new System.EventHandler(this.btn_rak_Click);
            // 
            // btn_buku
            // 
            this.btn_buku.BackColor = System.Drawing.Color.Transparent;
            this.btn_buku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_buku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buku.FlatAppearance.BorderSize = 0;
            this.btn_buku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buku.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buku.Image = global::NetLibraryAdmin.Properties.Resources.Asset_7;
            this.btn_buku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buku.Location = new System.Drawing.Point(15, 82);
            this.btn_buku.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buku.Name = "btn_buku";
            this.btn_buku.Size = new System.Drawing.Size(227, 62);
            this.btn_buku.TabIndex = 9;
            this.btn_buku.Text = "Buku";
            this.btn_buku.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buku.UseVisualStyleBackColor = false;
            this.btn_buku.Click += new System.EventHandler(this.btn_buku_Click);
            // 
            // btn_beranda
            // 
            this.btn_beranda.BackColor = System.Drawing.Color.Transparent;
            this.btn_beranda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_beranda.FlatAppearance.BorderSize = 0;
            this.btn_beranda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_beranda.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.btn_beranda.Image = global::NetLibraryAdmin.Properties.Resources.Asset_81;
            this.btn_beranda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_beranda.Location = new System.Drawing.Point(13, 15);
            this.btn_beranda.Margin = new System.Windows.Forms.Padding(4);
            this.btn_beranda.Name = "btn_beranda";
            this.btn_beranda.Size = new System.Drawing.Size(229, 59);
            this.btn_beranda.TabIndex = 7;
            this.btn_beranda.Text = "Home";
            this.btn_beranda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_beranda.UseVisualStyleBackColor = false;
            this.btn_beranda.Click += new System.EventHandler(this.btn_beranda_Click);
            // 
            // administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1800, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.status_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "administrator";
            this.Load += new System.EventHandler(this.administrator_Load);
            this.status_bar.ResumeLayout(false);
            this.status_bar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.StatusStrip status_bar;
        public System.Windows.Forms.ToolStripStatusLabel status_id;
        public System.Windows.Forms.ToolStripStatusLabel status_nama;
        public System.Windows.Forms.ToolStripStatusLabel status_level;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_beranda;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.Button btn_buku;
        private System.Windows.Forms.Button btn_rak;
        private System.Windows.Forms.Button btn_member;
        private System.Windows.Forms.Button btn_pinjam;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.Button btn_pengunjung;
        private System.Windows.Forms.Button btn_petugas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_telp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button keluar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}