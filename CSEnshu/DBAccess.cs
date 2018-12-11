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

        public SqlConnection Connection { get { return connection; } }
        /// <summary>
        /// DBにアクセス
        /// </summary>
        public void DbConnect()
        {

            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CSEnshu.Properties.Settings.CSEnshu"].ConnectionString;

            connection.Open();
        }
        /// <summary>
        /// DBをクローズ
        /// </summary>
        public void DbClose()
        {
            connection.Close();
        }
    }
}
