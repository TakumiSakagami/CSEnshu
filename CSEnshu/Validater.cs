using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEnshu
{
    class Validater
    {
        /// <summary>
        /// 個数が空文字列か調べる
        /// 空文字列の場合trueを返す
        /// </summary>
        /// <param name="strNum"></param>
        /// <returns></returns>
        public bool IsNull(String strNum)
        {
            if (strNum.Equals(""))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 引数が数字に変換できるか調べるメソッド
        /// 引数に数字以外が代入されると0を返却
        /// 引数がマイナスの場合は-1を返却
        /// </summary>
        /// <param name="strNum"></param>
        /// <returns>num</returns>
        public int IsNum(String strNum)
        {
            int num;
            try
            {
                num = Convert.ToInt32(strNum);
            }
            catch (FormatException)
            {
                return 0;
            }

            if (num <= 0)
            {
                return -1;
            }

            return num;
        }
        
        /// <summary>
        /// 注文量が現在庫よりも少ないか調べる
        /// 少なければtrueを返す
        /// </summary>
        /// <param name="currentStock"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public bool stockCheck(int currentStock, int quantity)
        {
            if (currentStock < quantity)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
