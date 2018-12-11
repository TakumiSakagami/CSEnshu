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

        public List<CustomerDto> SearchCustomerList(String name)
        {
            access.DbConnect();

            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();


            //パラメータ設定
            command.Parameters.Add("@itemName", SqlDbType.NVarChar, 50);
            command.Parameters["@itemName"].Value = name;

            command.CommandText = $"SELECT * FROM Customers " +
                                  $"WHERE customerName = @customerName " +
                                  $"AND itemName LIKE (N'%{name}%') ";



            command.Connection = connection;
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
