using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DbStudentEntities db = new DbStudentEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                var values = db.tbl_grade.Where(x => x.Exam1 < 50);
                dataGridView1.DataSource = values.ToList();
            }

            if (radioButton2.Checked == true)
            {
                var values = db.tbl_student.Where(x => x.Name == "Ali");
                dataGridView1.DataSource = values.ToList();
            }

            if (radioButton3.Checked == true)
            {
                var values = db.tbl_student.Where(x => x.Name == textBox1.Text || x.Surname == textBox1.Text);
                dataGridView1.DataSource = values.ToList();
            }

            if (radioButton4.Checked == true)
            {
                var values = db.tbl_student.Select(x => new { Lastname = x.Surname });
                dataGridView1.DataSource = values.ToList();
            }

            if (radioButton5.Checked == true)
            {
                var values = db.tbl_student.Select(x => new {Name = x.Name.ToLower(), Lastname = x.Surname.ToUpper() });
                dataGridView1.DataSource = values.ToList();
            }
        }
    }
}
