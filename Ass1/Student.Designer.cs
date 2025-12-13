namespace Ass1
{
    partial class Student
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Student Management System";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(581, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(673, 292);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(613, 442);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(141, 153);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(435, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 153);
            this.button3.TabIndex = 16;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 153);
            this.button2.TabIndex = 15;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 153);
            this.button1.TabIndex = 14;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(341, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 34);
            this.textBox2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Roll_No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(339, 180);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 34);
            this.textBox3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "Course";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 29);
            this.label8.TabIndex = 24;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "Mobile";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 29);
            this.label10.TabIndex = 26;
            this.label10.Text = "Dob";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(339, 226);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(171, 37);
            this.comboBoxClass.TabIndex = 27;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(341, 275);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(121, 37);
            this.comboBoxCourse.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enrollment_No";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 34);
            this.textBox1.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(330, 318);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 34);
            this.textBox4.TabIndex = 29;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(330, 357);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 34);
            this.textBox5.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 391);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 34);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 745);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Student";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}