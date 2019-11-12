using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project4
{
    public partial class Form1 : Form
    {
        private BindingSource studentDataBindingSource = new BindingSource();
        private BindingSource gradeDataBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            showPanel("main");
        }

        private void showPanel(String panelName)
        {
            mainPanel.Visible = (String.Equals(panelName, "main")) ? true : false;
            studentPanel.Visible = (String.Equals(panelName, "students")) ? true : false;
            gradePanel.Visible = (String.Equals(panelName, "grades")) ? true : false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentDataGridView.DataSource = studentDataBindingSource;
            gradesDataGridView.DataSource = gradeDataBindingSource;
            string[] gradeArray = new string[5] {"A", "B", "C", "D", "F"};

            newGradeGrade.Items.AddRange(gradeArray);

            loadData();
        }

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("main");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("students");
        }

        private void GradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("grades");
        }

        private void loadData()
        {
            newStudentCollege.Items.Clear();
            newStudentMajor.Items.Clear();
            newGradeStudent.Items.Clear();
            newGradeTerm.Items.Clear();
            newGradeCourse.Items.Clear();

            DataTable dtCollegeList = new DataTable();
            Walton_DB.FillDataTable_ViaSql(ref dtCollegeList,
                "SELECT CollegeID, College FROM tbl_Colleges order by College");

            foreach (DataRow dr in dtCollegeList.Rows)
            {
                newStudentCollege.Items.Add(new Item((String) dr["College"], (int)(dr["CollegeID"])));
            }

            DataTable dtStudentList = new DataTable();
            Walton_DB.FillDataTable_ViaSql(ref dtStudentList,
                "SELECT StudentID, StudentName FROM tbl_Students order by StudentName");

            foreach (DataRow dr in dtStudentList.Rows)
            {
                newGradeStudent.Items.Add(new Item((String)dr["StudentName"], (int)(dr["StudentID"])));
            }

            DataTable dtCourseList = new DataTable();
            Walton_DB.FillDataTable_ViaSql(ref dtCourseList,
                "SELECT CourseID, Course FROM tbl_Courses order by Course");

            foreach (DataRow dr in dtCourseList.Rows)
            {
                newGradeCourse.Items.Add(new Item((String)dr["Course"], (int)(dr["CourseID"])));
            }

            DataTable dtTermList = new DataTable();
            Walton_DB.FillDataTable_ViaSql(ref dtTermList,
                "SELECT TermID, Term FROM tbl_Terms order by Term");

            foreach (DataRow dr in dtTermList.Rows)
            {
                newGradeTerm.Items.Add(new Item((String)dr["Term"], (int)(dr["TermID"])));
            }

            refreshDataGridViews();
        }

        private void refreshDataGridViews()
        {
            DataTable dtStudentsList = new DataTable();
            Walton_DB.FillDataTable_ViaSql(ref dtStudentsList,
                "SELECT tbl_Students.StudentID, tbl_Students.StudentName, tbl_Colleges.College, tbl_Majors.Major FROM tbl_Students INNER JOIN tbl_Colleges ON tbl_Students.StudentCollege = tbl_Colleges.CollegeID INNER JOIN tbl_Majors ON tbl_Students.StudentMajor = tbl_Majors.MajorID");
            studentDataBindingSource.DataSource = dtStudentsList;

            DataTable dtGradesList = new DataTable();
            Walton_DB.FillDataTable_ViaSql(ref dtGradesList,
                "SELECT tbl_Students.StudentName, tbl_Courses.Course, tbl_Terms.Term, tbl_Grades.Grade FROM tbl_Grades INNER JOIN tbl_Students ON tbl_Grades.Student = tbl_Students.StudentID INNER JOIN tbl_Courses ON tbl_Grades.Course = tbl_Courses.CourseID INNER JOIN tbl_Terms ON tbl_Grades.Term = tbl_Terms.TermID");
            gradeDataBindingSource.DataSource = dtGradesList;
        }

        private void NewStudentCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newStudentCollege.SelectedIndex == -1)
            {
                return;
            }
            Item itm = (Item)newStudentCollege.SelectedItem;
            DataTable dtMajorList = new DataTable();
            Walton_DB.FillDataTable_ViaSql(ref dtMajorList,
                "SELECT MajorID, Major FROM tbl_Majors where CollegeID = " + itm.Value.ToString());

            foreach (DataRow dr in dtMajorList.Rows)
            {
                newStudentMajor.Items.Add(new Item((String)dr["Major"], (int)(dr["MajorID"])));
            }
        }

        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }

        private void NewStudentAdd_Click(object sender, EventArgs e)
        {
            Item collegeItem = (Item)newStudentCollege.SelectedItem;
            Item majorItem = (Item)newStudentMajor.SelectedItem;

            String collegeID = collegeItem.Value.ToString();
            String majorID = majorItem.Value.ToString();
            String name = newStudentName.Text;
            if (name.Length == 0)
            {
                return;
            }
            newStudentCollege.SelectedIndex = -1;
            newStudentName.Text = "";

            Walton_DB.ExecSqlString(
                "INSERT INTO tbl_Students (StudentName, StudentCollege, StudentMajor) VALUES ('" +
                name.Trim() + "'," + collegeID + "," + majorID + ")");
            loadData();
        }

        private void NewGradeAdd_Click(object sender, EventArgs e)
        {
            Item studentItem = (Item)newGradeStudent.SelectedItem;
            Item courseItem = (Item)newGradeCourse.SelectedItem;
            Item termItem = (Item)newGradeTerm.SelectedItem;

            String studentID = studentItem.Value.ToString();
            String courseID = courseItem.Value.ToString();
            String termID = termItem.Value.ToString();
            String grade = (string) newGradeGrade.SelectedItem;

            Walton_DB.ExecSqlString("INSERT INTO tbl_Grades (Student, Course, Term, Grade) VALUES (" +
                studentID + "," + courseID + "," + termID + ",'" + grade + "')");

            newGradeGrade.SelectedIndex = -1;
            loadData();
        }
    }
}
