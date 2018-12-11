using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEnshu
{
    public class ItemsDao3
    {

        public List<ItemsDto> SearchItemsList()
        {

            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();


            //パラメータ設定
            command.Parameters.Add("@itemName", SqlDbType.NVarChar, 50);
            command.Parameters["@itemName"].Value = itemSearchBox.Text;

            command.CommandText = $"SELECT * FROM Items " +
                                  $"set itemName = @itemName " +
                                  $"WHERE itemName LIKE (N'%{itemSearchBox}%') ";



            command.Connection = connection;
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
}
