using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom8_Form_DoHop
{
    public partial class Home : Form
    {
        private Form activeForm;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_hienThi.Controls.Add(childForm);
            this.panel_hienThi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_tieuDe.Text = childForm.Text;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NapDuLieu_Excel(), sender);
        }
       
        private void btn_phanTich_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanTichDuLieu(), sender);
        }

        private void btn_mdx_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TruyVan_MDX(), sender);
        }

    }
}
