using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList date = new ArrayList();
            for (int i = 1;  i <= 31; i++) { 
                date.Add(i + 1);
                DateCombo.Items.Add(i.ToString());

            
            }

            ArrayList month = new ArrayList();
            for (int i = 0; i < 12; i++)
            {
                month.Add(i + 1);
                MonthCombo.Items.Add((month[i]));

            }

            ArrayList year = new ArrayList();
            for (int i = 1900; i <= 2024; i++)
            {
                year.Add(i);
                YearCombo.Items.Add(year[i-1900]);
            }

            ArrayList programoflist = new ArrayList();
            programoflist.Add("Bachelor of Science in Computer Science");
            programoflist.Add("Bachelor of Science in Information Technology");
            programoflist.Add("Bachelor of Science in Computer Engineering");
            programoflist.Add("Bachelor of Science in Information System");
            PBox.Items.AddRange(programoflist.ToArray());
            foreach (String programs in programoflist)
            {
                Console.WriteLine(programs);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string day = DateCombo.GetItemText(DateCombo.SelectedItem);
            string month = MonthCombo.GetItemText(MonthCombo.SelectedItem);
            string year = YearCombo.GetItemText(YearCombo.SelectedItem);
            string gender = radioButton1.Checked == true ? "Female" : "Male";

            string lastname;
            string firstname;
            string middlename;
            string Program;

            lastname = LastBox.Text;
            firstname = FirstBox.Text;
            middlename = MiddleBox.Text;
            Program = PBox.Text;

            MessageBox.Show("Student name: " + firstname + " " + middlename + "" + lastname + "\nGender: " + gender + "\nDate of Birth" + day + "/" + month + "/" + year + "\nProgram:" + Program);

        }
    }
}
