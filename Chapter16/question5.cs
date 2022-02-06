using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chapter16
{
    public class question5
    {
        
          public static void Ansfive()
          {
            List<int> num2 = new List<int>();
            List<int> num = new List<int>() {19, -10, 12, -6, -3, 34, -2, 5} ;
            for(int i =0; i<num.Count; i++)
            {
                if(num[i]> 0)
                {
                    num2.Add(num[i]);
                }
                
            }
            foreach(var item in num2)
            {
                Console.Write(item + " ");
            }
            
            

        }
           
                
            
           
          
        
    }
}