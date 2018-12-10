using System;

public class StocksDao
{
	public int AddStocks(int itemId,int inputStock)
	{
        SqlCommand command = new SqlCommand();

        command.Parameters.Add("@inputStocks", SqlDbType.int32);
        command.Parameters.Add("@itemId", SqlDbType.int32);

        command.Parameters["@inputStocks"].Value = addStockBox.Text;
        command.Parameters["@itemId"].Value = itemId;
        
        command.Connection = connection;

        command.CommandText = $"UPDATE StocksTable" +
            $" SET Stocks = Stocks + N'@inputStocks'" +
            $" WHERE ItemId = N'@itemId'";

        command.Connection = connection;
        //クエリ実行
        int num = command.ExecuteNonquery();

    }

    public int DecrementStocks(int itemId,int quantity)
    {

        SqlCommand command = new SqlCommand();

        command.Parameters.Add("@quantity", SqlDbType.int32);
        command.Parameters.Add("@itemId", SqlDbType.int32);

        command.Parameters["@quantity"].Value = orderBox.Text;
        command.Parameters["@itemId"].Value = itemId; 
        
        command.Connection = connection;

        command.CommandText = $"UPDATE StocksTable" +
            $" SET Stocks = Stocks - N'@quantity'" +
            $" WHERE ItemId = N'@itemId'";

        command.Connection = connection;
        //クエリ実行
        int num=command.ExecuteNonquery();



    }
}
