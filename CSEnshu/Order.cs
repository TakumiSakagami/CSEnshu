using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSEnshu
{
    public partial class Order : Form
    {

        CustomerDao customerDao = new CustomerDao();
        public Order()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        //顧客検索ボタンを押下.
        private void customerSearchButton_Click(object sender, EventArgs e)
        {
            customerDao.SearchCustomerList(customerSearchBox.Text);
        }

        private void orderExecuteButton_Click(object sender, EventArgs e)
        {

        }

        private void orderCanselButton_Click(object sender, EventArgs e)
        {

        }

        private void customerBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void orderBox_TextChanged(object sender, EventArgs e)
        {

        }

        //顧客検索するメソッド.
        public void SearchCustomer(string searchCustomerName)
        {
            //CustomerDaoのインスタンス生成//金子さんがこれからつくる.
            CustomerDao customerDao = new CustomerDao();
            List<Customer> customerList = new List<Customer>();


        }

        private bool Validate(int )
        {

        }
    }
}
