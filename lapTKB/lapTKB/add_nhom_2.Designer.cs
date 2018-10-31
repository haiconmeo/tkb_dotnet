namespace lapTKB
{
    partial class add_nhom_2
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
            this.fnhom_name_tb = new System.Windows.Forms.TextBox();
            this.fnhom_mail_tb = new System.Windows.Forms.TextBox();
            this.fnhom_khoa_tb = new System.Windows.Forms.TextBox();
            this.fnhom_chunhiem_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fnhom_add_bt = new System.Windows.Forms.Button();
            this.fnhom_cancel_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fnhom_name_tb
            // 
            this.fnhom_name_tb.Location = new System.Drawing.Point(145, 44);
            this.fnhom_name_tb.Name = "fnhom_name_tb";
            this.fnhom_name_tb.Size = new System.Drawing.Size(176, 20);
            this.fnhom_name_tb.TabIndex = 0;
            // 
            // fnhom_mail_tb
            // 
            this.fnhom_mail_tb.Location = new System.Drawing.Point(145, 116);
            this.fnhom_mail_tb.Name = "fnhom_mail_tb";
            this.fnhom_mail_tb.Size = new System.Drawing.Size(176, 20);
            this.fnhom_mail_tb.TabIndex = 1;
            // 
            // fnhom_khoa_tb
            // 
            this.fnhom_khoa_tb.Location = new System.Drawing.Point(510, 44);
            this.fnhom_khoa_tb.Name = "fnhom_khoa_tb";
            this.fnhom_khoa_tb.Size = new System.Drawing.Size(173, 20);
            this.fnhom_khoa_tb.TabIndex = 2;
            // 
            // fnhom_chunhiem_tb
            // 
            this.fnhom_chunhiem_tb.Location = new System.Drawing.Point(510, 116);
            this.fnhom_chunhiem_tb.Name = "fnhom_chunhiem_tb";
            this.fnhom_chunhiem_tb.Size = new System.Drawing.Size(173, 20);
            this.fnhom_chunhiem_tb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "tên nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "chủ nhiệm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "khóa";
            // 
            // fnhom_add_bt
            // 
            this.fnhom_add_bt.Location = new System.Drawing.Point(197, 199);
            this.fnhom_add_bt.Name = "fnhom_add_bt";
            this.fnhom_add_bt.Size = new System.Drawing.Size(75, 23);
            this.fnhom_add_bt.TabIndex = 8;
            this.fnhom_add_bt.Text = "add";
            this.fnhom_add_bt.UseVisualStyleBackColor = true;
            this.fnhom_add_bt.Click += new System.EventHandler(this.fnhom_add_bt_Click);
            // 
            // fnhom_cancel_bt
            // 
            this.fnhom_cancel_bt.Location = new System.Drawing.Point(495, 199);
            this.fnhom_cancel_bt.Name = "fnhom_cancel_bt";
            this.fnhom_cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.fnhom_cancel_bt.TabIndex = 9;
            this.fnhom_cancel_bt.Text = "cancel";
            this.fnhom_cancel_bt.UseVisualStyleBackColor = true;
            this.fnhom_cancel_bt.Click += new System.EventHandler(this.fnhom_cancel_bt_Click);
            // 
            // add_nhom_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fnhom_cancel_bt);
            this.Controls.Add(this.fnhom_add_bt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fnhom_chunhiem_tb);
            this.Controls.Add(this.fnhom_khoa_tb);
            this.Controls.Add(this.fnhom_mail_tb);
            this.Controls.Add(this.fnhom_name_tb);
            this.Name = "add_nhom_2";
            this.Text = "add_nhom_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnhom_name_tb;
        private System.Windows.Forms.TextBox fnhom_mail_tb;
        private System.Windows.Forms.TextBox fnhom_khoa_tb;
        private System.Windows.Forms.TextBox fnhom_chunhiem_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button fnhom_add_bt;
        private System.Windows.Forms.Button fnhom_cancel_bt;
    }
}