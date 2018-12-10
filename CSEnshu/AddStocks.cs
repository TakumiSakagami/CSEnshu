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
    public partial class AddStocks : Form
    {
        public AddStocks()
        {
            InitializeComponent();
        }

        private ItemsDto item;

        private void Form2_Load(object sender, EventArgs e)
        {
            //商品名、現在庫の表示
            itemName.Text = itemName;
            currentStock.Text = stock;

        }

        private void addExecuteButton_Click(object sender, EventArgs e)
        {

            //DB
            DBAccess dBAccess = new DBAccess();


            StocksDao stocksDao = new StocksDao();

        }

        private void addCancelButton_Click(object sender, EventArgs e)
        {

        }

    }
}
