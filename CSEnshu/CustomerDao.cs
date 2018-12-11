using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEnshu
{
    class CustomerDao
    {

        DBAccess access = new DBAccess();

        /// <summary>
        /// 顧客テーブルから検索を行う
        /// </summary>
        /// <param name="name">入力された文字列</param>
        /// <returns>検索された顧客全員</returns>
        public List<CustomerDto> SearchCustomerList(String name)
        {
            access.DbConnect();

            SqlCommand command = new SqlCommand();


            //パラメータ設定
            command.Parameters.Add("@customerName", SqlDbType.NVarChar, 50);
            command.Parameters["@customerName"].Value = "%"+name+"%";


            command.CommandText = $"SELECT * FROM Customers " +
                                  $"WHERE firstName LIKE @customerName " +
                                  $"AND lastName LIKE @customerName";



            command.Connection = access.Connection;
            //クエリの実行
            SqlDataReader reader;

            reader = command.ExecuteReader();
            List<CustomerDto> list = new List<CustomerDto>();

            //値の取得
            while (reader.Read())
            {
                string customerIdStr = reader["customerId"].ToString();
                string firstName = reader["firstName"].ToString();
                string lastName = reader["lastName"].ToString();

                int customerId = Convert.ToInt32(customerIdStr);

                CustomerDto customer = new CustomerDto(customerId, firstName, lastName);
                list.Add(customer);
            }

            access.DbClose();

            return list;

        }
    }
}
