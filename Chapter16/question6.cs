using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chapter16
{
    public class question6
    {
        public static void AnsSix()
        { 
           Hashtable num = new Hashtable();
           List<int> results = new List<int>() {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2};
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
            if((int)item.Value%2 ==0)
            {
                for(int i = 0; i< (int) item.Value; i++)
                {
                    Console.Write(item.Key + " ");
                }
            }    
        }

        }
        

        
    }
}