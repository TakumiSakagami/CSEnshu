using CSEnshu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

//注文画面で注文ボタンを押下すると呼ばれる.
public class OrderDao
{
    //現在時刻取得.
    private DateTime date = DateTime.Now;

    SqlCommand command = new SqlCommand();
    SqlConnection connection = new SqlConnection();
    DBAccess access = new DBAccess();
    SqlDataReader reader;

    //OrdersテーブルにitemId,CustomerId,quantityを追加していくメソッド.
    public int OrderRecord(int itemId, int customerId, int quantity)
    {
        //データベースに接続する.
        access.DbConnect();

        command.CommandText = $"INSERT INTO Orders(itemId,customerId,quantity,date)" +
                              $"VALUES(@itemId,@customerId,@quantity,@date)";

        //商品ID(itemId)のパラメータ設定.
        //OrderRecordメソッドの引数から取得する.
        command.Parameters.Add("@itemId", SqlDbType.Int);
        command.Parameters["@itemId"].Value = itemId;

        //顧客ID(customerId)のパラメータ設定.
        //OrderRecordメソッドの引数から取得する.
        command.Parameters.Add("@customerId", SqlDbType.Int);
        command.Parameters["@customerId"].Value = customerId;

        //注文数量(quantity)のパラメータ設定.
        //注文数のorderBoxから取得する.
        command.Parameters.Add("@quantity", SqlDbType.Int);
        command.Parameters["@quantity"].Value = quantity;

        //注文日(date)のパラメータ設定.
        //OrdersDaoクラスのフィールドから取得.
        command.Parameters.Add("@date", SqlDbType.DateTime);
        command.Parameters["@date"].Value = date;

        //Connection情報の登録
        command.Connection = access.Connection;
        //クエリの実行
        int num = command.ExecuteNonQuery();
        access.DbClose();

        return num;
    }

    public List<OrderDto> getOrder()
    {
        List<OrderDto> list = new List<OrderDto>();

        command.CommandText = "SELECT * FROM Orders,Items,Customers " +
                                "WHERE Orders.itemId=Items.itemId " +
                                "AND Orders.customerId=Customers.customerId;";

        access.DbConnect();

        command.Connection = access.Connection;
        reader = command.ExecuteReader();

        while (reader.Read())
        {

            String orderIdStr = reader["orderId"].ToString();
            String itemIdStr = reader["itemId"].ToString();
            String customerIdStr = reader["customerId"].ToString();
            String quantityStr = reader["quantity"].ToString();
            DateTime date = (DateTime)reader["date"];

            int orderId = Convert.ToInt32(orderIdStr);
            int itemId = Convert.ToInt32(itemIdStr);
            String itemName = reader["itemName"].ToString();
            int customerId = Convert.ToInt32(customerIdStr);
            String firstName = reader["firstName"].ToString();
            String lastName = reader["lastName"].ToString();
            int quantity = Convert.ToInt32(quantityStr);
            String customerName = firstName + lastName;
            list.Add(new OrderDto(orderId, itemId, itemName, customerId, customerName, quantity, date));
        }

        access.DbClose();

        return list;

    }
}