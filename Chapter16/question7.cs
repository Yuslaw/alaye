using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chapter16
{
    public class question7
    {
        public static void AnsSeven()
        {

           Hashtable num = new Hashtable();
           List<int> results = new List<int>(){3, 4, 4, 2, 3, 3, 4, 3, 2};
            foreach(var item in results)
            {
                if(num.ContainsKey(item))
                {
                    num[item]= (int)num[item]+1;
                }
                else num.Add(item, 1);

            }
            foreach(DictionaryEntry item in num)      
            {
                Console.Write($"{item.Key} appears {item.Value}");
                Console.WriteLine();
            }
            Console.WriteLine();
        
        }
        
    }
}