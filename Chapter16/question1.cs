using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chapter16
{
    public class question1
    {
        public static void AnsOne()
        { 
           
           
            List<int> results = new List<int>();
            int sum =0;
            for(int i =0; true; i++)
            {
                Console.WriteLine("Enter number: ");
                string number = Console.ReadLine();
                if(number != string.Empty)
                {
                    int secondNum= int.Parse(number);
                    results.Add(secondNum);
                    sum += secondNum;
                }
                else break;
                

            }
                Console.WriteLine($"sum:  {sum}");
                Console.WriteLine($"average sum:  {sum/2}");
        }
        
        
    }
}