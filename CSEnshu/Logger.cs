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

        //log 作成メソッド
        public void WriteLine(List<OrderDto> orderList)
        {
            var writer = new StreamWriter(@"c:\samples\log.csv");
            
            for(int i = 0;i< orderList.Count;i++)
            {

                log = orderList[i].ItemId + "," + orderList[i].CustomerId + "," + orderList[i].Quantity + "," + orderList[i].Date;

                writer.WriteLine(log);

            }

        }

    }
}
