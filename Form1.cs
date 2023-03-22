using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string str = "";

            //checkbox = japan
            if (checkBox1.Checked == true)
            {
                str = str + checkBox1.Text;
                str += " ";
            }

            //checkbox2 = Philippines
            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text;
                str += " ";
            }
            //checkbox3 = Thailand
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text;
                str += " ";
            }
            //checkbox4 = Autralia
            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text;
                str += " "; 
            }

            //othercheckbox
            if (othercheckbox.Checked == true)
            {
                str = str + otherstextbox.Text;
                str += " ";
            }

            if (str != null) {
                MessageBox.Show("You Selected:\n" + str + "\nThank You!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void otherstextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void othercheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (othercheckbox.Checked == false)
            {
                otherslabel.Visible = false;
                otherstextbox.Visible = false;
            }
            else {
                otherslabel.Visible = true;
                otherstextbox.Visible = true;
            
            }


        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            otherslabel.Visible = false;
            otherstextbox.Visible = false;
        }
    }
}
