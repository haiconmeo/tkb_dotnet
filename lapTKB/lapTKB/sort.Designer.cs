namespace lapTKB
{
    partial class sort
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
            this.fs_check_cbb = new System.Windows.Forms.ComboBox();
            this.fs_sort_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "sắp theo ";
            // 
            // fs_check_cbb
            // 
            this.fs_check_cbb.FormattingEnabled = true;
            this.fs_check_cbb.Items.AddRange(new object[] {
            "giáo viên",
            "học phần",
            "nhóm",
            "phòng"});
            this.fs_check_cbb.Location = new System.Drawing.Point(162, 65);
            this.fs_check_cbb.Name = "fs_check_cbb";
            this.fs_check_cbb.Size = new System.Drawing.Size(181, 21);
            this.fs_check_cbb.TabIndex = 1;
            // 
            // fs_sort_bt
            // 
            this.fs_sort_bt.Location = new System.Drawing.Point(110, 141);
            this.fs_sort_bt.Name = "fs_sort_bt";
            this.fs_sort_bt.Size = new System.Drawing.Size(201, 46);
            this.fs_sort_bt.TabIndex = 2;
            this.fs_sort_bt.Text = "sort";
            this.fs_sort_bt.UseVisualStyleBackColor = true;
            this.fs_sort_bt.Click += new System.EventHandler(this.fs_sort_bt_Click);
            // 
            // sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 244);
            this.Controls.Add(this.fs_sort_bt);
            this.Controls.Add(this.fs_check_cbb);
            this.Controls.Add(this.label1);
            this.Name = "sort";
            this.Text = "sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fs_check_cbb;
        private System.Windows.Forms.Button fs_sort_bt;
    }
}