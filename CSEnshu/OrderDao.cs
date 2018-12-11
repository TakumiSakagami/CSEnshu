using CSEnshu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

//注文画面で注文ボタンを押下すると呼ばれる.
public class OrderDao1
{
    //現在時刻取得.
    private DateTime date = DateTime.Now;
    //Order order = null;
    SqlCommand command = new SqlCommand();
    SqlConnection connection = new SqlConnection();
    SqlDataReader reader;
    DBAccess access = new DBAccess();

    //orderTableにitemId,CustomersId,quantityを追加していく.
    public int OrderRecord(int itemId, int customerId, int quantity)
    {

        command.CommandText = $"INSERT INTO Orders(itemId,customerId,quantity,date)" +
                              $"VALUES(N'@itemId',N'@customerId',N'@quantity',N'@date')";

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
        command.Connection = connection;
        //クエリの実行
        int num = command.ExecuteNonQuery();

        return num;
    }

    public List<OrderDto> getOrder()
    {
        List<OrderDto> list = new List<OrderDto>();

        command.CommandText = "SELECT * FROM Orders;";

        access.DbConnect();

        command.Connection = connection;
        reader = command.ExecuteReader();

        while (reader.Read())
        {

            String orderIdStr = reader["orderId"].ToString();
            String itemIdStr = reader["itemId"].ToString();
            String customerIdStr = reader["cutomerId"].ToString();
            String quantityStr = reader["quantity"].ToString();
            DateTime date = (DateTime)reader["date"];

            int orderId = Convert.ToInt32(orderIdStr);
            int itemId = Convert.ToInt32(itemIdStr);
            int customerId = Convert.ToInt32(customerIdStr);
            int quantity = Convert.ToInt32(quantityStr);
            list.Add(new OrderDto(orderId, itemId, customerId, quantity, date));
        }

        access.DbClose();

        return list;

    }
}