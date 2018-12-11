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
    public partial class Main : Form
    {

        public static Main MainInstance { get; set;}
        
        public Main()
        {
            InitializeComponent();
            Main.MainInstance = this;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            //注文を押したとき
            AddStocks addStocks = new AddStocks();
            addStocks.ShowDialog();
            Validater validater = new Validater();

            if (addStocks.ShowDialog(this) == DialogResult.OK)
            {
                resultText.Text = 
            }

        }

        private void addStockButton_Click(object sender, EventArgs e)
        {
            //在庫追加を押したとき
            Order order = new Order();
            order.ShowDialog();

            if ()

            
        }

        private void searchResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void itemSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void searchItems(string searhItemName)
        {
            
            ItemsDao itemsDao = new ItemsDao();
            List<ItemsDto> itemsList = itemsDao.SearchItemsList(itemSearchBox.Text);

            //検索する
            for (int i = 0; i < itemsList.Count; i++)
            {
                searchResult.Items.Add(itemsList[i].ItemName + ":" + itemsList[i].Price + ":" + itemsList[i].Stock);
            }
        

        }

        private void resultText_Click(object sender, EventArgs e)
        {

        }
    }
}
