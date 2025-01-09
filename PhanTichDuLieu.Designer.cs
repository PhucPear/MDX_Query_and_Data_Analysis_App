namespace Nhom8_Form_DoHop
{
    partial class PhanTichDuLieu
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
            this.dgv_phanTich = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkedListBox_dim = new System.Windows.Forms.CheckedListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkedListBox_mea = new System.Windows.Forms.CheckedListBox();
            this.btn_thucThi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phanTich)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_phanTich
            // 
            this.dgv_phanTich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phanTich.Location = new System.Drawing.Point(0, 5);
            this.dgv_phanTich.Name = "dgv_phanTich";
            this.dgv_phanTich.Size = new System.Drawing.Size(1600, 725);
            this.dgv_phanTich.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1606, 870);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_phanTich);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1600, 581);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btn_thucThi);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 282);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Measures:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dimension:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkedListBox_dim);
            this.panel5.Location = new System.Drawing.Point(645, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(448, 276);
            this.panel5.TabIndex = 5;
            // 
            // checkedListBox_dim
            // 
            this.checkedListBox_dim.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_dim.FormattingEnabled = true;
            this.checkedListBox_dim.Items.AddRange(new object[] {
            "[Dim Thoi Gian].[Nam Dat Hang].[Nam Dat Hang]",
            "[Dim Thoi Gian].[Quy Dat Hang].[Quy Dat Hang]",
            "[Dim Thoi Gian].[Thang Dat Hang].[Thang Dat Hang]",
            "[Dim Thoi Gian].[Ngay Dat Hang].[Ngay Dat Hang]",
            "[Dim Khu Vuc].[Tinh TP].[Tinh TP]",
            "[Dim Khu Vuc].[Quan Huyen].[Quan Huyen]",
            "[Dim Khu Vuc].[Xa Phuong].[Xa Phuong]",
            "[Dim Nha Cung Cap].[Ten NCC].[Ten NCC]",
            "[Dim Cua Hang].[Ten CH].[Ten CH]",
            "[Dim Khach Hang].[Ten KH].[Ten KH]",
            "[Dim San Pham].[Ten SP].[Ten SP]"});
            this.checkedListBox_dim.Location = new System.Drawing.Point(3, 6);
            this.checkedListBox_dim.Name = "checkedListBox_dim";
            this.checkedListBox_dim.Size = new System.Drawing.Size(442, 268);
            this.checkedListBox_dim.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkedListBox_mea);
            this.panel4.Location = new System.Drawing.Point(125, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(374, 276);
            this.panel4.TabIndex = 4;
            // 
            // checkedListBox_mea
            // 
            this.checkedListBox_mea.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_mea.FormattingEnabled = true;
            this.checkedListBox_mea.Items.AddRange(new object[] {
            "[Measures].[Doanh Thu]",
            "[Measures].[Fact Ban Hang Count]",
            "[Measures].[Giam Gia]",
            "[Measures].[Loi Nhuan]",
            "[Measures].[Phi Van Chuyen]",
            "[Measures].[So Luong Ban]",
            "[Measures].[So Luong Ton - Fact Ban Hang]",
            "[Measures].[Thanh Tien]"});
            this.checkedListBox_mea.Location = new System.Drawing.Point(3, 6);
            this.checkedListBox_mea.Name = "checkedListBox_mea";
            this.checkedListBox_mea.Size = new System.Drawing.Size(368, 268);
            this.checkedListBox_mea.TabIndex = 3;
            // 
            // btn_thucThi
            // 
            this.btn_thucThi.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_thucThi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thucThi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_thucThi.Location = new System.Drawing.Point(1127, 102);
            this.btn_thucThi.Name = "btn_thucThi";
            this.btn_thucThi.Size = new System.Drawing.Size(153, 58);
            this.btn_thucThi.TabIndex = 2;
            this.btn_thucThi.Text = "Thực thi";
            this.btn_thucThi.UseVisualStyleBackColor = false;
            this.btn_thucThi.Click += new System.EventHandler(this.btn_thucThi_Click);
            // 
            // PhanTichDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1606, 870);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhanTichDuLieu";
            this.Text = "Phân tích dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phanTich)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_phanTich;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_thucThi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox_mea;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox_dim;
    }
}