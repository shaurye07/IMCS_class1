using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show(textBox1.Text);
            else
                MessageBox.Show("Please enter a valid first name.");


            List<Student> myStudents = new List<Student>();

            myStudents.Add(new Student() { FirstName ="IMCS" , LastName="Inc" });
            myStudents.Add(new Student() { FirstName = "Sun", LastName = "Inc" });

            dataGridView1.DataSource = myStudents;


        }
    }


   public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
