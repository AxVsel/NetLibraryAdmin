
namespace NetLibraryClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_info = new System.Windows.Forms.Label();
            this.dgv_hasil_cari = new System.Windows.Forms.DataGridView();
            this.cmb_kategori = new System.Windows.Forms.ComboBox();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_id_member = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rd_n = new System.Windows.Forms.RadioButton();
            this.rd_y = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cari_member = new System.Windows.Forms.Button();
            this.btn_cari = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hasil_cari)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btn_cari);
            this.panel2.Controls.Add(this.lbl_info);
            this.panel2.Controls.Add(this.dgv_hasil_cari);
            this.panel2.Controls.Add(this.cmb_kategori);
            this.panel2.Controls.Add(this.txt_cari);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(29, 130);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 603);
            this.panel2.TabIndex = 2;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(31, 549);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 22);
            this.lbl_info.TabIndex = 18;
            // 
            // dgv_hasil_cari
            // 
            this.dgv_hasil_cari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hasil_cari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_hasil_cari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hasil_cari.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_hasil_cari.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_hasil_cari.Location = new System.Drawing.Point(35, 185);
            this.dgv_hasil_cari.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_hasil_cari.MultiSelect = false;
            this.dgv_hasil_cari.Name = "dgv_hasil_cari";
            this.dgv_hasil_cari.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hasil_cari.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_hasil_cari.RowHeadersWidth = 40;
            this.dgv_hasil_cari.RowTemplate.Height = 28;
            this.dgv_hasil_cari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hasil_cari.Size = new System.Drawing.Size(619, 329);
            this.dgv_hasil_cari.TabIndex = 17;
            // 
            // cmb_kategori
            // 
            this.cmb_kategori.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_kategori.FormattingEnabled = true;
            this.cmb_kategori.Items.AddRange(new object[] {
            "judul",
            "pengarang",
            "penerbit"});
            this.cmb_kategori.Location = new System.Drawing.Point(311, 116);
            this.cmb_kategori.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_kategori.Name = "cmb_kategori";
            this.cmb_kategori.Size = new System.Drawing.Size(209, 38);
            this.cmb_kategori.TabIndex = 2;
            this.cmb_kategori.Text = "judul";
            // 
            // txt_cari
            // 
            this.txt_cari.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cari.Location = new System.Drawing.Point(35, 116);
            this.txt_cari.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(267, 38);
            this.txt_cari.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(687, 71);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pencarian Buku";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btn_submit);
            this.panel3.Controls.Add(this.txt_id_member);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btn_cari_member);
            this.panel3.Controls.Add(this.txt_alamat);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_nama);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.rd_n);
            this.panel3.Controls.Add(this.rd_y);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(775, 131);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 603);
            this.panel3.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.Location = new System.Drawing.Point(35, 206);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(603, 1);
            this.panel6.TabIndex = 37;
            // 
            // txt_id_member
            // 
            this.txt_id_member.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_member.Location = new System.Drawing.Point(216, 231);
            this.txt_id_member.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_member.Name = "txt_id_member";
            this.txt_id_member.ReadOnly = true;
            this.txt_id_member.Size = new System.Drawing.Size(293, 35);
            this.txt_id_member.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 239);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "ID Member";
            // 
            // txt_alamat
            // 
            this.txt_alamat.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alamat.Location = new System.Drawing.Point(216, 351);
            this.txt_alamat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_alamat.Multiline = true;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(420, 159);
            this.txt_alamat.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Alamat";
            // 
            // txt_nama
            // 
            this.txt_nama.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama.Location = new System.Drawing.Point(216, 290);
            this.txt_nama.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(420, 35);
            this.txt_nama.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nama Lengkap";
            // 
            // rd_n
            // 
            this.rd_n.AutoSize = true;
            this.rd_n.Checked = true;
            this.rd_n.Location = new System.Drawing.Point(96, 170);
            this.rd_n.Margin = new System.Windows.Forms.Padding(4);
            this.rd_n.Name = "rd_n";
            this.rd_n.Size = new System.Drawing.Size(69, 21);
            this.rd_n.TabIndex = 4;
            this.rd_n.TabStop = true;
            this.rd_n.Text = "TIDAK";
            this.rd_n.UseVisualStyleBackColor = true;
            this.rd_n.CheckedChanged += new System.EventHandler(this.rd_n_CheckedChanged);
            // 
            // rd_y
            // 
            this.rd_y.AutoSize = true;
            this.rd_y.Location = new System.Drawing.Point(36, 170);
            this.rd_y.Margin = new System.Windows.Forms.Padding(4);
            this.rd_y.Name = "rd_y";
            this.rd_y.Size = new System.Drawing.Size(47, 21);
            this.rd_y.TabIndex = 3;
            this.rd_y.Text = "YA";
            this.rd_y.UseVisualStyleBackColor = true;
            this.rd_y.CheckedChanged += new System.EventHandler(this.rd_y_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Member Perpustakaan";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(0, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(687, 71);
            this.panel5.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Buku Tamu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(255, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "NetBook Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(401, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 71);
            this.panel1.TabIndex = 2;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Transparent;
            this.btn_submit.BackgroundImage = global::NetLibraryClient.Properties.Resources.diskette;
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_submit.Location = new System.Drawing.Point(309, 518);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btn_submit.Size = new System.Drawing.Size(125, 51);
            this.btn_submit.TabIndex = 36;
            this.btn_submit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cari_member
            // 
            this.btn_cari_member.BackColor = System.Drawing.Color.Transparent;
            this.btn_cari_member.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cari_member.BackgroundImage")));
            this.btn_cari_member.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cari_member.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cari_member.Enabled = false;
            this.btn_cari_member.FlatAppearance.BorderSize = 0;
            this.btn_cari_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cari_member.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari_member.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cari_member.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cari_member.Location = new System.Drawing.Point(526, 210);
            this.btn_cari_member.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cari_member.Name = "btn_cari_member";
            this.btn_cari_member.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btn_cari_member.Size = new System.Drawing.Size(100, 72);
            this.btn_cari_member.TabIndex = 33;
            this.btn_cari_member.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cari_member.UseVisualStyleBackColor = false;
            this.btn_cari_member.Click += new System.EventHandler(this.btn_cari_member_Click);
            // 
            // btn_cari
            // 
            this.btn_cari.BackColor = System.Drawing.Color.Transparent;
            this.btn_cari.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cari.BackgroundImage")));
            this.btn_cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cari.FlatAppearance.BorderSize = 0;
            this.btn_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cari.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cari.Location = new System.Drawing.Point(541, 100);
            this.btn_cari.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btn_cari.Size = new System.Drawing.Size(97, 75);
            this.btn_cari.TabIndex = 27;
            this.btn_cari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cari.UseVisualStyleBackColor = false;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(337, 573);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "Submit";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1489, 754);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hasil_cari)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.DataGridView dgv_hasil_cari;
        private System.Windows.Forms.ComboBox cmb_kategori;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_id_member;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cari_member;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rd_n;
        private System.Windows.Forms.RadioButton rd_y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}

