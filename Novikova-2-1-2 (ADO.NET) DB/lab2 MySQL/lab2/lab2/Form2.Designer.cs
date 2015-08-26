namespace lab2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonGet = new System.Windows.Forms.RadioButton();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.richTextBoxID = new System.Windows.Forms.RichTextBox();
            this.richTextBoxName = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTime = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewDB = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Види послуг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Назва";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Час виконання ";
            // 
            // radioButtonGet
            // 
            this.radioButtonGet.AutoSize = true;
            this.radioButtonGet.Location = new System.Drawing.Point(90, 117);
            this.radioButtonGet.Name = "radioButtonGet";
            this.radioButtonGet.Size = new System.Drawing.Size(170, 17);
            this.radioButtonGet.TabIndex = 4;
            this.radioButtonGet.Text = "ОТРИМАННЯ ВСІХ ПОСЛУГ";
            this.radioButtonGet.UseVisualStyleBackColor = true;
            this.radioButtonGet.CheckedChanged += new System.EventHandler(this.radioButtonGet_CheckedChanged);
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Checked = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(90, 140);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(152, 17);
            this.radioButtonAdd.TabIndex = 5;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "ДОДАВАННЯ ПОСЛУГИ";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            this.radioButtonAdd.CheckedChanged += new System.EventHandler(this.radioButtonAdd_CheckedChanged);
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(91, 163);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(151, 17);
            this.radioButtonUpdate.TabIndex = 6;
            this.radioButtonUpdate.Text = "ОНОВЛЕННЯ ПОСЛУГИ";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            this.radioButtonUpdate.CheckedChanged += new System.EventHandler(this.radioButtonUpdate_CheckedChanged);
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(91, 186);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(151, 17);
            this.radioButtonDelete.TabIndex = 7;
            this.radioButtonDelete.Text = "ВИЛУЧЕННЯ ПОСЛУГИ";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            this.radioButtonDelete.CheckedChanged += new System.EventHandler(this.radioButtonDelete_CheckedChanged);
            // 
            // richTextBoxID
            // 
            this.richTextBoxID.Location = new System.Drawing.Point(72, 235);
            this.richTextBoxID.Name = "richTextBoxID";
            this.richTextBoxID.Size = new System.Drawing.Size(55, 25);
            this.richTextBoxID.TabIndex = 8;
            this.richTextBoxID.Text = "";
            // 
            // richTextBoxName
            // 
            this.richTextBoxName.Location = new System.Drawing.Point(166, 235);
            this.richTextBoxName.Name = "richTextBoxName";
            this.richTextBoxName.Size = new System.Drawing.Size(140, 25);
            this.richTextBoxName.TabIndex = 9;
            this.richTextBoxName.Text = "";
            this.richTextBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.richTextBoxName_Validating);
            // 
            // richTextBoxTime
            // 
            this.richTextBoxTime.Location = new System.Drawing.Point(333, 235);
            this.richTextBoxTime.Name = "richTextBoxTime";
            this.richTextBoxTime.Size = new System.Drawing.Size(55, 25);
            this.richTextBoxTime.TabIndex = 10;
            this.richTextBoxTime.Text = "";
            this.richTextBoxTime.Validating += new System.ComponentModel.CancelEventHandler(this.richTextBoxTime_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "ВИКОНАТИ ЗАПИТ ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "НАЗАД ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Результат останього запиту:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewDB
            // 
            this.dataGridViewDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDB.Location = new System.Drawing.Point(248, 304);
            this.dataGridViewDB.Name = "dataGridViewDB";
            this.dataGridViewDB.Size = new System.Drawing.Size(454, 150);
            this.dataGridViewDB.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 466);
            this.Controls.Add(this.dataGridViewDB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxTime);
            this.Controls.Add(this.richTextBoxName);
            this.Controls.Add(this.richTextBoxID);
            this.Controls.Add(this.radioButtonDelete);
            this.Controls.Add(this.radioButtonUpdate);
            this.Controls.Add(this.radioButtonAdd);
            this.Controls.Add(this.radioButtonGet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonGet;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RichTextBox richTextBoxID;
        private System.Windows.Forms.RichTextBox richTextBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewDB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}