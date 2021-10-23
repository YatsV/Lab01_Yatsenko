using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_Yatsenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_ok_Click(object sender, EventArgs e)
        {

            if (textBox_login.Text == "Vlad" && textBox_password.Text == "123")
            
            {
                label_ok.BackColor = Color.Green;
                MessageBox.Show("Hello Vlad");
            }
            else
            {
                label_ok.BackColor = Color.Red;
                MessageBox.Show("error login or password");
            }
            
        }
    }
}
