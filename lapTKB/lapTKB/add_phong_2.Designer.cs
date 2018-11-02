namespace lapTKB
{
    partial class add_phong_2
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
            this.fphong_name_tb = new System.Windows.Forms.TextBox();
            this.fphong_quanly_tb = new System.Windows.Forms.TextBox();
            this.fphong_sdt_t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fphong_add_bt = new System.Windows.Forms.Button();
            this.fphong_cancel_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fphong_name_tb
            // 
            this.fphong_name_tb.Location = new System.Drawing.Point(118, 58);
            this.fphong_name_tb.Name = "fphong_name_tb";
            this.fphong_name_tb.Size = new System.Drawing.Size(215, 20);
            this.fphong_name_tb.TabIndex = 0;
            // 
            // fphong_quanly_tb
            // 
            this.fphong_quanly_tb.Location = new System.Drawing.Point(118, 147);
            this.fphong_quanly_tb.Name = "fphong_quanly_tb";
            this.fphong_quanly_tb.Size = new System.Drawing.Size(215, 20);
            this.fphong_quanly_tb.TabIndex = 1;
            // 
            // fphong_sdt_t
            // 
            this.fphong_sdt_t.Location = new System.Drawing.Point(504, 58);
            this.fphong_sdt_t.Name = "fphong_sdt_t";
            this.fphong_sdt_t.Size = new System.Drawing.Size(210, 20);
            this.fphong_sdt_t.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "tên phong";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "quản lý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "số điện thoại";
            // 
            // fphong_add_bt
            // 
            this.fphong_add_bt.Location = new System.Drawing.Point(212, 254);
            this.fphong_add_bt.Name = "fphong_add_bt";
            this.fphong_add_bt.Size = new System.Drawing.Size(75, 23);
            this.fphong_add_bt.TabIndex = 6;
            this.fphong_add_bt.Text = "add";
            this.fphong_add_bt.UseVisualStyleBackColor = true;
            this.fphong_add_bt.Click += new System.EventHandler(this.fphong_add_bt_Click);
            // 
            // fphong_cancel_bt
            // 
            this.fphong_cancel_bt.Location = new System.Drawing.Point(483, 254);
            this.fphong_cancel_bt.Name = "fphong_cancel_bt";
            this.fphong_cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.fphong_cancel_bt.TabIndex = 7;
            this.fphong_cancel_bt.Text = "cancel";
            this.fphong_cancel_bt.UseVisualStyleBackColor = true;
            this.fphong_cancel_bt.Click += new System.EventHandler(this.fphong_cancel_bt_Click);
            // 
            // add_phong_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fphong_cancel_bt);
            this.Controls.Add(this.fphong_add_bt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fphong_sdt_t);
            this.Controls.Add(this.fphong_quanly_tb);
            this.Controls.Add(this.fphong_name_tb);
            this.Name = "add_phong_2";
            this.Text = "add_phong_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fphong_name_tb;
        private System.Windows.Forms.TextBox fphong_quanly_tb;
        private System.Windows.Forms.TextBox fphong_sdt_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fphong_add_bt;
        private System.Windows.Forms.Button fphong_cancel_bt;
    }
}