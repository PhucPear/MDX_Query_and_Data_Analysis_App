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
    public partial class PhanTichDuLieu : Form
    {
        public PhanTichDuLieu()
        {
            InitializeComponent();
        }

        private string layItemMeasures()
        {
            int count = checkedListBox_mea.CheckedItems.Count;
            string measuresCol = "";
            if (count <= 1)
            {
                measuresCol = "SELECT NON EMPTY ";
                foreach (object item in checkedListBox_mea.CheckedItems)
                {
                    measuresCol += item.ToString();
                }
                measuresCol += " ON COLUMNS,";
            }
            else
            {
                measuresCol = "SELECT NON EMPTY {";
                foreach (object item in checkedListBox_mea.CheckedItems)
                {
                    measuresCol += item.ToString() + ",";
                }
                measuresCol = measuresCol.Substring(0, measuresCol.Length - 1);
                measuresCol += "} ON COLUMNS,";
            }          
            return measuresCol;
        }

        private string layItemDimension()
        {
            int count = checkedListBox_dim.CheckedItems.Count;
            string dimensionRow = "";
            if (count <= 1)
            {
                dimensionRow = " NON EMPTY ";
                foreach (object item in checkedListBox_dim.CheckedItems)
                {
                    dimensionRow += item.ToString();
                }
                dimensionRow += " ON ROWS FROM [Cube Ban Hang Do Hop]";
            }
            else
            {
                dimensionRow = " NON EMPTY {";
                foreach (object item in checkedListBox_dim.CheckedItems)
                {
                    dimensionRow += item.ToString() + "*";
                }
                dimensionRow = dimensionRow.Substring(0, dimensionRow.Length - 1);
                dimensionRow += "} ON ROWS FROM [Cube Ban Hang Do Hop]";
            }
            return dimensionRow;
        }

        private void btn_thucThi_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            dgv_phanTich.DataSource = table;
            int countMea = checkedListBox_mea.CheckedItems.Count;
            int countDim = checkedListBox_dim.CheckedItems.Count;
            if (countMea < 1 || countDim < 1)
            {
                MessageBox.Show("Vui lòng chọn các dimension và measures!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                string connectionString = @"Provider=MSOLAP;Data Source=LAPTOP-HTD9EHLE\MSSQLSERVER2019;Catalog=Nhom8_SSAS_DoHop;";
                string mdxQuery = "";
                mdxQuery += layItemMeasures();
                mdxQuery += layItemDimension();           
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
                                dgv_phanTich.DataSource = resultTable;
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
}
