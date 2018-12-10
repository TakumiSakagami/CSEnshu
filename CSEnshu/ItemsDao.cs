using System;

public class ItemsDao
{

    public List<Items> SearchItemsList()
    {

        SqlCommand command = new SqlCommand();


        //パラメータ設定
        command.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
        command.Parameters["@name"].value = itemSerarchBox.Text;

        command.CommandText = $"SELECT * FROM Items " +
                              $"set Name = @name " +
                              $"WHERE Name LIKE (N'%{itemSerarchBox}%') ";

        command.Connection = connection;
        //クエリの実行
        int num = command.ExecuteNonQuery();

    }
}