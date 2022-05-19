using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace udemy_cSharp_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lbxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        List<string> Students;

        private void Form2_Load(object sender, EventArgs e)
        {
            Students = new List<string>() { "Ali", "Veli", "Dali" };

            foreach (var student in Students)
            {
                lbxStudents.Items.Add(student);
            }

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (tbxAddStudent.Text.Length > 2)
            {
                Students.Add(tbxAddStudent.Text);
                lbxStudents.Items.Clear();
                foreach (var student in Students)
                {
                    lbxStudents.Items.Add(student);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci adı giriniz");

            }

            tbxAddStudent.Clear();

        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lbxStudents.SelectedItem != null)
            {
                Students.Remove(lbxStudents.SelectedItem.ToString());
                lbxStudents.Items.Clear();
                foreach (var student in Students)
                {
                    lbxStudents.Items.Add(student);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci adı giriniz");

            }
        }
    }
}
