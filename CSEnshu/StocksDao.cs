using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEnshu
{
    class StocksDao
    {
        public int AddStocks(int itemId, int inputStock)
        {
            SqlCommand command = new SqlCommand();

            command.Parameters.Add("@inputStocks", SqlDbType.Int);
            command.Parameters.Add("@itemId", SqlDbType.Int);

            command.Parameters["@inputStocks"].Value = inputStock;
            command.Parameters["@itemId"].Value = itemId;

            command.CommandText = $"UPDATE StocksTable" +
                $" SET stocks = stocks + N'@inputStocks'" +
                $" WHERE itemId = N'@itemId'";


            //DBAccess 
            DBAccess dBAccess = new DBAccess();
            //connect
            dBAccess.DbConnect();

            
            //クエリ実行
            int num = command.ExecuteNonQuery();

            //close
            dBAccess.DbClose();

            return num;
        }

        public int DecrementStocks(int itemId, int quantity)
        {

            SqlCommand command = new SqlCommand();

            command.Parameters.Add("@quantity", SqlDbType.Int);
            command.Parameters.Add("@itemId", SqlDbType.Int);

            command.Parameters["@quantity"].Value = quantity;
            command.Parameters["@itemId"].Value = itemId;
            

            command.CommandText = $"UPDATE StocksTable" +
                $" SET stocks = stocks - N'@quantity'" +
                $" WHERE itemId = N'@itemId'";

            //DBAccess
            DBAccess dBAccess = new DBAccess();

            //connection
            dBAccess.DbConnect();

            //クエリ実行
            int num = command.ExecuteNonQuery();

            //close
            dBAccess.DbClose();

            return num;
            


        }
    }
}
