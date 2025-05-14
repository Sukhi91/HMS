using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hosapital_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblIndicator1.ForeColor = System.Drawing.Color.Red;
            lblIndicator2.ForeColor = System.Drawing.Color.Black;
            lblIndicator3.ForeColor = System.Drawing.Color.Black;
            lblIndicator4.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblIndicator1.ForeColor = System.Drawing.Color.Black;
            lblIndicator2.ForeColor = System.Drawing.Color.Black;
            lblIndicator3.ForeColor = System.Drawing.Color.Red;
            lblIndicator4.ForeColor = System.Drawing.Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblIndicator1.ForeColor = System.Drawing.Color.Black;
            lblIndicator2.ForeColor = System.Drawing.Color.Black;
            lblIndicator3.ForeColor = System.Drawing.Color.Black;
            lblIndicator4.ForeColor = System.Drawing.Color.Red;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblIndicator1.ForeColor = System.Drawing.Color.Black;
            lblIndicator2.ForeColor = System.Drawing.Color.Red;
            lblIndicator3.ForeColor = System.Drawing.Color.Black;
            lblIndicator4.ForeColor = System.Drawing.Color.Black;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String address = txtAddress.Text;
            Int64 Contact = Convert.ToInt64(txtContactNo.Text);
            int age = Convert.ToInt32(txtAge.Text);
            String gender = comboGender.Text;
            int pid = Convert.ToInt32(txtPatientID.Text);

            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtContactNo.Text = "";
            txtAge.Text = "";
            comboGender.Text = "";
            txtPatientID.Text = "";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
