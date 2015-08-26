namespace tcp_client
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
            this.b1 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(33, 63);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(128, 48);
            this.b1.TabIndex = 0;
            this.b1.Text = "Get request #1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(223, 36);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(190, 20);
            this.tb1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(223, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(292, 212);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // b2
            // 
            this.b2.Enabled = false;
            this.b2.Location = new System.Drawing.Point(33, 133);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(128, 44);
            this.b2.TabIndex = 3;
            this.b2.Text = "Get request #2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(33, 202);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(128, 44);
            this.b3.TabIndex = 4;
            this.b3.Text = "Exit";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 355);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
    }
}

