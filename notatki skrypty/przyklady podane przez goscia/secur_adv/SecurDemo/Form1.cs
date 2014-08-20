using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecurDemo
{
    public partial class Form1 : Form
    {

        public IUserCtx uctx; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Init.Login(tbUName.Text , "xxx",  out uctx ))
            {
                btnDemo.Enabled = uctx.HasRoleRight(BizzLogic.Operation1Role);
                listBox1.DataSource = uctx.GetAllRoles();
            }; 
        }

        private void btnMet1_Click(object sender, EventArgs e)
        {
            BizzLogic.BizzMet1();
        }

        private void btnMet2_Click(object sender, EventArgs e)
        {
            BizzLogic.BizzMet2();
        }

        private void btnMet3_Click(object sender, EventArgs e)
        {
            try
            {
                BizzLogic.BizzMet3();
            }
            catch (System.Security.SecurityException se)
            {
                MessageBox.Show("Brak uprawnień"); 
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDemo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BizzLogic.BizzMet4();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Init.Logout(ref uctx );
        }
    }
}
