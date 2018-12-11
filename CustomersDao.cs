using System;

public class CustomersDao
{
    public List<CustomersDto> SearchItemsList()
    {

        SqlCommand command = new SqlCommand();


        //パラメータ設定
        command.Parameters.Add("@firstName", SqlDbType.NVarChar, 30);
        command.Parameters["@firstname"].value = itemSerarchBox.Text;
        command.Parameters.Add("@lastName", SqlDbType.NVarChar, 30);
        command.Parameters["@lastname"].value = itemSerarchBox.Text;

        command.CommandText = $"SELECT * FROM Items " +
                              $"set firstName = @firstName " +
                              $"set lastName = @lastName " +
                              $"WHERE firstName LIKE (N'%{customerSerarchBox}%') " +
                              $"or (N'%{customerSerarchBox}%') ";

        ;
        //クエリの実行
        SqlDataReader reader;

        //クエリの実行
        reader = command.ExecuteReader();
        List<ItemsDto> list = new List<ItemsDto>();

        //値の取得
        while (reader.Read())
        {
            string itemIdStr = reader["itemId"].ToString();
            string itemName = reader["ItemName"].ToString();
            string priceStr = reader["price"].ToString();

            int itemId = Convert.ToInt32(itemIdStr);
            int price = Convert.ToInt32(priceStr);
            ItemsDto itemsDto = new ItemsDto(itemId, itemName, price);
            list.Add(itemsDto);
        }

        return list;

    }
}
