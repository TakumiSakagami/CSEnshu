using System;
using System.Windows.Forms;

namespace CSEnshu
{
    public partial class AddStocks : Form
    {
        //item
        private ItemsDto item;
        Logger logger = new Logger();

        public AddStocks(ItemsDto item)
        {
            //初期化
            InitializeComponent();

            this.item = item;
        }
        
        //int 追加在庫数
        private int inputStock;
        
        //dao実行結果
        int result = 0;
        
        private void Form2_Load(object sender, EventArgs e)
        {
            //商品名、現在庫の表示、ことちゃんと！

            itemName.Text = Convert.ToString(item.ItemName);
            currentStock.Text = Convert.ToString(item.Stock);

        }

        private void addExecuteButton_Click(object sender, EventArgs e)
        {
            
            //vaidate
            Validater validater = new Validater();

            if (validater.IsNull(addStockBox.Text))
            {
                //isnull true nullのとき
                errorMessage.Visible = true;
                errorMessage.Text = MessageHolder.EM1;
                //return;

            }

            if (validater.IsNum(addStockBox.Text) == -1)
            {
                //マイナスのときは正の整数で～のEM2表示
                errorMessage.Visible = true;

                errorMessage.Text = MessageHolder.EM2;
                //return;

                
            }
            else if(validater.IsNum(addStockBox.Text) == 0)
            {
                //format error  半角数字で～のエラメ
                errorMessage.Visible = true;

                errorMessage.Text = MessageHolder.EM1;
               // return;

            }
            else
            {
                //isnum で数字返却された時は int inputStockに代入
                inputStock = validater.IsNum(addStockBox.Text);

                //stockdao
                StocksDao stocksDao = new StocksDao();

                //addstock()実行
                result = stocksDao.AddStocks(item.ItemId, inputStock);

                //更新できた！メインに戻る
                if (result == 1)
                {
                    logger.OrderWrite(itemName.Text, addStockBox.Text);
                    //dialogresult OK
                    this.DialogResult = DialogResult.OK;

                    this.Dispose();

                }
            }

            
        }


        private void addCancelButton_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }

        private void addStockBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
