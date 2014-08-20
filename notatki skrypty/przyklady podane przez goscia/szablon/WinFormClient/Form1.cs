using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;

namespace WinFormClient
{

    public partial class Form1 : Form
    {

               
        public Form1()
        {
            InitializeComponent();
        }


        private void showGridContent()
        {
           dataGridView1.DataSource = TblUpd.GetT1Info(txtNameFilter.Text); 
        }

        private void editSelected(int Nr)
        {

            Form2 fEdit = new Form2(Nr);
            DialogResult dres;

            dres = fEdit.ShowDialog(this);
            if (dres == DialogResult.OK)
                showGridContent();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showGridContent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // dataGridView1.CurrentRow.Cells["nr"].Value
            // int r =  int.tryParse(dataGridView1.CurrentRow.Cells["nr"].Value.ToString());
            int _t1no = -1 ;

            try 
            {
                _t1no = int.Parse(dataGridView1.CurrentRow.Cells["nr"].Value.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show("Należy wybrać element");
                return;
            }
            editSelected(_t1no);
            //int num = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["nr"].Value.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int _t1no = -1;

            try
            {
                _t1no = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["nr"].Value.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show("Należy wybrać element");
                return;
            }
            editSelected(_t1no);
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = TblUpd.GetAll();
            // listBox1.DisplayMember ="name" ;
            listBox1.DisplayMember = cmbDisplayName.Text;

        }
    }
}
