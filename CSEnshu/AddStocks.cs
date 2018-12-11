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

        //mainform instance 格納しておくフィールド
        private Main mainInstance;

        //item
        private ItemsDto item;

        //入力された追加在庫数
        private string inputStock;

        //dao実行結果
        int result = 0;



        private void Form2_Load(object sender, EventArgs e)
        {
            //mainformのインスタンスを mainInstanceに代入
            //this.mainInstance = new Main();

            //mainformで入力されたitem ことちゃん！！！
            this.item = mainInstance.item;


            //商品名、現在庫の表示、ことちゃんと！

            itemName.Text = Convert.ToString(item.itemName);
            currentStock.Text = Convert.ToString(item.stock);

        }

        private void addExecuteButton_Click(object sender, EventArgs e)
        {
            //追加在庫数の取得
            //inputStock = Convert.ToInt32(addStockBox.Text);
            
            //vaidate
            Validater validater = new Validater();

            validater.IsNull();


            //DBAccess
            DBAccess dBAccess = new DBAccess();

            //stockdao
            StocksDao stocksDao = new StocksDao();

            //addstock()実行
            result =  stocksDao.AddStocks(item.ItemId, inputStock);

            //更新できた！メインに戻る
            if(result == 1)
            {
                this.Close();
                
            }

        }


        private void addCancelButton_Click(object sender, EventArgs e)
        {


        }

        private void addStockBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
