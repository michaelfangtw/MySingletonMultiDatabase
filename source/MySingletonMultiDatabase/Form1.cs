using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySingletonMultiDatabase.Dal;
using MySingletonMultiDatabase.Model;

namespace MySingletonMultiDatabase
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        CategoryDal categoryDal = new CategoryDal();
        ConnDal connDal = new ConnDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Customer_Click(object sender, EventArgs e)
        {   
            for(int i=0;i<=100;i++) {
                CustomerDal customerDal = new CustomerDal();
                List<Customer> customerList = customerDal.GetCustomer().ToList();            
                bindingSource1.DataSource = customerList;
                dataGridView1.DataSource = bindingSource1;
                pidCustomer.Text = customerDal.GetPID();
            }
            Conn_Click(null, null);
        }

        private void Category_Click(object sender, EventArgs e)
        {
            List<Category> categoryList = categoryDal.GetCategory().ToList();
            bindingSource1.DataSource = categoryList;
            dataGridView1.DataSource = bindingSource1;
            pidCategory.Text = categoryDal.GetPID();
            Conn_Click(null, null);
        }

        private void Conn_Click(object sender, EventArgs e)
        {           
            List<DbLogin> dbLoginList = connDal.GetLoginList().ToList();
            bindingSource2.DataSource = dbLoginList;
            dataGridView2.DataSource = bindingSource2;
            pidConn.Text = connDal.GetPID();
        }

    }
}
