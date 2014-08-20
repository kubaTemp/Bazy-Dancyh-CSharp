using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAC ;
using BL ;


namespace WinFormClient
{
    public partial class Form2 : Form
    {
        private int _nr ;
        private int _mode;


        private Table1 _table1;

        private void populate()
        {
            _table1 = TblUpd.GetElement(_nr);
            txtNr.Text = _table1.nr.ToString();
            txtName.Text = _table1.name;
            txtId.Text = _table1.id.ToString();

        }

        bool validate()
        {
            
            // sequence of validation conditions
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Nazwa nie może być pusta");
                txtName.Focus();
                return (false);
            }

            // a next condition ...
            return true ;
        }


        void apply()
        {
            _table1.name = txtName.Text;
            TblUpd.TableMod(_table1);
        }

        public Form2()
        {
            InitializeComponent();
        }


        public Form2 (int Nr):this() 
        {
            _nr = Nr ;
        }


        public Form2(int Nr, int Mode):this (Nr)
        {
            _mode = Mode ;
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!validate())
                return;
            apply();
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Edycja elementu " + _nr.ToString();
            populate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
