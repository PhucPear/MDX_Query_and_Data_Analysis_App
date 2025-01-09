namespace Nhom8_Form_DoHop
{
    partial class TruyVan_MDX
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
            this.dgv_mdx = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_thucThi = new System.Windows.Forms.Button();
            this.txt_mdx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mdx)).BeginInit();
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
            this.panel3.Controls.Add(this.dgv_mdx);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1600, 730);
            this.panel3.TabIndex = 1;
            // 
            // dgv_mdx
            // 
            this.dgv_mdx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mdx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_mdx.Location = new System.Drawing.Point(0, 0);
            this.dgv_mdx.Name = "dgv_mdx";
            this.dgv_mdx.Size = new System.Drawing.Size(1600, 730);
            this.dgv_mdx.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_thucThi);
            this.panel2.Controls.Add(this.txt_mdx);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 128);
            this.panel2.TabIndex = 0;
            // 
            // btn_thucThi
            // 
            this.btn_thucThi.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_thucThi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thucThi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_thucThi.Location = new System.Drawing.Point(1049, 39);
            this.btn_thucThi.Name = "btn_thucThi";
            this.btn_thucThi.Size = new System.Drawing.Size(153, 58);
            this.btn_thucThi.TabIndex = 2;
            this.btn_thucThi.Text = "Thực thi";
            this.btn_thucThi.UseVisualStyleBackColor = false;
            this.btn_thucThi.Click += new System.EventHandler(this.btn_thucThi_Click);
            // 
            // txt_mdx
            // 
            this.txt_mdx.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mdx.Location = new System.Drawing.Point(211, 9);
            this.txt_mdx.Multiline = true;
            this.txt_mdx.Name = "txt_mdx";
            this.txt_mdx.Size = new System.Drawing.Size(807, 108);
            this.txt_mdx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập câu truy vấn:";
            // 
            // TruyVan_MDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1606, 870);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TruyVan_MDX";
            this.Text = "Truy vấn MDX";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mdx)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_mdx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_mdx;
        private System.Windows.Forms.Button btn_thucThi;
    }
}