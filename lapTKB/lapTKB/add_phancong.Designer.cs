namespace lapTKB
{
    partial class add_phancong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.f8_nhom_ccb = new System.Windows.Forms.ComboBox();
            this.f8_mon_cbb = new System.Windows.Forms.ComboBox();
            this.f8_giangvien_cbb = new System.Windows.Forms.ComboBox();
            this.f8_show_bt = new System.Windows.Forms.Button();
            this.f8_add_bt = new System.Windows.Forms.Button();
            this.f8_delete_bt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Môn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giảng VIên";
            // 
            // f8_nhom_ccb
            // 
            this.f8_nhom_ccb.FormattingEnabled = true;
            this.f8_nhom_ccb.Location = new System.Drawing.Point(54, 84);
            this.f8_nhom_ccb.Name = "f8_nhom_ccb";
            this.f8_nhom_ccb.Size = new System.Drawing.Size(121, 21);
            this.f8_nhom_ccb.TabIndex = 3;
            // 
            // f8_mon_cbb
            // 
            this.f8_mon_cbb.FormattingEnabled = true;
            this.f8_mon_cbb.Location = new System.Drawing.Point(304, 84);
            this.f8_mon_cbb.Name = "f8_mon_cbb";
            this.f8_mon_cbb.Size = new System.Drawing.Size(121, 21);
            this.f8_mon_cbb.TabIndex = 4;
            // 
            // f8_giangvien_cbb
            // 
            this.f8_giangvien_cbb.FormattingEnabled = true;
            this.f8_giangvien_cbb.Location = new System.Drawing.Point(584, 84);
            this.f8_giangvien_cbb.Name = "f8_giangvien_cbb";
            this.f8_giangvien_cbb.Size = new System.Drawing.Size(121, 21);
            this.f8_giangvien_cbb.TabIndex = 5;
            // 
            // f8_show_bt
            // 
            this.f8_show_bt.Location = new System.Drawing.Point(54, 199);
            this.f8_show_bt.Name = "f8_show_bt";
            this.f8_show_bt.Size = new System.Drawing.Size(75, 23);
            this.f8_show_bt.TabIndex = 6;
            this.f8_show_bt.Text = "show";
            this.f8_show_bt.UseVisualStyleBackColor = true;
            this.f8_show_bt.Click += new System.EventHandler(this.f8_show_bt_Click);
            // 
            // f8_add_bt
            // 
            this.f8_add_bt.Location = new System.Drawing.Point(313, 199);
            this.f8_add_bt.Name = "f8_add_bt";
            this.f8_add_bt.Size = new System.Drawing.Size(75, 23);
            this.f8_add_bt.TabIndex = 7;
            this.f8_add_bt.Text = "add";
            this.f8_add_bt.UseVisualStyleBackColor = true;
            this.f8_add_bt.Click += new System.EventHandler(this.f8_add_bt_Click);
            // 
            // f8_delete_bt
            // 
            this.f8_delete_bt.Location = new System.Drawing.Point(584, 199);
            this.f8_delete_bt.Name = "f8_delete_bt";
            this.f8_delete_bt.Size = new System.Drawing.Size(75, 23);
            this.f8_delete_bt.TabIndex = 8;
            this.f8_delete_bt.Text = "delete";
            this.f8_delete_bt.UseVisualStyleBackColor = true;
            this.f8_delete_bt.Click += new System.EventHandler(this.f8_delete_bt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // add_phancong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.f8_delete_bt);
            this.Controls.Add(this.f8_add_bt);
            this.Controls.Add(this.f8_show_bt);
            this.Controls.Add(this.f8_giangvien_cbb);
            this.Controls.Add(this.f8_mon_cbb);
            this.Controls.Add(this.f8_nhom_ccb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_phancong";
            this.Text = "add_phancong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox f8_nhom_ccb;
        private System.Windows.Forms.ComboBox f8_mon_cbb;
        private System.Windows.Forms.ComboBox f8_giangvien_cbb;
        private System.Windows.Forms.Button f8_show_bt;
        private System.Windows.Forms.Button f8_add_bt;
        private System.Windows.Forms.Button f8_delete_bt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}