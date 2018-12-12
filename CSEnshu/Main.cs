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

            //検索結果が0件の時
            if (searchResult.Items.Count == 0)
            {
                result.Visible = true;
                result.Text = MessageHolder.PM3;
            }


        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            //注文を押したとき
            //選択されたインデックス

            int num = searchResult.SelectedIndex;



            //選択されている場合
            if (num != -1)
            {
                if (itemsList[num].Stock == 0)
                {
                    resultText.Visible = true;
                    resultText.Text = MessageHolder.EM3;
                    return;
                }
                item = new ItemsDto(itemsList[num].ItemId, itemsList[num].ItemName,
                   itemsList[num].Price, itemsList[num].Stock);
                //フォーム呼び出す
                Order order = new Order(item);


                //OKで返ってきたら
                if (order.ShowDialog(this) == DialogResult.OK)
                {
                    
                    searchResult.Items.Clear();
                    resultText.Visible = true;
                    resultText.Text = MessageHolder.PM1;
                    ItemsDao items = new ItemsDao();
                    itemsList = items.query();
                    for (int i = 0; i < itemsList.Count; i++)
                    {
                        //リストに追加
                        searchResult.Items.Add("商品名:" + itemsList[i].ItemName + "　価格:" + itemsList[i].Price + "　在庫:" + itemsList[i].Stock);
                    }

                }
            }
            else//選択されていない場合
            {
                resultText.Visible = true;
                resultText.Text = MessageHolder.PM4;
            }

        }

        private void addStockButton_Click(object sender, EventArgs e)
        {
            //在庫追加を押したとき
            //選択されたインデックス
            int num = searchResult.SelectedIndex;


            if (num != -1)
            {
                item = new ItemsDto(itemsList[num].ItemId, itemsList[num].ItemName,
               itemsList[num].Price, itemsList[num].Stock);
                //フォーム呼び出す
                AddStocks addStocks = new AddStocks(item);


                //OKで返ってきたら
                if (addStocks.ShowDialog(this) == DialogResult.OK)
                {
                    searchResult.Items.Clear();
                    resultText.Visible = true;
                    resultText.Text = MessageHolder.PM2;
                    ItemsDao items = new ItemsDao();
                    itemsList = items.query();
                    for (int i = 0; i < itemsList.Count; i++)
                    {
                        //リストに追加
                        searchResult.Items.Add("商品名:" + itemsList[i].ItemName + "　価格:" + itemsList[i].Price + "　在庫:" + itemsList[i].Stock);
                    }
                }
                else
                {
                    resultText.Visible = true;
                    resultText.Text = MessageHolder.PM4;

                }
            }

            
        }

        private void searchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選択されたらメッセージを消す
            if (searchResult.Items.Count != 0)
            {
                resultText.Visible = false;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void itemSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchItems(string searhItemName)
        {
            searchResult.Items.Clear();
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

        private void result_Click(object sender, EventArgs e)
        {

        }
    }
}
