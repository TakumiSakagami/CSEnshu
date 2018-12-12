using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEnshu
{
    class Logger
    {
        private string log;
        OrderDao dao = new OrderDao();
        DateTime date;
       

        //log 作成メソッド
        public void WriteLine(List<OrderDto> orderList)
        {

            using (var writer = new StreamWriter(@"c:\samples\log.csv",false, System.Text.Encoding.GetEncoding("shift_jis")))

                for (int i = 0; i < orderList.Count; i++)
                {

                    log = orderList[i].ItemName + "," + orderList[i].CustomerName + "," + orderList[i].Quantity + "," + orderList[i].Date;

                    writer.WriteLine(log);

                }

        }

        public void OrderWrite(String itemName,String addStock)
        {


            date = DateTime.Now;
            using (var writer = new StreamWriter(@"c:\samples\addlog.csv", true, System.Text.Encoding.GetEncoding("shift_jis")))
            {

                log = $"{itemName},{addStock},{date}";

                writer.WriteLine(log);
            }
        }

    }
}
