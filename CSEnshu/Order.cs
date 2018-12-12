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
        //vaidateのインスタンス
        //注文数量を格納する変数orderQquantity
        //customerDaoのインスタンス
        //Loggerインスタンス
        Validater validater = new Validater();
        int orderQuantity;
        CustomerDao customerDao = new CustomerDao();
        Logger logger = new Logger();
        //OrderDao
        OrderDao orderDao = new OrderDao();

        List<CustomerDto> customerList = new List<CustomerDto>();

        private ItemsDto item;
        private List<OrderDto> orderList = new List<OrderDto>();


        public Order(ItemsDto item)
        {
            //初期化
            InitializeComponent();
            this.item = item;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //注文画面に遷移した時に注文数量入力欄にカーソルを合わせる.
            this.ActiveControl = this.orderBox;

            currentStock.Text = item.Stock.ToString();
            itemName.Text = item.ItemName;

        }

        //顧客検索ボタンを押下.
        private void customerSearchButton_Click(object sender, EventArgs e)
        {
            //顧客名一覧(customerBox)の初期化.
            customerBox.Items.Clear();

            customerList = customerDao.SearchCustomerList(customerSearchBox.Text);
            //customerDaoのSearchCustomerListで作成したリストをすべて表示させる.
            foreach (var a in customerList)
            {
                //customerBoxに表示させる.
                customerBox.Items.Add($"{a.CustomerId} 名前:{a.FirstName} {a.LastName}");
            }

        }

        //注文ボタン押下
        private void orderExecuteButton_Click(object sender, EventArgs e)
        {

            //何かしらの入力があるかどうか.
            if (validater.IsNull(orderBox.Text))
            {
                errorMessage.Visible = true;
                errorMessage.Text = MessageHolder.EM1;
            }
            //数字以外が入力される.
            if (validater.IsNum(orderBox.Text) == 0)
            {
                errorMessage.Visible = true;
                errorMessage.Text = MessageHolder.EM1;
            }
            //マイナスの値が入力される.
            else if(validater.IsNum(orderBox.Text) == -1)
            {
                errorMessage.Visible = true;
                errorMessage.Text = MessageHolder.EM2;
            }
            //入力チェックが完了したら
            //注文数量の変数orderQuantityに入力値を代入
            else
            {

                int currentStocks = Convert.ToInt32(currentStock.Text);
                int quantity = Convert.ToInt32(orderBox.Text);

                if (!validater.stockCheck(currentStocks, quantity))
                {
                    errorMessage.Visible = true;
                    errorMessage.Text = MessageHolder.EM3;


                }
                else
                {
                    orderQuantity = validater.IsNum(orderBox.Text);
                    //StocksDaoのDecrementメソッドを実行
                    //成功したら1がかえるので、Main画面(商品選択)に遷移
                    StocksDao stocksDao = new StocksDao();
                    int result = stocksDao.DecrementStocks(item.ItemId, orderQuantity);
                    //更新できたらメインに戻る
                    if (result == 1)
                    {
                        //ログを書き込む
                        orderDao.OrderRecord(item.ItemId, customerList[customerBox.SelectedIndex].CustomerId, quantity);
                        //ログを残す
                        logger.WriteLine(orderDao.getOrder());
                        this.DialogResult = DialogResult.OK;
                        this.Dispose();
                    }
                }
                
            }



        }

        //キャンセルボタンを押したらメイン（商品選択画面）に遷移する.
        private void orderCancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void customerBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void orderBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemName_Click(object sender, EventArgs e)
        {

        }
    }
}
