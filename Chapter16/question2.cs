using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chapter16
{
    public class question2
    {
        public static void AnsTwo()
        {
            Stack<int> st = new Stack<int>();
            Console.WriteLine("check occurence: ");
            int check = int.Parse(Console.ReadLine());
            for(int i=0; i<check; i++)
            {
                Console.WriteLine("enter number: ");
                int realNum = int.Parse(Console.ReadLine());
                st.Push(realNum);
            }
            foreach(var item in st)
            {
                Console.Write(item);
            }
        }
        
    }
}