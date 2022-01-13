
namespace NetLibraryAdmin
{
    partial class beranda
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.chart_home = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_jml_buku = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_jml_pegawai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_jml_member = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_jml_pinjam = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart_home)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Beranda";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Gray;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(904, 665);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btn_update.Size = new System.Drawing.Size(166, 36);
            this.btn_update.TabIndex = 45;
            this.btn_update.Text = "UPDATE/REFRESH";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // chart_home
            // 
            this.chart_home.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart_home.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_home.Legends.Add(legend1);
            this.chart_home.Location = new System.Drawing.Point(277, 116);
            this.chart_home.Margin = new System.Windows.Forms.Padding(4);
            this.chart_home.Name = "chart_home";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Statistik Pengunjung";
            series1.Name = "statistik";
            this.chart_home.Series.Add(series1);
            this.chart_home.Size = new System.Drawing.Size(805, 541);
            this.chart_home.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(21, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "Total Buku";
            // 
            // txt_jml_buku
            // 
            this.txt_jml_buku.BackColor = System.Drawing.Color.Silver;
            this.txt_jml_buku.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_jml_buku.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jml_buku.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_jml_buku.Location = new System.Drawing.Point(180, 116);
            this.txt_jml_buku.Margin = new System.Windows.Forms.Padding(4);
            this.txt_jml_buku.Name = "txt_jml_buku";
            this.txt_jml_buku.ReadOnly = true;
            this.txt_jml_buku.Size = new System.Drawing.Size(80, 39);
            this.txt_jml_buku.TabIndex = 37;
            this.txt_jml_buku.Text = "27";
            this.txt_jml_buku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(21, 528);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 29);
            this.label5.TabIndex = 38;
            this.label5.Text = "Total Pegawai";
            // 
            // txt_jml_pegawai
            // 
            this.txt_jml_pegawai.BackColor = System.Drawing.Color.Silver;
            this.txt_jml_pegawai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_jml_pegawai.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jml_pegawai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_jml_pegawai.Location = new System.Drawing.Point(180, 425);
            this.txt_jml_pegawai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_jml_pegawai.Name = "txt_jml_pegawai";
            this.txt_jml_pegawai.ReadOnly = true;
            this.txt_jml_pegawai.Size = new System.Drawing.Size(80, 39);
            this.txt_jml_pegawai.TabIndex = 37;
            this.txt_jml_pegawai.Text = "27";
            this.txt_jml_pegawai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(21, 375);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "Member Aktif";
            // 
            // txt_jml_member
            // 
            this.txt_jml_member.BackColor = System.Drawing.Color.Silver;
            this.txt_jml_member.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_jml_member.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jml_member.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_jml_member.Location = new System.Drawing.Point(180, 272);
            this.txt_jml_member.Margin = new System.Windows.Forms.Padding(4);
            this.txt_jml_member.Name = "txt_jml_member";
            this.txt_jml_member.ReadOnly = true;
            this.txt_jml_member.Size = new System.Drawing.Size(80, 39);
            this.txt_jml_member.TabIndex = 37;
            this.txt_jml_member.Text = "27";
            this.txt_jml_member.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(21, 684);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 38;
            this.label6.Text = "Peminjaman";
            // 
            // txt_jml_pinjam
            // 
            this.txt_jml_pinjam.BackColor = System.Drawing.Color.Silver;
            this.txt_jml_pinjam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_jml_pinjam.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jml_pinjam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_jml_pinjam.Location = new System.Drawing.Point(180, 585);
            this.txt_jml_pinjam.Margin = new System.Windows.Forms.Padding(4);
            this.txt_jml_pinjam.Name = "txt_jml_pinjam";
            this.txt_jml_pinjam.ReadOnly = true;
            this.txt_jml_pinjam.Size = new System.Drawing.Size(80, 39);
            this.txt_jml_pinjam.TabIndex = 37;
            this.txt_jml_pinjam.Text = "27";
            this.txt_jml_pinjam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::NetLibraryAdmin.Properties.Resources.house1;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(17, 9);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 99);
            this.panel5.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::NetLibraryAdmin.Properties.Resources.employee;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(13, 425);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 99);
            this.panel3.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::NetLibraryAdmin.Properties.Resources.team;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(13, 272);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 99);
            this.panel2.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::NetLibraryAdmin.Properties.Resources.book_stack;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(17, 116);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 99);
            this.panel1.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::NetLibraryAdmin.Properties.Resources.book__1_1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(13, 585);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 99);
            this.panel4.TabIndex = 44;
            // 
            // beranda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1095, 728);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_jml_pinjam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_jml_pegawai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_jml_buku);
            this.Controls.Add(this.txt_jml_member);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart_home);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "beranda";
            this.Text = "beranda";
            this.Load += new System.EventHandler(this.beranda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_jml_pegawai;
        private System.Windows.Forms.TextBox txt_jml_pinjam;
        private System.Windows.Forms.TextBox txt_jml_member;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_jml_buku;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_home;
        private System.Windows.Forms.Panel panel5;
    }
}