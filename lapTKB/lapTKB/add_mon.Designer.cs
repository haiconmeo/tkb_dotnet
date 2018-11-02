namespace lapTKB
{
    partial class add_mon
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
            this.f6_tenmon_tb = new System.Windows.Forms.TextBox();
            this.f6_sotiet_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.f6_show_bt = new System.Windows.Forms.Button();
            this.f6_add_bt = new System.Windows.Forms.Button();
            this.f6_delete_bt = new System.Windows.Forms.Button();
            this.f6_update_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiết";
            // 
            // f6_tenmon_tb
            // 
            this.f6_tenmon_tb.Location = new System.Drawing.Point(145, 49);
            this.f6_tenmon_tb.Name = "f6_tenmon_tb";
            this.f6_tenmon_tb.Size = new System.Drawing.Size(142, 20);
            this.f6_tenmon_tb.TabIndex = 3;
            // 
            // f6_sotiet_tb
            // 
            this.f6_sotiet_tb.Location = new System.Drawing.Point(145, 112);
            this.f6_sotiet_tb.Name = "f6_sotiet_tb";
            this.f6_sotiet_tb.Size = new System.Drawing.Size(142, 20);
            this.f6_sotiet_tb.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // f6_show_bt
            // 
            this.f6_show_bt.Location = new System.Drawing.Point(74, 203);
            this.f6_show_bt.Name = "f6_show_bt";
            this.f6_show_bt.Size = new System.Drawing.Size(75, 23);
            this.f6_show_bt.TabIndex = 7;
            this.f6_show_bt.Text = "show";
            this.f6_show_bt.UseVisualStyleBackColor = true;
            this.f6_show_bt.Click += new System.EventHandler(this.f6_show_bt_Click);
            // 
            // f6_add_bt
            // 
            this.f6_add_bt.Location = new System.Drawing.Point(221, 203);
            this.f6_add_bt.Name = "f6_add_bt";
            this.f6_add_bt.Size = new System.Drawing.Size(75, 23);
            this.f6_add_bt.TabIndex = 8;
            this.f6_add_bt.Text = "add";
            this.f6_add_bt.UseVisualStyleBackColor = true;
            this.f6_add_bt.Click += new System.EventHandler(this.f6_add_bt_Click);
            // 
            // f6_delete_bt
            // 
            this.f6_delete_bt.Location = new System.Drawing.Point(385, 203);
            this.f6_delete_bt.Name = "f6_delete_bt";
            this.f6_delete_bt.Size = new System.Drawing.Size(75, 23);
            this.f6_delete_bt.TabIndex = 9;
            this.f6_delete_bt.Text = "delete";
            this.f6_delete_bt.UseVisualStyleBackColor = true;
            this.f6_delete_bt.Click += new System.EventHandler(this.f6_delete_bt_Click);
            // 
            // f6_update_bt
            // 
            this.f6_update_bt.Location = new System.Drawing.Point(566, 203);
            this.f6_update_bt.Name = "f6_update_bt";
            this.f6_update_bt.Size = new System.Drawing.Size(75, 23);
            this.f6_update_bt.TabIndex = 10;
            this.f6_update_bt.Text = "update";
            this.f6_update_bt.UseVisualStyleBackColor = true;
            this.f6_update_bt.Click += new System.EventHandler(this.f6_update_bt_Click);
            // 
            // add_mon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.f6_update_bt);
            this.Controls.Add(this.f6_delete_bt);
            this.Controls.Add(this.f6_add_bt);
            this.Controls.Add(this.f6_show_bt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.f6_sotiet_tb);
            this.Controls.Add(this.f6_tenmon_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_mon";
            this.Text = "add_mon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox f6_tenmon_tb;
        private System.Windows.Forms.TextBox f6_sotiet_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button f6_show_bt;
        private System.Windows.Forms.Button f6_add_bt;
        private System.Windows.Forms.Button f6_delete_bt;
        private System.Windows.Forms.Button f6_update_bt;
    }
}