using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace Nhom8_Form_DoHop
{
    public partial class NapDuLieu_Excel : Form
    {
        public NapDuLieu_Excel()
        {
            InitializeComponent();
        }
        string sqlConnection = @"Data Source=LAPTOP-HTD9EHLE\MSSQLSERVER2019;Initial Catalog=dovao;User ID=sa;Password=123";
        private void btn_napDT_Click(object sender, EventArgs e)
        {
            string excelFilePath = txt_file.Text;
            if (excelFilePath.Equals(""))
            {
                MessageBox.Show("Hãy chọn File Excel nguồn!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(excelFilePath);
                Excel.Worksheet excelWorksheet = excelWorkbook.Sheets[1];
                int successCount = 0;
                int rowCount = excelWorksheet.UsedRange.Rows.Count;
                using (SqlConnection connection = new SqlConnection(sqlConnection))
                {
                    connection.Open();

                    for (int row = 2; row <= rowCount; row++)
                    {
                        string RowID = (excelWorksheet.Cells[row, 1] as Excel.Range).Value2.ToString();
                        string MaSP = (excelWorksheet.Cells[row, 2] as Excel.Range).Value2.ToString();
                        string TenSP = (excelWorksheet.Cells[row, 3] as Excel.Range).Value2.ToString();
                        string KhoiLuong = (excelWorksheet.Cells[row, 4] as Excel.Range).Value2.ToString();
                        string DonViTinh = (excelWorksheet.Cells[row, 5] as Excel.Range).Value2.ToString();
                        string DonGia = (excelWorksheet.Cells[row, 6] as Excel.Range).Value2.ToString();
                        string SoLuongTon = (excelWorksheet.Cells[row, 7] as Excel.Range).Value2.ToString();
                        string TinhTrang = (excelWorksheet.Cells[row, 8] as Excel.Range).Value2.ToString();
                        string NgaySX = (excelWorksheet.Cells[row, 9] as Excel.Range).Value2.ToString();
                        string NgayHH = (excelWorksheet.Cells[row, 10] as Excel.Range).Value2.ToString();
                        string MaKH = (excelWorksheet.Cells[row, 11] as Excel.Range).Value2.ToString();
                        string TenKH = (excelWorksheet.Cells[row, 12] as Excel.Range).Value2.ToString();
                        string MaNCC = (excelWorksheet.Cells[row, 13] as Excel.Range).Value2.ToString();
                        string TenNCC = (excelWorksheet.Cells[row, 14] as Excel.Range).Value2.ToString();
                        string MaHD = (excelWorksheet.Cells[row, 15] as Excel.Range).Value2.ToString();
                        string NgayLap = (excelWorksheet.Cells[row, 16] as Excel.Range).Value2.ToString();
                        string SoLuongBan = (excelWorksheet.Cells[row, 17] as Excel.Range).Value2.ToString();
                        string GiamGia = (excelWorksheet.Cells[row, 18] as Excel.Range).Value2.ToString();
                        string ThanhTien = (excelWorksheet.Cells[row, 19] as Excel.Range).Value2.ToString();
                        string MaCH = (excelWorksheet.Cells[row, 20] as Excel.Range).Value2.ToString();
                        string TenCH = (excelWorksheet.Cells[row, 21] as Excel.Range).Value2.ToString();
                        string LoiNhuan = (excelWorksheet.Cells[row, 22] as Excel.Range).Value2.ToString();
                        string TinhTP = (excelWorksheet.Cells[row, 23] as Excel.Range).Value2.ToString();
                        string QuanHuyen = (excelWorksheet.Cells[row, 24] as Excel.Range).Value2.ToString();
                        string XaPhuong = (excelWorksheet.Cells[row, 25] as Excel.Range).Value2.ToString();
                        string DoanhThu = (excelWorksheet.Cells[row, 26] as Excel.Range).Value2.ToString();
                        string PhiVanChuyen = (excelWorksheet.Cells[row, 27] as Excel.Range).Value2.ToString();

                        string query = "INSERT INTO [dbo].[Excel_DoHop]([RowID],[MaSP],[TenSP],[KhoiLuong],[DonViTinh],[DonGia],[SoLuongTon],[TinhTrang],[NgaySX],[NgayHH],[MaKH],[TenKH],[MaNCC],[TenNCC],[MaHD],[NgayLap],[SoLuongBan],[GiamGia],[ThanhTien],[MaCH],[TenCH],[LoiNhuan],[TinhTP],[QuanHuyen],[XaPhuong],[DoanhThu],[PhiVanChuyen]) VALUES(@RowID,@MaSP,@TenSP,@KhoiLuong,@DonViTinh,@DonGia,@SoLuongTon,@TinhTrang,@NgaySX,@NgayHH,@MaKH,@TenKH,@MaNCC,@TenNCC,@MaHD,@NgayLap,@SoLuongBan,@GiamGia,@ThanhTien,@MaCH,@TenCH,@LoiNhuan,@TinhTP,@QuanHuyen,@XaPhuong,@DoanhThu,@PhiVanChuyen)";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@RowID", RowID);
                            cmd.Parameters.AddWithValue("@MaSP", MaSP);
                            cmd.Parameters.AddWithValue("@TenSP", TenSP);
                            cmd.Parameters.AddWithValue("@KhoiLuong", KhoiLuong);
                            cmd.Parameters.AddWithValue("@DonViTinh", DonViTinh);
                            cmd.Parameters.AddWithValue("@DonGia", DonGia);
                            cmd.Parameters.AddWithValue("@SoLuongTon", SoLuongTon);
                            cmd.Parameters.AddWithValue("@TinhTrang", TinhTrang);
                            cmd.Parameters.AddWithValue("@NgaySX", NgaySX);
                            cmd.Parameters.AddWithValue("@NgayHH", NgayHH);
                            cmd.Parameters.AddWithValue("@MaKH", MaKH);
                            cmd.Parameters.AddWithValue("@TenKH", TenKH);
                            cmd.Parameters.AddWithValue("@MaNCC", MaNCC);
                            cmd.Parameters.AddWithValue("@TenNCC", TenNCC);
                            cmd.Parameters.AddWithValue("@MaHD", MaHD);
                            cmd.Parameters.AddWithValue("@NgayLap", NgayLap);
                            cmd.Parameters.AddWithValue("@SoLuongBan", SoLuongBan);
                            cmd.Parameters.AddWithValue("@GiamGia", GiamGia);
                            cmd.Parameters.AddWithValue("@ThanhTien", ThanhTien);
                            cmd.Parameters.AddWithValue("@MaCH", MaCH);
                            cmd.Parameters.AddWithValue("@TenCH", TenCH);
                            cmd.Parameters.AddWithValue("@LoiNhuan", LoiNhuan);
                            cmd.Parameters.AddWithValue("@TinhTP", TinhTP);
                            cmd.Parameters.AddWithValue("@QuanHuyen", QuanHuyen);
                            cmd.Parameters.AddWithValue("@XaPhuong", XaPhuong);
                            cmd.Parameters.AddWithValue("@DoanhThu", DoanhThu);
                            cmd.Parameters.AddWithValue("@PhiVanChuyen", PhiVanChuyen);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                successCount++;
                            }
                        }
                    }
                }
                excelWorkbook.Close(false);
                excelApp.Quit();
                if (successCount == rowCount - 1)
                {
                    MessageBox.Show("Nạp dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi nạp dữ liệu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btn_hienThi_Click(object sender, EventArgs e)
        {
             using (SqlConnection connection = new SqlConnection(sqlConnection))
            {
                connection.Open();

                string query = "SELECT * FROM Excel_DoHop";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);                      
                        dgv_excel.DataSource = dataTable;
                    }
                }
            }     
        }

        private void btn_chonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_file.Text = openFileDialog.FileName;
            }
            if (!txt_file.Text.Equals(""))
            {
                btn_napDT.Enabled = true;
            }
        }   
    }
}
