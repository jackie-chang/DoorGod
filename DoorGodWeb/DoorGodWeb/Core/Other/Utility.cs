using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoorGodWeb.Core
{
    public class Utility
    {
        /// <summary>
        /// Class轉換陣列(物件屬性順序必須跟webService所接受的陣列位置一樣)
        /// </summary>
        /// <param name="aryLenght">陣列大小</param>
        /// <param name="obj">需轉換的Class</param>
        /// <returns></returns>
        public static string[] ConvertToGeneralArray(int aryLenght, object obj)
        {
            //取得object的type
            Type t = obj.GetType();

            //判斷是否為Class
            if (!t.IsClass || t.IsGenericType) return null;

            //取得此物件的所有Property
            System.Reflection.PropertyInfo[] properties = t.GetProperties();

            //初始化
            int i = 0;
            string[] result = new string[aryLenght];
            
            foreach (var p in properties)
            {                
                if (i < aryLenght)
                {
                    //按順序取出Reflect屬性的值
                    result[i] = p.GetValue(obj, null).ToString();
                    i++;
                }
            }
            return result;
        }
    }
}