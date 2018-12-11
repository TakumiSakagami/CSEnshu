using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEnshu
{
    public class ItemsDao
    {

        DBAccess access = new DBAccess();

        public List<ItemsDto> SearchItemsList()
        {
            access.DbClose();

            Main main = null;
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();


            //パラメータ設定
            command.Parameters.Add("@itemName", SqlDbType.NVarChar, 50);
            command.Parameters["@itemName"].Value = main.itemSearchBox.Text;

            command.CommandText = $"SELECT * FROM Items " +
                                  $"WHERE itemName = @itemName " +
                                  $"AND itemName LIKE (N'%{main.itemSearchBox}%') ";



            command.Connection = connection;
            //クエリの実行
            SqlDataReader reader;

            reader = command.ExecuteReader();
            List<ItemsDto> list = new List<ItemsDto>();
            
            //値の取得
            while (reader.Read())
            {
                string itemIdStr = reader["itemId"].ToString();
                string itemName = reader["itemName"].ToString();
                string priceStr = reader["price"].ToString();
                string stockStr = reader["price"].ToString();

                int itemId = Convert.ToInt32(itemIdStr);
                int price = Convert.ToInt32(priceStr);
                int stock = Convert.ToInt32(stockStr);
                ItemsDto itemsDto = new ItemsDto(itemId, itemName, price, stock);
                list.Add(itemsDto);
            }

            access.DbClose();

            return list;

        }
    }
}
