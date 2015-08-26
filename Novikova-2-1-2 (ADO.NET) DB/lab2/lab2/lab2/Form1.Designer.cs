namespace lab2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonGet = new System.Windows.Forms.RadioButton();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.checkBoxPoslug = new System.Windows.Forms.CheckBox();
            this.checkBoxID = new System.Windows.Forms.CheckBox();
            this.richTextBoxID = new System.Windows.Forms.RichTextBox();
            this.richTextBoxName = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMName = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLName = new System.Windows.Forms.RichTextBox();
            this.richTextBoxYear = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.label1.Location = new System.Drawing.Point(195, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фахівці салону";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "ВИКОНАТИ ЗАПИТ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonGet
            // 
            this.radioButtonGet.AutoSize = true;
            this.radioButtonGet.Location = new System.Drawing.Point(68, 141);
            this.radioButtonGet.Name = "radioButtonGet";
            this.radioButtonGet.Size = new System.Drawing.Size(151, 17);
            this.radioButtonGet.TabIndex = 7;
            this.radioButtonGet.Text = "ОТРИМАННЯ ФАХІВЦІВ";
            this.radioButtonGet.UseVisualStyleBackColor = true;
            this.radioButtonGet.CheckedChanged += new System.EventHandler(this.radioButtonGet_CheckedChanged);
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Checked = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(68, 164);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(150, 17);
            this.radioButtonAdd.TabIndex = 8;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "ДОДАВАННЯ ФАХІВЦЯ";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            this.radioButtonAdd.CheckedChanged += new System.EventHandler(this.radioButtonAdd_CheckedChanged);
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(68, 187);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(149, 17);
            this.radioButtonUpdate.TabIndex = 9;
            this.radioButtonUpdate.Text = "ОНОВЛЕННЯ ФАХІВЦЯ";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            this.radioButtonUpdate.CheckedChanged += new System.EventHandler(this.radioButtonUpdate_CheckedChanged);
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(68, 210);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(149, 17);
            this.radioButtonDelete.TabIndex = 10;
            this.radioButtonDelete.Text = "ВИЛУЧЕННЯ ФАХІВЦЯ";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            this.radioButtonDelete.CheckedChanged += new System.EventHandler(this.radioButtonDelete_CheckedChanged);
            // 
            // checkBoxPoslug
            // 
            this.checkBoxPoslug.AutoSize = true;
            this.checkBoxPoslug.Enabled = false;
            this.checkBoxPoslug.Location = new System.Drawing.Point(223, 89);
            this.checkBoxPoslug.Name = "checkBoxPoslug";
            this.checkBoxPoslug.Size = new System.Drawing.Size(95, 17);
            this.checkBoxPoslug.TabIndex = 11;
            this.checkBoxPoslug.Text = "за послугою  ";
            this.checkBoxPoslug.UseVisualStyleBackColor = true;
            this.checkBoxPoslug.CheckedChanged += new System.EventHandler(this.checkBoxPoslug_CheckedChanged);
            // 
            // checkBoxID
            // 
            this.checkBoxID.AutoSize = true;
            this.checkBoxID.Enabled = false;
            this.checkBoxID.Location = new System.Drawing.Point(324, 89);
            this.checkBoxID.Name = "checkBoxID";
            this.checkBoxID.Size = new System.Drawing.Size(97, 17);
            this.checkBoxID.TabIndex = 12;
            this.checkBoxID.Text = "за ID фахівця ";
            this.checkBoxID.UseVisualStyleBackColor = true;
            this.checkBoxID.CheckedChanged += new System.EventHandler(this.checkBoxID_CheckedChanged);
            // 
            // richTextBoxID
            // 
            this.richTextBoxID.Location = new System.Drawing.Point(68, 259);
            this.richTextBoxID.Name = "richTextBoxID";
            this.richTextBoxID.Size = new System.Drawing.Size(62, 17);
            this.richTextBoxID.TabIndex = 13;
            this.richTextBoxID.Text = "";
            // 
            // richTextBoxName
            // 
            this.richTextBoxName.Location = new System.Drawing.Point(154, 259);
            this.richTextBoxName.Name = "richTextBoxName";
            this.richTextBoxName.Size = new System.Drawing.Size(92, 17);
            this.richTextBoxName.TabIndex = 14;
            this.richTextBoxName.Text = "";
            this.richTextBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.richTextBoxName_Validating);
            // 
            // richTextBoxMName
            // 
            this.richTextBoxMName.Location = new System.Drawing.Point(265, 259);
            this.richTextBoxMName.Name = "richTextBoxMName";
            this.richTextBoxMName.Size = new System.Drawing.Size(118, 17);
            this.richTextBoxMName.TabIndex = 15;
            this.richTextBoxMName.Text = "";
            this.richTextBoxMName.Validating += new System.ComponentModel.CancelEventHandler(this.richTextBoxMName_Validating);
            // 
            // richTextBoxLName
            // 
            this.richTextBoxLName.Location = new System.Drawing.Point(401, 259);
            this.richTextBoxLName.Name = "richTextBoxLName";
            this.richTextBoxLName.Size = new System.Drawing.Size(120, 17);
            this.richTextBoxLName.TabIndex = 16;
            this.richTextBoxLName.Text = "";
            this.richTextBoxLName.Validating += new System.ComponentModel.CancelEventHandler(this.richTextBoxLName_Validating);
            // 
            // richTextBoxYear
            // 
            this.richTextBoxYear.Location = new System.Drawing.Point(542, 259);
            this.richTextBoxYear.Name = "richTextBoxYear";
            this.richTextBoxYear.Size = new System.Drawing.Size(70, 17);
            this.richTextBoxYear.TabIndex = 17;
            this.richTextBoxYear.Text = "";
            this.richTextBoxYear.Validating += new System.ComponentModel.CancelEventHandler(this.richTextBoxYear_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ім\'я";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "По-батькові";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Прізвище";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Рік працевлаштування  ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(685, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Послуга";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "ПОСЛУГИ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Результат останього запиту:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(652, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // dataGridViewDB
            // 
            this.dataGridViewDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDB.Location = new System.Drawing.Point(198, 304);
            this.dataGridViewDB.Name = "dataGridViewDB";
            this.dataGridViewDB.Size = new System.Drawing.Size(558, 150);
            this.dataGridViewDB.TabIndex = 29;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 466);
            this.Controls.Add(this.dataGridViewDB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxYear);
            this.Controls.Add(this.richTextBoxLName);
            this.Controls.Add(this.richTextBoxMName);
            this.Controls.Add(this.richTextBoxName);
            this.Controls.Add(this.richTextBoxID);
            this.Controls.Add(this.checkBoxID);
            this.Controls.Add(this.checkBoxPoslug);
            this.Controls.Add(this.radioButtonDelete);
            this.Controls.Add(this.radioButtonUpdate);
            this.Controls.Add(this.radioButtonAdd);
            this.Controls.Add(this.radioButtonGet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonGet;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.CheckBox checkBoxPoslug;
        private System.Windows.Forms.CheckBox checkBoxID;
        private System.Windows.Forms.RichTextBox richTextBoxID;
        private System.Windows.Forms.RichTextBox richTextBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxMName;
        private System.Windows.Forms.RichTextBox richTextBoxLName;
        private System.Windows.Forms.RichTextBox richTextBoxYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridViewDB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

