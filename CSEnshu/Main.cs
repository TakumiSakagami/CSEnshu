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

        public static Main MainInstance { get; set; }
        List<ItemsDto> itemsList = new List<ItemsDto>();
        ItemsDto item;
        

        public Main()
        {
            InitializeComponent();
            Main.MainInstance = this;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchItems(itemSearchBox.Text);

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            //注文を押したとき
            //選択されたインデックス
            int num = searchResult.SelectedIndex;

            item = new ItemsDto(itemsList[num].ItemId, itemsList[num].ItemName,
               itemsList[num].Price, itemsList[num].Stock);
            Order order = new Order(item);
           

            //OKで返ってきたら
            if (order.ShowDialog(this) == DialogResult.OK)
            {
                resultText.Visible = true;
                resultText.Text = MessageHolder.PM1;
            }



        }

        private void addStockButton_Click(object sender, EventArgs e)
        {
            //在庫追加を押したとき
            //選択されたインデックス
            int num = searchResult.SelectedIndex;

            item = new ItemsDto(itemsList[num].ItemId, itemsList[num].ItemName,
               itemsList[num].Price, itemsList[num].Stock);

            AddStocks addStocks = new AddStocks(item);
            

            //OKで返ってきたら
            if (addStocks.ShowDialog(this) == DialogResult.OK)
            {
                resultText.Visible = true;
                resultText.Text = MessageHolder.PM2;
            }


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
            itemsList = itemsDao.SearchItemsList(itemSearchBox.Text);

            //検索する
            for (int i = 0; i < itemsList.Count; i++)
            {
                //リストに追加
                searchResult.Items.Add("商品名:" + itemsList[i].ItemName + "　価格:" + itemsList[i].Price + "　在庫:" + itemsList[i].Stock);
            }

        }

        private void resultText_Click(object sender, EventArgs e)
        {

        }
    }
}
