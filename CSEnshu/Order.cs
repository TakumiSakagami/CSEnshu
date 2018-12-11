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

        private ItemsDto item;


        public Order(ItemsDto item)
        {
            InitializeComponent();

            this.item = item;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        //顧客検索ボタンを押下.
        private void customerSearchButton_Click(object sender, EventArgs e)
        {
            //customerDaoのSearchCustomerListで作成したリストをすべて表示させる.
            foreach (var a in customerDao.SearchCustomerList(customerSearchBox.Text))
            {
                //customerBoxに表示させる.
                customerBox.Items.Add($"顧客ID:{a.CustomerId} 名前:{a.LastName} {a.FirstName}");
            }

        }

        //注文ボタン押下
        private void orderExecuteButton_Click(object sender, EventArgs e)
        {
            //何かしらの入力があるかどうか.
            if (validater.IsNull(orderBox.Text))
            {
                errorMessage.Text = MessageHolder.EM1;
            }
            //数字以外が入力される.
            if (validater.IsNum(orderBox.Text) == 0)
            {
                errorMessage.Text = MessageHolder.EM1;
            }
            //マイナスの値が入力される.
            else if(validater.IsNum(orderBox.Text) == -1)
            {
                errorMessage.Text = MessageHolder.EM2;
            }

            //入力チェックが完了したら
            //①labelにPM01を表示させる
            //②注文数量の変数orderQuantityに入力値を代入
            errorMessage.Text = MessageHolder.PM1;
            orderQuantity = Convert.ToInt32(orderBox.Text);

            logger.

        }

        //キャンセルボタンを押したらメイン（商品選択画面）に遷移する.
        private void orderCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void orderBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
