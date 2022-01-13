
namespace NetLibraryAdmin
{
    partial class statistik
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
            this.txt_count = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_tampil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_selesai = new System.Windows.Forms.ComboBox();
            this.cmb_mulai = new System.Windows.Forms.ComboBox();
            this.dgv_data_pengunjung = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_pengunjung)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_count
            // 
            this.txt_count.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_count.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_count.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_count.Location = new System.Drawing.Point(884, 328);
            this.txt_count.Margin = new System.Windows.Forms.Padding(4);
            this.txt_count.Name = "txt_count";
            this.txt_count.ReadOnly = true;
            this.txt_count.Size = new System.Drawing.Size(133, 58);
            this.txt_count.TabIndex = 42;
            this.txt_count.Text = "2";
            this.txt_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_count.TextChanged += new System.EventHandler(this.txt_count_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(835, 411);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 52);
            this.label4.TabIndex = 41;
            this.label4.Text = "Pengunjung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(875, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 52);
            this.label3.TabIndex = 40;
            this.label3.Text = "TOTAL";
            // 
            // btn_tampil
            // 
            this.btn_tampil.BackColor = System.Drawing.Color.DimGray;
            this.btn_tampil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tampil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tampil.FlatAppearance.BorderSize = 0;
            this.btn_tampil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tampil.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tampil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tampil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tampil.Location = new System.Drawing.Point(616, 128);
            this.btn_tampil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tampil.Name = "btn_tampil";
            this.btn_tampil.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btn_tampil.Size = new System.Drawing.Size(153, 39);
            this.btn_tampil.TabIndex = 39;
            this.btn_tampil.Text = "TAMPILKAN";
            this.btn_tampil.UseVisualStyleBackColor = false;
            this.btn_tampil.Click += new System.EventHandler(this.btn_tampil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "-";
            // 
            // cmb_selesai
            // 
            this.cmb_selesai.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_selesai.FormattingEnabled = true;
            this.cmb_selesai.Location = new System.Drawing.Point(295, 131);
            this.cmb_selesai.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_selesai.Name = "cmb_selesai";
            this.cmb_selesai.Size = new System.Drawing.Size(203, 31);
            this.cmb_selesai.TabIndex = 37;
            this.cmb_selesai.SelectedIndexChanged += new System.EventHandler(this.cmb_selesai_SelectedIndexChanged);
            // 
            // cmb_mulai
            // 
            this.cmb_mulai.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mulai.FormattingEnabled = true;
            this.cmb_mulai.Location = new System.Drawing.Point(36, 131);
            this.cmb_mulai.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_mulai.Name = "cmb_mulai";
            this.cmb_mulai.Size = new System.Drawing.Size(203, 31);
            this.cmb_mulai.TabIndex = 36;
            this.cmb_mulai.SelectedIndexChanged += new System.EventHandler(this.cmb_mulai_SelectedIndexChanged);
            // 
            // dgv_data_pengunjung
            // 
            this.dgv_data_pengunjung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data_pengunjung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data_pengunjung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data_pengunjung.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data_pengunjung.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_data_pengunjung.Location = new System.Drawing.Point(36, 195);
            this.dgv_data_pengunjung.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_data_pengunjung.MultiSelect = false;
            this.dgv_data_pengunjung.Name = "dgv_data_pengunjung";
            this.dgv_data_pengunjung.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data_pengunjung.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_data_pengunjung.RowHeadersWidth = 40;
            this.dgv_data_pengunjung.RowTemplate.Height = 28;
            this.dgv_data_pengunjung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data_pengunjung.Size = new System.Drawing.Size(791, 384);
            this.dgv_data_pengunjung.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(174, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "Statistik Pengunjung";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::NetLibraryAdmin.Properties.Resources.inferential_statistics1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.button1.Size = new System.Drawing.Size(153, 89);
            this.button1.TabIndex = 43;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // statistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 671);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_tampil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_selesai);
            this.Controls.Add(this.cmb_mulai);
            this.Controls.Add(this.dgv_data_pengunjung);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "statistik";
            this.Text = "statistik";
            this.Load += new System.EventHandler(this.statistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_pengunjung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_tampil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_selesai;
        private System.Windows.Forms.ComboBox cmb_mulai;
        private System.Windows.Forms.DataGridView dgv_data_pengunjung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}