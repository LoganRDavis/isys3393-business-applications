namespace project4
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.newStudentName = new System.Windows.Forms.TextBox();
            this.newStudentAdd = new System.Windows.Forms.Button();
            this.newStudentMajor = new System.Windows.Forms.ComboBox();
            this.newStudentCollege = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tblStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradePanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gradesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newGradeAdd = new System.Windows.Forms.Button();
            this.newGradeTerm = new System.Windows.Forms.ComboBox();
            this.newGradeGrade = new System.Windows.Forms.ComboBox();
            this.newGradeCourse = new System.Windows.Forms.ComboBox();
            this.newGradeStudent = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradesLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).BeginInit();
            this.gradePanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = global::project4.Properties.Resources.OldMain;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(620, 521);
            this.mainPanel.TabIndex = 1;
            // 
            // studentPanel
            // 
            this.studentPanel.Controls.Add(this.groupBox3);
            this.studentPanel.Controls.Add(this.groupBox4);
            this.studentPanel.Controls.Add(this.label9);
            this.studentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentPanel.Location = new System.Drawing.Point(0, 0);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(620, 521);
            this.studentPanel.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.studentDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(22, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 324);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Students";
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AllowUserToAddRows = false;
            this.studentDataGridView.AllowUserToDeleteRows = false;
            this.studentDataGridView.AllowUserToResizeColumns = false;
            this.studentDataGridView.AllowUserToResizeRows = false;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentDataGridView.Location = new System.Drawing.Point(3, 18);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.RowHeadersWidth = 51;
            this.studentDataGridView.RowTemplate.Height = 24;
            this.studentDataGridView.Size = new System.Drawing.Size(576, 303);
            this.studentDataGridView.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.newStudentName);
            this.groupBox4.Controls.Add(this.newStudentAdd);
            this.groupBox4.Controls.Add(this.newStudentMajor);
            this.groupBox4.Controls.Add(this.newStudentCollege);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(22, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(582, 114);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Student";
            // 
            // newStudentName
            // 
            this.newStudentName.Location = new System.Drawing.Point(78, 30);
            this.newStudentName.Name = "newStudentName";
            this.newStudentName.Size = new System.Drawing.Size(185, 22);
            this.newStudentName.TabIndex = 9;
            // 
            // newStudentAdd
            // 
            this.newStudentAdd.Location = new System.Drawing.Point(486, 65);
            this.newStudentAdd.Name = "newStudentAdd";
            this.newStudentAdd.Size = new System.Drawing.Size(81, 26);
            this.newStudentAdd.TabIndex = 8;
            this.newStudentAdd.Text = "Add";
            this.newStudentAdd.UseVisualStyleBackColor = true;
            this.newStudentAdd.Click += new System.EventHandler(this.NewStudentAdd_Click);
            // 
            // newStudentMajor
            // 
            this.newStudentMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newStudentMajor.FormattingEnabled = true;
            this.newStudentMajor.Location = new System.Drawing.Point(326, 30);
            this.newStudentMajor.Name = "newStudentMajor";
            this.newStudentMajor.Size = new System.Drawing.Size(241, 24);
            this.newStudentMajor.TabIndex = 6;
            // 
            // newStudentCollege
            // 
            this.newStudentCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newStudentCollege.FormattingEnabled = true;
            this.newStudentCollege.Location = new System.Drawing.Point(78, 66);
            this.newStudentCollege.Name = "newStudentCollege";
            this.newStudentCollege.Size = new System.Drawing.Size(391, 24);
            this.newStudentCollege.TabIndex = 5;
            this.newStudentCollege.SelectedIndexChanged += new System.EventHandler(this.NewStudentCollege_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Major";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "College";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 31);
            this.label9.TabIndex = 3;
            this.label9.Text = "Students";
            // 
            // tblStudentsBindingSource
            // 
            this.tblStudentsBindingSource.DataMember = "tbl_Students";
            // 
            // gradePanel
            // 
            this.gradePanel.Controls.Add(this.groupBox2);
            this.gradePanel.Controls.Add(this.groupBox1);
            this.gradePanel.Controls.Add(this.gradesLabel);
            this.gradePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradePanel.Location = new System.Drawing.Point(0, 0);
            this.gradePanel.Name = "gradePanel";
            this.gradePanel.Size = new System.Drawing.Size(620, 521);
            this.gradePanel.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gradesDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(22, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 324);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grades";
            // 
            // gradesDataGridView
            // 
            this.gradesDataGridView.AllowUserToAddRows = false;
            this.gradesDataGridView.AllowUserToDeleteRows = false;
            this.gradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradesDataGridView.Location = new System.Drawing.Point(3, 18);
            this.gradesDataGridView.Name = "gradesDataGridView";
            this.gradesDataGridView.RowHeadersWidth = 51;
            this.gradesDataGridView.RowTemplate.Height = 24;
            this.gradesDataGridView.Size = new System.Drawing.Size(576, 303);
            this.gradesDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newGradeAdd);
            this.groupBox1.Controls.Add(this.newGradeTerm);
            this.groupBox1.Controls.Add(this.newGradeGrade);
            this.groupBox1.Controls.Add(this.newGradeCourse);
            this.groupBox1.Controls.Add(this.newGradeStudent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Grade";
            // 
            // newGradeAdd
            // 
            this.newGradeAdd.Location = new System.Drawing.Point(490, 24);
            this.newGradeAdd.Name = "newGradeAdd";
            this.newGradeAdd.Size = new System.Drawing.Size(81, 66);
            this.newGradeAdd.TabIndex = 8;
            this.newGradeAdd.Text = "Add Grade";
            this.newGradeAdd.UseVisualStyleBackColor = true;
            this.newGradeAdd.Click += new System.EventHandler(this.NewGradeAdd_Click);
            // 
            // newGradeTerm
            // 
            this.newGradeTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newGradeTerm.FormattingEnabled = true;
            this.newGradeTerm.Location = new System.Drawing.Point(363, 66);
            this.newGradeTerm.Name = "newGradeTerm";
            this.newGradeTerm.Size = new System.Drawing.Size(110, 24);
            this.newGradeTerm.TabIndex = 7;
            // 
            // newGradeGrade
            // 
            this.newGradeGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newGradeGrade.FormattingEnabled = true;
            this.newGradeGrade.Location = new System.Drawing.Point(363, 24);
            this.newGradeGrade.Name = "newGradeGrade";
            this.newGradeGrade.Size = new System.Drawing.Size(110, 24);
            this.newGradeGrade.TabIndex = 6;
            // 
            // newGradeCourse
            // 
            this.newGradeCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newGradeCourse.FormattingEnabled = true;
            this.newGradeCourse.Location = new System.Drawing.Point(78, 66);
            this.newGradeCourse.Name = "newGradeCourse";
            this.newGradeCourse.Size = new System.Drawing.Size(185, 24);
            this.newGradeCourse.TabIndex = 5;
            // 
            // newGradeStudent
            // 
            this.newGradeStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newGradeStudent.FormattingEnabled = true;
            this.newGradeStudent.Location = new System.Drawing.Point(78, 28);
            this.newGradeStudent.Name = "newGradeStudent";
            this.newGradeStudent.Size = new System.Drawing.Size(185, 24);
            this.newGradeStudent.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Term";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // gradesLabel
            // 
            this.gradesLabel.AutoSize = true;
            this.gradesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradesLabel.Location = new System.Drawing.Point(16, 30);
            this.gradesLabel.Name = "gradesLabel";
            this.gradesLabel.Size = new System.Drawing.Size(109, 31);
            this.gradesLabel.TabIndex = 0;
            this.gradesLabel.Text = "Grades";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.gradesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.MainMenuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.StudentsToolStripMenuItem_Click);
            // 
            // gradesToolStripMenuItem
            // 
            this.gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            this.gradesToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.gradesToolStripMenuItem.Text = "Grades";
            this.gradesToolStripMenuItem.Click += new System.EventHandler(this.GradesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 521);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gradePanel);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.mainPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).EndInit();
            this.gradePanel.ResumeLayout(false);
            this.gradePanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel studentPanel;
        private System.Windows.Forms.Panel gradePanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gradesLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newGradeAdd;
        private System.Windows.Forms.ComboBox newGradeTerm;
        private System.Windows.Forms.ComboBox newGradeGrade;
        private System.Windows.Forms.ComboBox newGradeCourse;
        private System.Windows.Forms.ComboBox newGradeStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button newStudentAdd;
        private System.Windows.Forms.ComboBox newStudentMajor;
        private System.Windows.Forms.ComboBox newStudentCollege;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox newStudentName;
        private System.Windows.Forms.BindingSource tblStudentsBindingSource;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.DataGridView gradesDataGridView;
    }
}

