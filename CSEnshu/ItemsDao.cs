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

        public List<ItemsDto> SearchItemsList(string searchItemName)
        {
            access.DbConnect();

           
            SqlCommand command = new SqlCommand();
            
                



            //パラメータ設定
            command.Parameters.Add("@itemName", SqlDbType.NVarChar, 50);
            command.Parameters["@itemName"].Value = searchItemName;

            command.CommandText = $"SELECT * FROM Items " +
                                  $"INNER JOIN Stocks ON Items.itemId = Stocks.itemId " +
                                  $"WHERE itemName LIKE N'%@itemName%' ";

            
            command.Connection = access.Connection;
           

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
                string stockStr = reader["stock"].ToString();

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
