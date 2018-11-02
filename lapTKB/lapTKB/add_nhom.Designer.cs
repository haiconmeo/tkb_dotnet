namespace lapTKB
{
    partial class add_nhom
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
            this.label4 = new System.Windows.Forms.Label();
            this.f4_name_tb = new System.Windows.Forms.TextBox();
            this.f4_mail_tb = new System.Windows.Forms.TextBox();
            this.f4_khoa_tb = new System.Windows.Forms.TextBox();
            this.f4_chunhiem_tb = new System.Windows.Forms.TextBox();
            this.f5_show_bt = new System.Windows.Forms.Button();
            this.f5_add_bt = new System.Windows.Forms.Button();
            this.f5_delete_bt = new System.Windows.Forms.Button();
            this.f5_update_bt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhóm ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "khóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "chủ nhiệm";
            // 
            // f4_name_tb
            // 
            this.f4_name_tb.Location = new System.Drawing.Point(122, 48);
            this.f4_name_tb.Name = "f4_name_tb";
            this.f4_name_tb.Size = new System.Drawing.Size(136, 20);
            this.f4_name_tb.TabIndex = 4;
            // 
            // f4_mail_tb
            // 
            this.f4_mail_tb.Location = new System.Drawing.Point(122, 123);
            this.f4_mail_tb.Name = "f4_mail_tb";
            this.f4_mail_tb.Size = new System.Drawing.Size(136, 20);
            this.f4_mail_tb.TabIndex = 5;
            // 
            // f4_khoa_tb
            // 
            this.f4_khoa_tb.Location = new System.Drawing.Point(466, 48);
            this.f4_khoa_tb.Name = "f4_khoa_tb";
            this.f4_khoa_tb.Size = new System.Drawing.Size(136, 20);
            this.f4_khoa_tb.TabIndex = 6;
            // 
            // f4_chunhiem_tb
            // 
            this.f4_chunhiem_tb.Location = new System.Drawing.Point(466, 120);
            this.f4_chunhiem_tb.Name = "f4_chunhiem_tb";
            this.f4_chunhiem_tb.Size = new System.Drawing.Size(136, 20);
            this.f4_chunhiem_tb.TabIndex = 7;
            // 
            // f5_show_bt
            // 
            this.f5_show_bt.Location = new System.Drawing.Point(102, 187);
            this.f5_show_bt.Name = "f5_show_bt";
            this.f5_show_bt.Size = new System.Drawing.Size(96, 23);
            this.f5_show_bt.TabIndex = 8;
            this.f5_show_bt.Text = "show";
            this.f5_show_bt.UseVisualStyleBackColor = true;
            this.f5_show_bt.Click += new System.EventHandler(this.f5_show_bt_Click);
            // 
            // f5_add_bt
            // 
            this.f5_add_bt.Location = new System.Drawing.Point(242, 187);
            this.f5_add_bt.Name = "f5_add_bt";
            this.f5_add_bt.Size = new System.Drawing.Size(105, 23);
            this.f5_add_bt.TabIndex = 9;
            this.f5_add_bt.Text = "add";
            this.f5_add_bt.UseVisualStyleBackColor = true;
            this.f5_add_bt.Click += new System.EventHandler(this.f5_add_bt_Click);
            // 
            // f5_delete_bt
            // 
            this.f5_delete_bt.Location = new System.Drawing.Point(402, 187);
            this.f5_delete_bt.Name = "f5_delete_bt";
            this.f5_delete_bt.Size = new System.Drawing.Size(75, 23);
            this.f5_delete_bt.TabIndex = 10;
            this.f5_delete_bt.Text = "delete";
            this.f5_delete_bt.UseVisualStyleBackColor = true;
            this.f5_delete_bt.Click += new System.EventHandler(this.f5_delete_bt_Click);
            // 
            // f5_update_bt
            // 
            this.f5_update_bt.Location = new System.Drawing.Point(547, 187);
            this.f5_update_bt.Name = "f5_update_bt";
            this.f5_update_bt.Size = new System.Drawing.Size(75, 23);
            this.f5_update_bt.TabIndex = 11;
            this.f5_update_bt.Text = "update";
            this.f5_update_bt.UseVisualStyleBackColor = true;
            this.f5_update_bt.Click += new System.EventHandler(this.f5_update_bt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // add_nhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.f5_update_bt);
            this.Controls.Add(this.f5_delete_bt);
            this.Controls.Add(this.f5_add_bt);
            this.Controls.Add(this.f5_show_bt);
            this.Controls.Add(this.f4_chunhiem_tb);
            this.Controls.Add(this.f4_khoa_tb);
            this.Controls.Add(this.f4_mail_tb);
            this.Controls.Add(this.f4_name_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_nhom";
            this.Text = "add_nhom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox f4_name_tb;
        private System.Windows.Forms.TextBox f4_mail_tb;
        private System.Windows.Forms.TextBox f4_khoa_tb;
        private System.Windows.Forms.TextBox f4_chunhiem_tb;
        private System.Windows.Forms.Button f5_show_bt;
        private System.Windows.Forms.Button f5_add_bt;
        private System.Windows.Forms.Button f5_delete_bt;
        private System.Windows.Forms.Button f5_update_bt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}