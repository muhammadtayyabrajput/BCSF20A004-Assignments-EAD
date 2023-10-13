using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg01
{
    public partial class Form1 : Form
    {
        string firstName, lastName;
        List<string> subjects = new List<string> ();
        ArrayList resultList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            firstName = (string) textBox1.Text;
            
        }

        private void prerequisite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lastName = (string) textBox2.Text;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subj = textBox3.Text; 
            bool preRequisite = checkBox1.Checked;

            resultList.Add($"FirstName: {firstName}\n");
            resultList.Add($"LastName: {lastName}\n");

            string[] subjectLines = subj.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            subjects.AddRange(subjectLines);

            string subjectsText = "Subjects: " + string.Join(", ", subjects);

            resultList.Add(subjectsText);

            resultList.Add($"\nPreRequisite: {preRequisite}\n");


            string res = "";
            foreach (var l in resultList)
            {
                res += l;
            }

            Result.Text = res;
        }
    }
}
