﻿
namespace EntityExample
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnJoinGrade = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtSituation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExam3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtExam2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtExam1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGradeList = new System.Windows.Forms.Button();
            this.btnClassList = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnProcedure = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnLinqEntity = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(866, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(0, 200);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(89, 23);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(0, 313);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(0, 285);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(0, 258);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtImage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLastname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(105, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 158);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(109, 133);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(100, 22);
            this.txtImage.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Image:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(109, 102);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 22);
            this.txtLastname.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Lastname:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(109, 69);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 22);
            this.txtFirstname.TabIndex = 17;
            this.txtFirstname.TextChanged += new System.EventHandler(this.txtFirstname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Firstname:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(109, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtClassName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtClassID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(349, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 109);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Class";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(109, 69);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(100, 22);
            this.txtClassName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Name:";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(109, 38);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(100, 22);
            this.txtClassID.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnJoinGrade);
            this.groupBox3.Controls.Add(this.btnCalculate);
            this.groupBox3.Controls.Add(this.txtSituation);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtAverage);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtExam3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtExam2);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtExam1);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(617, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 243);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grade";
            // 
            // btnJoinGrade
            // 
            this.btnJoinGrade.Location = new System.Drawing.Point(124, 200);
            this.btnJoinGrade.Name = "btnJoinGrade";
            this.btnJoinGrade.Size = new System.Drawing.Size(75, 23);
            this.btnJoinGrade.TabIndex = 23;
            this.btnJoinGrade.Text = "Join";
            this.btnJoinGrade.UseVisualStyleBackColor = true;
            this.btnJoinGrade.Click += new System.EventHandler(this.btnJoinGrade_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 200);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 24;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // txtSituation
            // 
            this.txtSituation.Location = new System.Drawing.Point(109, 164);
            this.txtSituation.Name = "txtSituation";
            this.txtSituation.Size = new System.Drawing.Size(100, 22);
            this.txtSituation.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Situation:";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(109, 133);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(100, 22);
            this.txtAverage.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Average:";
            // 
            // txtExam3
            // 
            this.txtExam3.Location = new System.Drawing.Point(109, 102);
            this.txtExam3.Name = "txtExam3";
            this.txtExam3.Size = new System.Drawing.Size(100, 22);
            this.txtExam3.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Exam3:";
            // 
            // txtExam2
            // 
            this.txtExam2.Location = new System.Drawing.Point(109, 69);
            this.txtExam2.Name = "txtExam2";
            this.txtExam2.Size = new System.Drawing.Size(100, 22);
            this.txtExam2.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Exam2:";
            // 
            // txtExam1
            // 
            this.txtExam1.Location = new System.Drawing.Point(109, 38);
            this.txtExam1.Name = "txtExam1";
            this.txtExam1.Size = new System.Drawing.Size(100, 22);
            this.txtExam1.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Exam1:";
            // 
            // btnGradeList
            // 
            this.btnGradeList.Location = new System.Drawing.Point(0, 400);
            this.btnGradeList.Name = "btnGradeList";
            this.btnGradeList.Size = new System.Drawing.Size(89, 23);
            this.btnGradeList.TabIndex = 23;
            this.btnGradeList.Text = "Grade List";
            this.btnGradeList.UseVisualStyleBackColor = true;
            this.btnGradeList.Click += new System.EventHandler(this.btnGradeList_Click);
            // 
            // btnClassList
            // 
            this.btnClassList.Location = new System.Drawing.Point(0, 342);
            this.btnClassList.Name = "btnClassList";
            this.btnClassList.Size = new System.Drawing.Size(89, 23);
            this.btnClassList.TabIndex = 24;
            this.btnClassList.Text = "Class List";
            this.btnClassList.UseVisualStyleBackColor = true;
            this.btnClassList.Click += new System.EventHandler(this.btnClassList_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(0, 371);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(89, 23);
            this.btnAddClass.TabIndex = 25;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnProcedure
            // 
            this.btnProcedure.Location = new System.Drawing.Point(0, 429);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(89, 23);
            this.btnProcedure.TabIndex = 26;
            this.btnProcedure.Text = "Procedure";
            this.btnProcedure.UseVisualStyleBackColor = true;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(891, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(148, 20);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sort by Name(A-->Z)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnLinqEntity
            // 
            this.btnLinqEntity.Location = new System.Drawing.Point(891, 391);
            this.btnLinqEntity.Name = "btnLinqEntity";
            this.btnLinqEntity.Size = new System.Drawing.Size(94, 32);
            this.btnLinqEntity.TabIndex = 28;
            this.btnLinqEntity.Text = "Linq Entity";
            this.btnLinqEntity.UseVisualStyleBackColor = true;
            this.btnLinqEntity.Click += new System.EventHandler(this.btnLinqEntity_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(991, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 29;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(891, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(148, 20);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sort by Name(Z-->A)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(891, 64);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 20);
            this.radioButton3.TabIndex = 31;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "First Three";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(891, 90);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(91, 20);
            this.radioButton4.TabIndex = 32;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Sort with ID";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(890, 116);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(97, 20);
            this.radioButton5.TabIndex = 33;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Starts with A";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(891, 142);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(136, 20);
            this.radioButton6.TabIndex = 34;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Information Control\r\n";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(890, 168);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(141, 20);
            this.radioButton7.TabIndex = 35;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Worst Grade to Fail";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1052, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "label6";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(890, 194);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(108, 20);
            this.radioButton8.TabIndex = 37;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Best Average";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1052, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "label13";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 455);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLinqEntity);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnProcedure);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.btnClassList);
            this.Controls.Add(this.btnGradeList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtExam3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtExam2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtExam1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnJoinGrade;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtSituation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGradeList;
        private System.Windows.Forms.Button btnClassList;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnProcedure;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnLinqEntity;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label label13;
    }
}

