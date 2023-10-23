using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        List<string> deptlist = new List<string>()
        {
            "HR","Admin","Sales","Devlopment","Testing","Marketing"
        };


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDept.DataSource = deptlist;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double bs = Convert.ToDouble(txtBSal.Text);
            double hra = bs * 0.40;
            double ta = bs * 0.30;
            double da = bs * 0.20;
            double pf = bs * 0.12;
            double grosssallbl = (bs + hra + ta + da) - pf;

            txtHRA.Text = hra.ToString();
            txtTA.Text = ta.ToString();
            txtDA.Text = da.ToString();
            txtPF.Text = pf.ToString();
            txtGSal.Text = grosssallbl.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string msg = txtEid.Text +"\n" +txtEname.Text +"\n" +cmbDept.Text +"\n" +txtGSal.Text;
            lblmsg.Text = msg;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            cmbDept.DataSource = deptlist;
        }
    }
}
