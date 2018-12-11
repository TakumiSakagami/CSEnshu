using System;
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
            itemName.Text = Convert.ToString(itemName);
            currentStock.Text = Convert.ToString(stock)

        }

        private void addExecuteButton_Click(object sender, EventArgs e)
        {

            //DBAccess
            DBAccess dBAccess = new DBAccess();


            StocksDao stocksDao = new StocksDao();

        }

        private void addCancelButton_Click(object sender, EventArgs e)
        {

        }

    }
}
