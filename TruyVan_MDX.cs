using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.AnalysisServices.AdomdClient;

namespace Nhom8_Form_DoHop
{
    public partial class TruyVan_MDX : Form
    {
        public TruyVan_MDX()
        {
            InitializeComponent();
        }

        private void btn_thucThi_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=MSOLAP;Data Source=LAPTOP-HTD9EHLE\MSSQLSERVER2019;Catalog=Nhom8_SSAS_DoHop;";
            string mdxQuery = txt_mdx.Text;
            try
            {
                using (AdomdConnection connection = new AdomdConnection(connectionString))
                {
                    connection.Open();
                    using (AdomdCommand cmd = new AdomdCommand(mdxQuery, connection))
                    {
                        using (AdomdDataAdapter adapter = new AdomdDataAdapter(cmd))
                        {
                            DataTable resultTable = new DataTable();
                            adapter.Fill(resultTable);
                            dgv_mdx.DataSource = resultTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn MDX: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
