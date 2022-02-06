using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chapter16
{
    public class question4
    {
         public static void Ansfour()
         {
            List<int> result = new List<int>(){9,9,9,6,7,6,5,7,1};
            int count =0;
            int nextcunt = 0;
            int longest = 0;
            int check = 0;
            for(int i =1; i<result.Count; i++)
            {
                if(result[i]== result[i-1])
                {
                    count++;
                    nextcunt= count;
                   
                }
                else
                {
                    count=0;
                }
                if(nextcunt> longest)
                {
                    check = result[i-1];
                    longest = nextcunt;
                    nextcunt=0;
               }
            }
            List<int> number = new List<int>();
            for(int i=0; i<longest; i++)
            {
                number.Add(check);
                
            }
            foreach(var item in number)
            {
                Console.WriteLine(item);
            }
        }  

        
    }
}