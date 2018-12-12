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

        int num=0;

        //DBAccess 
        DBAccess dBAccess = new DBAccess();

        public int AddStocks(int itemId, int inputStock)
        {
            SqlCommand command = new SqlCommand();

            command.Parameters.Add("@inputStocks", SqlDbType.Int);
            command.Parameters.Add("@itemId", SqlDbType.Int);

            command.Parameters["@inputStocks"].Value = inputStock;
            command.Parameters["@itemId"].Value = itemId;

            command.CommandText = $"UPDATE Stocks" +
                $" SET stock = stock + @inputStocks" +
                $" WHERE itemId = @itemId";

            
            //connect
            dBAccess.DbConnect();

            command.Connection = dBAccess.Connection;

                //クエリ実行
            num = command.ExecuteNonQuery();



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
            

            command.CommandText = $"UPDATE Stocks" +
                $" SET stock = stock - @quantity" +
                $" WHERE itemId = @itemId";
            

            //connection
            dBAccess.DbConnect();

            command.Connection = dBAccess.Connection;


            //クエリ実行
            int num = command.ExecuteNonQuery();

            //close
            dBAccess.DbClose();

            return num;
            


        }
    }
}
