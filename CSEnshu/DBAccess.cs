using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEnshu
{
    class DBAccess
    {
        //フィールドでコネクションを作成
        SqlConnection connection = new SqlConnection();


        /// <summary>
        /// DBにアクセス
        /// </summary>
        private void DbConnect()
        {

            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbEnshu.Properties.Settings.SQLConnection"].ConnectionString;

            connection.Open();
        }
        /// <summary>
        /// DBをクローズ
        /// </summary>
        private void DbClose()
        {
            connection.Close();
        }
    }
}
