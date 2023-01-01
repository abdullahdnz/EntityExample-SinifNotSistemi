using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace EntityExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbStudentEntities db = new DbStudentEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_student.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnClassList_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-RR12QMS;Initial Catalog=DbStudent;Integrated Security=True");
            SqlCommand command = new SqlCommand("Select * From tbl_class", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnGradeList_Click(object sender, EventArgs e)
        {
            var query = from item in db.tbl_grade
                        select new
                        {
                            item.GradeID,
                            item.tbl_student.Name,
                            item.tbl_student.Surname,
                            item.tbl_class.ClassName,
                            item.Exam1,
                            item.Exam2,
                            item.Exam3,
                            item.Average,
                            item.Situation
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbl_student s = new tbl_student();
            s.Name = txtFirstname.Text;
            s.Surname = txtLastname.Text;
            db.tbl_student.Add(s);
            db.SaveChanges();
            MessageBox.Show("Student added succesfully");
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            tbl_class c = new tbl_class();
            c.ClassName = txtClassName.Text;
            db.tbl_class.Add(c);
            db.SaveChanges();
            MessageBox.Show("Class added succesfully");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var x = db.tbl_student.Find(id);
            db.tbl_student.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Student removed succesfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var u = db.tbl_student.Find(id);
            u.Name = txtFirstname.Text;
            u.Surname = txtLastname.Text;
            u.Image = txtImage.Text;
            db.SaveChanges();
            MessageBox.Show("Information updated succesfully");
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.GradeList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_student.Where(x => x.Name == txtFirstname.Text).ToList();
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            string c = txtFirstname.Text;
            var value = from item in db.tbl_student
                        where item.Name.Contains(c)
                        select item;
            dataGridView1.DataSource = value.ToList();
        }

        private void btnLinqEntity_Click(object sender, EventArgs e)
        {
            //Alfabetik sıra
            if (radioButton1.Checked == true)
            {
                List<tbl_student> list1 = db.tbl_student.OrderBy(p => p.Name).ToList();
                dataGridView1.DataSource = list1;
            }
            //Ters alfabetik sıra
            if (radioButton2.Checked == true)
            {
                List<tbl_student> list2 = db.tbl_student.OrderByDescending(p => p.Name).ToList();
                dataGridView1.DataSource = list2;
            }
            //Listedeki ilk 3 kişi
            if (radioButton3.Checked == true)
            {
                List<tbl_student> list3 = db.tbl_student.OrderBy(p => p.Name).Take(3).ToList();
                dataGridView1.DataSource = list3;
            }
            //ID=5 olan öğrenci
            if (radioButton4.Checked == true)
            {
                List<tbl_student> list4 = db.tbl_student.Where(p => p.ID == 5).ToList();
                dataGridView1.DataSource = list4;
            }
            //A ile başlayanlar
            if (radioButton5.Checked == true)
            {
                List<tbl_student> list5 = db.tbl_student.Where(p => p.Name.StartsWith("a")).ToList();
                dataGridView1.DataSource = list5;
            }
            //Değer var mı?
            if (radioButton6.Checked == true)
            {
                bool value = db.tbl_clubs.Any();
                MessageBox.Show(value.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Kalanların içindeki en kötü not
            if (radioButton7.Checked == true)
            {
                label6.Text = db.tbl_grade.Where(x => x.Situation == false).Min(y => y.Average).ToString();
            }
            //En yüksek ortalama
            if (radioButton8.Checked == true)
            {
                label13.Text = db.tbl_grade.Max(x => x.Average).ToString();
            }
        }

        private void btnJoinGrade_Click(object sender, EventArgs e)
        {
            var query = from d1 in db.tbl_grade
                        join d2 in db.tbl_student
                        on d1.Student equals d2.ID
                        join d3 in db.tbl_class
                        on d1.Class equals d3.ClassID
                        select new
                        {
                            Student = d2.Name,
                            Surname = d2.Surname,
                            Class = d3.ClassName,
                            Exam1 = d1.Exam1,
                            Exam2 = d1.Exam2,
                            Exam3 = d1.Exam3,
                            Average = d1.Average
                        };
            dataGridView1.DataSource = query.ToList();
        }
    }
}
