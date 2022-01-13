using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetLibraryAdmin
{
    public partial class administrator : Form
    {

        private model.pegawai pg = new model.pegawai();
        public administrator()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.MinimumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            default_page();
        }

        private void menu_user()
        {
            if (status_level.Text == "KATALOG")
            {
                btn_pinjam.Visible = false;
                btn_kembali.Visible = false;
                btn_member.Visible = false;
                btn_petugas.Visible = false;

                btn_pengunjung.Location = new Point(16, 172);
            }
            else if (status_level.Text == "PELAYANAN")
            {
                btn_buku.Visible = false;
                btn_rak.Visible = false;
                btn_petugas.Visible = false;

                btn_pinjam.Location = new Point(16, 70);
                btn_kembali.Location = new Point(16, 121);
                btn_member.Location = new Point(16, 172);
                btn_pengunjung.Location = new Point(16, 223);
            }
        }


       

        private void tentangToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("nipa ua ndnda9");
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin Keluar Aplikasi.?", "Konfirmasi", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void default_page()
        {
            panel_content.Controls.Clear();

            beranda home = new beranda();
            home.TopLevel = false;
            panel_content.Controls.Add(home);
            home.Show();
        }
        private void btn_beranda_Click(object sender, EventArgs e)
        {
            default_page();
        }

        private void panel_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_buku_Click(object sender, EventArgs e)
        {
            panel_content.Controls.Clear();

            buku home = new buku();
            home.TopLevel = false;
            panel_content.Controls.Add(home);
            home.Show();
        }

        private void btn_rak_Click(object sender, EventArgs e)
        {
            panel_content.Controls.Clear();

            rak_buku home = new rak_buku();
            home.TopLevel = false;
            panel_content.Controls.Add(home);
            home.Show();
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            panel_content.Controls.Clear();

            member home = new member();
            home.TopLevel = false;
            panel_content.Controls.Add(home);
            home.Show();
        }

        private void btn_pinjam_Click(object sender, EventArgs e)
        {
            panel_content.Controls.Clear();

            peminjaman home = new peminjaman(this);
            home.TopLevel = false;
            panel_content.Controls.Add(home);
            home.Show();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            panel_content.Controls.Clear();

            pengembalian home = new pengembalian(this);
            home.TopLevel = false;
            panel_content.Controls.Add(home);
            home.Show();
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_bar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void administrator_Load(object sender, EventArgs e)
        {
            menu_user();
            show_pegawai();
        }

       
        public void show_pegawai()
        {
            var data = pg.get_pegawai(status_id.Text);

            lbl_id.Text = data[0];
            lbl_nama.Text = data[1];
            lbl_telp.Text = data[3];
            lbl_level.Text = data[4];
            txt_alamat.Text = data[2];
        }

        

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            this.status_id.Text = "";
            this.status_level.Text = "";
            this.status_nama.Text = "";
            this.Hide();

            form_login login = new form_login();
            login.Show();
        }

        private void btn_petugas_Click(object sender, EventArgs e)
        {
            panel_content.Controls.Clear();

            pegawai home = new pegawai();
            home.TopLevel = false;
            panel_content.Controls.Add(home);
            home.Show();
        }

        private void btn_pengunjung_Click(object sender, EventArgs e)
        {
            panel_content.Controls.Clear();

            statistik home = new statistik();
            home.TopLevel = false;
            panel_content.Controls.Add(home);
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikasi Penjualan 2019 MUH. YAUMIL AKSAH HAMID, LINTANG PAMUNGKAS, HANAFI ASNAN, OKTAVIANA, WAHYU HIDAYAT, NAUFAL");
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin Keluar dari Aplikasi Penjualan.?", "Konfirmasi", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_profile_Click_1(object sender, EventArgs e)
        {
            profile_form form = new profile_form(this);
            form.txt_id.Text = lbl_id.Text;
            form.txt_nama.Text = lbl_nama.Text;
            form.txt_telp.Text = lbl_telp.Text;
            form.txt_alamat.Text = txt_alamat.Text;
            form.lbl_jabatan.Text = lbl_level.Text;
            form.ShowDialog();

        }

        private void txt_alamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
