
namespace NetLibraryAdmin
{
    partial class pengembalian_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_pinjam = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.check_denda = new System.Windows.Forms.CheckBox();
            this.dgv_buku_pinjam = new System.Windows.Forms.DataGridView();
            this.txt_denda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_telp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_idm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tgl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_idp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_cari = new System.Windows.Forms.Button();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.btn_cetak_kembali = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_pinjam.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buku_pinjam)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_header.Location = new System.Drawing.Point(16, 23);
            this.label_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(228, 31);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Form Pengembalian";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label_header);
            this.panel1.Location = new System.Drawing.Point(140, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 86);
            this.panel1.TabIndex = 18;
            // 
            // panel_pinjam
            // 
            this.panel_pinjam.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_pinjam.Controls.Add(this.panel4);
            this.panel_pinjam.Controls.Add(this.panel3);
            this.panel_pinjam.Location = new System.Drawing.Point(0, 208);
            this.panel_pinjam.Margin = new System.Windows.Forms.Padding(4);
            this.panel_pinjam.Name = "panel_pinjam";
            this.panel_pinjam.Size = new System.Drawing.Size(1009, 458);
            this.panel_pinjam.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.check_denda);
            this.panel4.Controls.Add(this.dgv_buku_pinjam);
            this.panel4.Controls.Add(this.btn_kembali);
            this.panel4.Controls.Add(this.txt_denda);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(13, 26);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(601, 404);
            this.panel4.TabIndex = 1;
            // 
            // check_denda
            // 
            this.check_denda.AutoSize = true;
            this.check_denda.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_denda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.check_denda.Location = new System.Drawing.Point(224, 350);
            this.check_denda.Margin = new System.Windows.Forms.Padding(4);
            this.check_denda.Name = "check_denda";
            this.check_denda.Size = new System.Drawing.Size(108, 26);
            this.check_denda.TabIndex = 45;
            this.check_denda.Text = "Buku Hilang";
            this.check_denda.UseVisualStyleBackColor = true;
            this.check_denda.CheckedChanged += new System.EventHandler(this.check_denda_CheckedChanged);
            // 
            // dgv_buku_pinjam
            // 
            this.dgv_buku_pinjam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_buku_pinjam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_buku_pinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_buku_pinjam.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_buku_pinjam.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_buku_pinjam.Location = new System.Drawing.Point(20, 21);
            this.dgv_buku_pinjam.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_buku_pinjam.MultiSelect = false;
            this.dgv_buku_pinjam.Name = "dgv_buku_pinjam";
            this.dgv_buku_pinjam.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_buku_pinjam.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_buku_pinjam.RowHeadersWidth = 40;
            this.dgv_buku_pinjam.RowTemplate.Height = 28;
            this.dgv_buku_pinjam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_buku_pinjam.Size = new System.Drawing.Size(557, 289);
            this.dgv_buku_pinjam.TabIndex = 44;
            // 
            // txt_denda
            // 
            this.txt_denda.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_denda.Location = new System.Drawing.Point(81, 346);
            this.txt_denda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_denda.Name = "txt_denda";
            this.txt_denda.ReadOnly = true;
            this.txt_denda.Size = new System.Drawing.Size(131, 29);
            this.txt_denda.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(16, 351);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "Denda";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btn_cetak_kembali);
            this.panel3.Controls.Add(this.txt_alamat);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lbl_telp);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lbl_nama);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lbl_idm);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(631, 26);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 404);
            this.panel3.TabIndex = 0;
            // 
            // txt_alamat
            // 
            this.txt_alamat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_alamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_alamat.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alamat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_alamat.Location = new System.Drawing.Point(20, 177);
            this.txt_alamat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_alamat.Multiline = true;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.ReadOnly = true;
            this.txt_alamat.Size = new System.Drawing.Size(285, 101);
            this.txt_alamat.TabIndex = 7;
            this.txt_alamat.Text = "Jalan tluki 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(16, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "Alamat :";
            // 
            // lbl_telp
            // 
            this.lbl_telp.AutoSize = true;
            this.lbl_telp.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_telp.Location = new System.Drawing.Point(143, 106);
            this.lbl_telp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telp.Name = "lbl_telp";
            this.lbl_telp.Size = new System.Drawing.Size(118, 23);
            this.lbl_telp.TabIndex = 5;
            this.lbl_telp.Text = "081283745666";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(16, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "No. Telepon :";
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nama.Location = new System.Drawing.Point(91, 65);
            this.lbl_nama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(104, 23);
            this.lbl_nama.TabIndex = 3;
            this.lbl_nama.Text = "Yaumil Aksah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(16, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nama :";
            // 
            // lbl_idm
            // 
            this.lbl_idm.AutoSize = true;
            this.lbl_idm.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_idm.Location = new System.Drawing.Point(127, 27);
            this.lbl_idm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idm.Name = "lbl_idm";
            this.lbl_idm.Size = new System.Drawing.Size(28, 23);
            this.lbl_idm.TabIndex = 1;
            this.lbl_idm.Text = "01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Member :";
            // 
            // txt_idm
            // 
            this.txt_idm.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idm.Location = new System.Drawing.Point(140, 152);
            this.txt_idm.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idm.Name = "txt_idm";
            this.txt_idm.ReadOnly = true;
            this.txt_idm.Size = new System.Drawing.Size(223, 29);
            this.txt_idm.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 46;
            this.label3.Text = "ID Member";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(140, 99);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(223, 29);
            this.txt_id.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 44;
            this.label2.Text = "ID Pinjam";
            // 
            // txt_tgl
            // 
            this.txt_tgl.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tgl.Location = new System.Drawing.Point(522, 150);
            this.txt_tgl.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tgl.Name = "txt_tgl";
            this.txt_tgl.ReadOnly = true;
            this.txt_tgl.Size = new System.Drawing.Size(213, 29);
            this.txt_tgl.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tanggal Pinjam";
            // 
            // txt_idp
            // 
            this.txt_idp.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idp.Location = new System.Drawing.Point(522, 100);
            this.txt_idp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idp.Name = "txt_idp";
            this.txt_idp.ReadOnly = true;
            this.txt_idp.Size = new System.Drawing.Size(213, 29);
            this.txt_idp.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 48;
            this.label6.Text = "ID Pegawai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(143, 361);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Cetak";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(447, 371);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 23);
            this.label7.TabIndex = 43;
            this.label7.Text = "Kembalikan";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.BackgroundImage = global::NetLibraryAdmin.Properties.Resources.back1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 86);
            this.panel2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(16, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 31);
            this.label9.TabIndex = 0;
            // 
            // btn_cari
            // 
            this.btn_cari.BackColor = System.Drawing.Color.Transparent;
            this.btn_cari.BackgroundImage = global::NetLibraryAdmin.Properties.Resources.search;
            this.btn_cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cari.FlatAppearance.BorderSize = 0;
            this.btn_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cari.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cari.Location = new System.Drawing.Point(804, 99);
            this.btn_cari.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btn_cari.Size = new System.Drawing.Size(156, 82);
            this.btn_cari.TabIndex = 52;
            this.btn_cari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cari.UseVisualStyleBackColor = false;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // btn_kembali
            // 
            this.btn_kembali.BackColor = System.Drawing.Color.Transparent;
            this.btn_kembali.BackgroundImage = global::NetLibraryAdmin.Properties.Resources.back;
            this.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kembali.FlatAppearance.BorderSize = 0;
            this.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kembali.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kembali.Location = new System.Drawing.Point(412, 324);
            this.btn_kembali.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btn_kembali.Size = new System.Drawing.Size(165, 52);
            this.btn_kembali.TabIndex = 42;
            this.btn_kembali.UseVisualStyleBackColor = false;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // btn_cetak_kembali
            // 
            this.btn_cetak_kembali.BackColor = System.Drawing.Color.Transparent;
            this.btn_cetak_kembali.BackgroundImage = global::NetLibraryAdmin.Properties.Resources.printer;
            this.btn_cetak_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cetak_kembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cetak_kembali.FlatAppearance.BorderSize = 0;
            this.btn_cetak_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cetak_kembali.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cetak_kembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cetak_kembali.Location = new System.Drawing.Point(131, 290);
            this.btn_cetak_kembali.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cetak_kembali.Name = "btn_cetak_kembali";
            this.btn_cetak_kembali.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btn_cetak_kembali.Size = new System.Drawing.Size(78, 67);
            this.btn_cetak_kembali.TabIndex = 41;
            this.btn_cetak_kembali.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cetak_kembali.UseVisualStyleBackColor = false;
            this.btn_cetak_kembali.Click += new System.EventHandler(this.btn_cetak_kembali_Click);
            // 
            // pengembalian_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1003, 666);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_cari);
            this.Controls.Add(this.txt_tgl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_idp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_idm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_pinjam);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "pengembalian_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pengembalian_form";
            this.Load += new System.EventHandler(this.pengembalian_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_pinjam.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buku_pinjam)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel_pinjam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox check_denda;
        public System.Windows.Forms.DataGridView dgv_buku_pinjam;
        public System.Windows.Forms.Button btn_kembali;
        public System.Windows.Forms.TextBox txt_denda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btn_cetak_kembali;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_telp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_idm;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_idm;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_tgl;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_idp;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label9;
    }
}