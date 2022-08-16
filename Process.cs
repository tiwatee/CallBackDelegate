using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTwo
{
    internal class EvenNumberAddition
    {
        public delegate void EvenNumberAdd (int count);

        /// <summary>
        /// A method to add the even numbers between 1 and 5000
        /// </summary>
        /// <param name="cb"></param>
        public static void EvenAdd(EvenNumberAdd cb)
        {
            int evenSum = 0;
            for (int i=0; i < 5000; i++)
            {
                if (((i+1) % 2) == 0)
                {
                    evenSum += i + 1;
                }
                cb(i + 1);
                //if (((i+1) % 10) == 0)
                //{
                //    cb(i + 1);
                //}
            }
            Console.WriteLine($"The sum of the even numbers between 1 and 5000 is { evenSum}");
        }
        public static void EvenNumAddCallback()
        {
            EvenNumberAdd evenNumAdd = delegate (int percent)
            {
                var answer = percent / 100;
                Console.WriteLine(answer);
            };
        }

    }
}
