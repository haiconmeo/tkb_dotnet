namespace lapTKB
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.f1_show_b = new System.Windows.Forms.Button();
            this.f1_quanly_b = new System.Windows.Forms.Button();
            this.f1_sort_b = new System.Windows.Forms.Button();
            this.f1_search_b = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.f1_exit_bt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.f1_in_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // f1_show_b
            // 
            this.f1_show_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f1_show_b.BackgroundImage")));
            this.f1_show_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.f1_show_b.Location = new System.Drawing.Point(47, 121);
            this.f1_show_b.Name = "f1_show_b";
            this.f1_show_b.Size = new System.Drawing.Size(51, 50);
            this.f1_show_b.TabIndex = 0;
            this.f1_show_b.UseVisualStyleBackColor = true;
            this.f1_show_b.Click += new System.EventHandler(this.f1_show_b_Click);
            // 
            // f1_quanly_b
            // 
            this.f1_quanly_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f1_quanly_b.BackgroundImage")));
            this.f1_quanly_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.f1_quanly_b.Location = new System.Drawing.Point(199, 121);
            this.f1_quanly_b.Name = "f1_quanly_b";
            this.f1_quanly_b.Size = new System.Drawing.Size(56, 50);
            this.f1_quanly_b.TabIndex = 1;
            this.f1_quanly_b.UseVisualStyleBackColor = true;
            this.f1_quanly_b.Click += new System.EventHandler(this.f1_add_b_Click);
            // 
            // f1_sort_b
            // 
            this.f1_sort_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f1_sort_b.BackgroundImage")));
            this.f1_sort_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.f1_sort_b.Location = new System.Drawing.Point(199, 202);
            this.f1_sort_b.Name = "f1_sort_b";
            this.f1_sort_b.Size = new System.Drawing.Size(56, 43);
            this.f1_sort_b.TabIndex = 2;
            this.f1_sort_b.UseVisualStyleBackColor = true;
            this.f1_sort_b.Click += new System.EventHandler(this.f1_sort_b_Click);
            // 
            // f1_search_b
            // 
            this.f1_search_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f1_search_b.BackgroundImage")));
            this.f1_search_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.f1_search_b.Location = new System.Drawing.Point(47, 202);
            this.f1_search_b.Name = "f1_search_b";
            this.f1_search_b.Size = new System.Drawing.Size(51, 43);
            this.f1_search_b.TabIndex = 3;
            this.f1_search_b.UseVisualStyleBackColor = true;
            this.f1_search_b.Click += new System.EventHandler(this.f1_search_b_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 475);
            this.dataGridView1.TabIndex = 4;
            // 
            // f1_exit_bt
            // 
            this.f1_exit_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f1_exit_bt.BackgroundImage")));
            this.f1_exit_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.f1_exit_bt.Location = new System.Drawing.Point(199, 284);
            this.f1_exit_bt.Name = "f1_exit_bt";
            this.f1_exit_bt.Size = new System.Drawing.Size(56, 45);
            this.f1_exit_bt.TabIndex = 5;
            this.f1_exit_bt.UseVisualStyleBackColor = true;
            this.f1_exit_bt.Click += new System.EventHandler(this.f1_exit_bt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 69);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // f1_in_bt
            // 
            this.f1_in_bt.AutoSize = true;
            this.f1_in_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f1_in_bt.BackgroundImage")));
            this.f1_in_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.f1_in_bt.Location = new System.Drawing.Point(47, 286);
            this.f1_in_bt.Name = "f1_in_bt";
            this.f1_in_bt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.f1_in_bt.Size = new System.Drawing.Size(51, 43);
            this.f1_in_bt.TabIndex = 7;
            this.f1_in_bt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.f1_in_bt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.f1_exit_bt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.f1_search_b);
            this.Controls.Add(this.f1_sort_b);
            this.Controls.Add(this.f1_quanly_b);
            this.Controls.Add(this.f1_show_b);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button f1_show_b;
        private System.Windows.Forms.Button f1_quanly_b;
        private System.Windows.Forms.Button f1_sort_b;
        private System.Windows.Forms.Button f1_search_b;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button f1_exit_bt;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button f1_in_bt;
    }
}

