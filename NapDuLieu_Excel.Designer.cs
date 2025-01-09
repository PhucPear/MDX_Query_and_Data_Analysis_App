namespace Nhom8_Form_DoHop
{
    partial class NapDuLieu_Excel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_excel = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_chonFile = new System.Windows.Forms.Button();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.btn_hienThi = new System.Windows.Forms.Button();
            this.btn_napDT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_excel)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1606, 870);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_excel);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1600, 733);
            this.panel3.TabIndex = 1;
            // 
            // dgv_excel
            // 
            this.dgv_excel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_excel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_excel.Location = new System.Drawing.Point(0, 0);
            this.dgv_excel.Name = "dgv_excel";
            this.dgv_excel.Size = new System.Drawing.Size(1600, 733);
            this.dgv_excel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_chonFile);
            this.panel2.Controls.Add(this.txt_file);
            this.panel2.Controls.Add(this.btn_hienThi);
            this.panel2.Controls.Add(this.btn_napDT);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 125);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn file:";
            // 
            // btn_chonFile
            // 
            this.btn_chonFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chonFile.Location = new System.Drawing.Point(612, 47);
            this.btn_chonFile.Name = "btn_chonFile";
            this.btn_chonFile.Size = new System.Drawing.Size(72, 42);
            this.btn_chonFile.TabIndex = 3;
            this.btn_chonFile.Text = "...";
            this.btn_chonFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_chonFile.UseVisualStyleBackColor = true;
            this.btn_chonFile.Click += new System.EventHandler(this.btn_chonFile_Click);
            // 
            // txt_file
            // 
            this.txt_file.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_file.Location = new System.Drawing.Point(137, 41);
            this.txt_file.Multiline = true;
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(469, 48);
            this.txt_file.TabIndex = 2;
            // 
            // btn_hienThi
            // 
            this.btn_hienThi.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_hienThi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienThi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hienThi.Location = new System.Drawing.Point(932, 41);
            this.btn_hienThi.Name = "btn_hienThi";
            this.btn_hienThi.Size = new System.Drawing.Size(208, 58);
            this.btn_hienThi.TabIndex = 1;
            this.btn_hienThi.Text = "Hiển thị dữ liệu";
            this.btn_hienThi.UseVisualStyleBackColor = false;
            this.btn_hienThi.Click += new System.EventHandler(this.btn_hienThi_Click);
            // 
            // btn_napDT
            // 
            this.btn_napDT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_napDT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_napDT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_napDT.Location = new System.Drawing.Point(725, 41);
            this.btn_napDT.Name = "btn_napDT";
            this.btn_napDT.Size = new System.Drawing.Size(131, 58);
            this.btn_napDT.TabIndex = 0;
            this.btn_napDT.Text = "Nạp dữ liệu";
            this.btn_napDT.UseVisualStyleBackColor = false;
            this.btn_napDT.Click += new System.EventHandler(this.btn_napDT_Click);
            // 
            // NapDuLieu_Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1606, 870);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NapDuLieu_Excel";
            this.Text = "Nạp dữ liệu từ Excel";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_excel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_napDT;
        private System.Windows.Forms.Button btn_hienThi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_excel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_chonFile;
        private System.Windows.Forms.TextBox txt_file;
    }
}