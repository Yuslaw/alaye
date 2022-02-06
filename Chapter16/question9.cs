using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chapter16
{
    public class question9
    {
        public static void AnsNine()
        {
            List<int> results = new List<int>();
            int length= 50;
            int S1 = 2;
            results.Add(S1);
            for(int i=0; i<length; i++)
            {
                if(results.Count>=length)break;
                else
                {
                    int S2 = S1+1;
                    int S3 = 2 * S1+1;
                    int S4 = S1+2;
                    results.Add(S2);
                    results.Add(S3);
                    results.Add(S4);
                    S1 = results[i];
                }

                Queue dqueue = new Queue();
                    foreach(var item in results)
                    {
                        if(dqueue.Count==length)break;
                        else
                        {
                            dqueue.Enqueue(item);
                        }
                    }

                    foreach(var item in dqueue)
                    {
                        Console.Write($"{item},");
                    }
            }
        }
        
    }
}