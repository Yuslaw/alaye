using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chapter16
{
    public class question3
    {
        public static void AnsThree()
        {
            List<int> result = new List<int>();
            int sort =0;
            for(int i =0; true; i++)
            {
                Console.WriteLine("Enter number: ");
                string number = Console.ReadLine();
                if(number != string.Empty)
                {
                    int secondNum= int.Parse(number);
                    result.Add(secondNum);
                   
                }
                else break;
                

            }
            for(int j = 0; j<result.Count; j++)
            {
                for(int k = j+1;  k<result.Count; k++)
                {
                    if(result[j]>result[k])
                    {
                        sort =result[j];
                        result[j] = result[k];
                        result[k] = sort;
                    }
                }
            }
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

        }
        
    }
}