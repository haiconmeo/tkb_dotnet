namespace lapTKB
{
    partial class add_gv_2
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
            this.fgv_name_b = new System.Windows.Forms.TextBox();
            this.fgv_sdt_tb = new System.Windows.Forms.TextBox();
            this.fgv_hocvi_tb = new System.Windows.Forms.TextBox();
            this.fgv_chuyennanh_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fgv_add_bt = new System.Windows.Forms.Button();
            this.fgv_cancel_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fgv_name_b
            // 
            this.fgv_name_b.Location = new System.Drawing.Point(99, 31);
            this.fgv_name_b.Name = "fgv_name_b";
            this.fgv_name_b.Size = new System.Drawing.Size(160, 20);
            this.fgv_name_b.TabIndex = 0;
            // 
            // fgv_sdt_tb
            // 
            this.fgv_sdt_tb.Location = new System.Drawing.Point(99, 107);
            this.fgv_sdt_tb.Name = "fgv_sdt_tb";
            this.fgv_sdt_tb.Size = new System.Drawing.Size(160, 20);
            this.fgv_sdt_tb.TabIndex = 1;
            // 
            // fgv_hocvi_tb
            // 
            this.fgv_hocvi_tb.Location = new System.Drawing.Point(452, 31);
            this.fgv_hocvi_tb.Name = "fgv_hocvi_tb";
            this.fgv_hocvi_tb.Size = new System.Drawing.Size(161, 20);
            this.fgv_hocvi_tb.TabIndex = 2;
            // 
            // fgv_chuyennanh_tb
            // 
            this.fgv_chuyennanh_tb.Location = new System.Drawing.Point(452, 107);
            this.fgv_chuyennanh_tb.Name = "fgv_chuyennanh_tb";
            this.fgv_chuyennanh_tb.Size = new System.Drawing.Size(161, 20);
            this.fgv_chuyennanh_tb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Giảng Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "chuyên ngành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "học vị";
            // 
            // fgv_add_bt
            // 
            this.fgv_add_bt.Location = new System.Drawing.Point(193, 207);
            this.fgv_add_bt.Name = "fgv_add_bt";
            this.fgv_add_bt.Size = new System.Drawing.Size(95, 23);
            this.fgv_add_bt.TabIndex = 8;
            this.fgv_add_bt.Text = "add";
            this.fgv_add_bt.UseVisualStyleBackColor = true;
            this.fgv_add_bt.Click += new System.EventHandler(this.fgv_add_bt_Click);
            // 
            // fgv_cancel_bt
            // 
            this.fgv_cancel_bt.Location = new System.Drawing.Point(374, 207);
            this.fgv_cancel_bt.Name = "fgv_cancel_bt";
            this.fgv_cancel_bt.Size = new System.Drawing.Size(95, 23);
            this.fgv_cancel_bt.TabIndex = 9;
            this.fgv_cancel_bt.Text = "cancel";
            this.fgv_cancel_bt.UseVisualStyleBackColor = true;
            this.fgv_cancel_bt.Click += new System.EventHandler(this.fgv_cancel_bt_Click);
            // 
            // add_gv_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fgv_cancel_bt);
            this.Controls.Add(this.fgv_add_bt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fgv_chuyennanh_tb);
            this.Controls.Add(this.fgv_hocvi_tb);
            this.Controls.Add(this.fgv_sdt_tb);
            this.Controls.Add(this.fgv_name_b);
            this.Name = "add_gv_2";
            this.Text = "add_gv_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fgv_name_b;
        private System.Windows.Forms.TextBox fgv_sdt_tb;
        private System.Windows.Forms.TextBox fgv_hocvi_tb;
        private System.Windows.Forms.TextBox fgv_chuyennanh_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button fgv_add_bt;
        private System.Windows.Forms.Button fgv_cancel_bt;
    }
}