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
            this.f1_show_b = new System.Windows.Forms.Button();
            this.f1_add_b = new System.Windows.Forms.Button();
            this.f1_sort_b = new System.Windows.Forms.Button();
            this.f1_search_b = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // f1_show_b
            // 
            this.f1_show_b.Location = new System.Drawing.Point(37, 48);
            this.f1_show_b.Name = "f1_show_b";
            this.f1_show_b.Size = new System.Drawing.Size(75, 23);
            this.f1_show_b.TabIndex = 0;
            this.f1_show_b.Text = "show";
            this.f1_show_b.UseVisualStyleBackColor = true;
            this.f1_show_b.Click += new System.EventHandler(this.f1_show_b_Click);
            // 
            // f1_add_b
            // 
            this.f1_add_b.Location = new System.Drawing.Point(167, 48);
            this.f1_add_b.Name = "f1_add_b";
            this.f1_add_b.Size = new System.Drawing.Size(75, 23);
            this.f1_add_b.TabIndex = 1;
            this.f1_add_b.Text = "add ";
            this.f1_add_b.UseVisualStyleBackColor = true;
            this.f1_add_b.Click += new System.EventHandler(this.f1_add_b_Click);
            // 
            // f1_sort_b
            // 
            this.f1_sort_b.Location = new System.Drawing.Point(466, 48);
            this.f1_sort_b.Name = "f1_sort_b";
            this.f1_sort_b.Size = new System.Drawing.Size(75, 23);
            this.f1_sort_b.TabIndex = 2;
            this.f1_sort_b.Text = "sort";
            this.f1_sort_b.UseVisualStyleBackColor = true;
            // 
            // f1_search_b
            // 
            this.f1_search_b.Location = new System.Drawing.Point(663, 48);
            this.f1_search_b.Name = "f1_search_b";
            this.f1_search_b.Size = new System.Drawing.Size(75, 23);
            this.f1_search_b.TabIndex = 3;
            this.f1_search_b.Text = "search";
            this.f1_search_b.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 303);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.f1_search_b);
            this.Controls.Add(this.f1_sort_b);
            this.Controls.Add(this.f1_add_b);
            this.Controls.Add(this.f1_show_b);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button f1_show_b;
        private System.Windows.Forms.Button f1_add_b;
        private System.Windows.Forms.Button f1_sort_b;
        private System.Windows.Forms.Button f1_search_b;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

