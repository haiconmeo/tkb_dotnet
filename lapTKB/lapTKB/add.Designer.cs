namespace lapTKB
{
    partial class add
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
            this.f3_addgv_b = new System.Windows.Forms.Button();
            this.f3_nhom_b = new System.Windows.Forms.Button();
            this.f3_mon_b = new System.Windows.Forms.Button();
            this.f3_phancong_b = new System.Windows.Forms.Button();
            this.f3_phong_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // f3_addgv_b
            // 
            this.f3_addgv_b.Location = new System.Drawing.Point(273, 32);
            this.f3_addgv_b.Name = "f3_addgv_b";
            this.f3_addgv_b.Size = new System.Drawing.Size(153, 58);
            this.f3_addgv_b.TabIndex = 0;
            this.f3_addgv_b.Text = "Giáo Viên";
            this.f3_addgv_b.UseVisualStyleBackColor = true;
            this.f3_addgv_b.Click += new System.EventHandler(this.f3_addgv_b_Click);
            // 
            // f3_nhom_b
            // 
            this.f3_nhom_b.Location = new System.Drawing.Point(273, 118);
            this.f3_nhom_b.Name = "f3_nhom_b";
            this.f3_nhom_b.Size = new System.Drawing.Size(153, 54);
            this.f3_nhom_b.TabIndex = 1;
            this.f3_nhom_b.Text = "Nhóm ";
            this.f3_nhom_b.UseVisualStyleBackColor = true;
            this.f3_nhom_b.Click += new System.EventHandler(this.f3_nhom_b_Click);
            // 
            // f3_mon_b
            // 
            this.f3_mon_b.Location = new System.Drawing.Point(273, 217);
            this.f3_mon_b.Name = "f3_mon_b";
            this.f3_mon_b.Size = new System.Drawing.Size(153, 50);
            this.f3_mon_b.TabIndex = 2;
            this.f3_mon_b.Text = "Môn";
            this.f3_mon_b.UseVisualStyleBackColor = true;
            this.f3_mon_b.Click += new System.EventHandler(this.f3_mon_b_Click);
            // 
            // f3_phancong_b
            // 
            this.f3_phancong_b.Location = new System.Drawing.Point(273, 389);
            this.f3_phancong_b.Name = "f3_phancong_b";
            this.f3_phancong_b.Size = new System.Drawing.Size(153, 49);
            this.f3_phancong_b.TabIndex = 3;
            this.f3_phancong_b.Text = "Phân công";
            this.f3_phancong_b.UseVisualStyleBackColor = true;
            this.f3_phancong_b.Click += new System.EventHandler(this.f3_phancong_b_Click);
            // 
            // f3_phong_bt
            // 
            this.f3_phong_bt.Location = new System.Drawing.Point(273, 303);
            this.f3_phong_bt.Name = "f3_phong_bt";
            this.f3_phong_bt.Size = new System.Drawing.Size(153, 51);
            this.f3_phong_bt.TabIndex = 4;
            this.f3_phong_bt.Text = "phòng";
            this.f3_phong_bt.UseVisualStyleBackColor = true;
            this.f3_phong_bt.Click += new System.EventHandler(this.f3_phong_bt_Click);
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.f3_phong_bt);
            this.Controls.Add(this.f3_phancong_b);
            this.Controls.Add(this.f3_mon_b);
            this.Controls.Add(this.f3_nhom_b);
            this.Controls.Add(this.f3_addgv_b);
            this.Name = "add";
            this.Text = "add";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button f3_addgv_b;
        private System.Windows.Forms.Button f3_nhom_b;
        private System.Windows.Forms.Button f3_mon_b;
        private System.Windows.Forms.Button f3_phancong_b;
        private System.Windows.Forms.Button f3_phong_bt;
    }
}