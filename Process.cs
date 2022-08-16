using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTwo
{
    internal class EvenNumberAddition
    {

        /// <summary>
        /// A method to add the even numbers between 1 and 5000
        /// A callback function using func delegate to return the percentage left
        /// </summary>
        /// <param name="cb"></param>
        public void EvenAdd()
        {
            Func<int, int> percentDone = EvenNumAddCallback;

            int evenSum = 0;
            for (int i=0; i < 5000; i++)
            {
                Console.WriteLine($"{100- percentDone(i)}% to go");
                if (((i+1) % 2) == 0)
                {
                    evenSum += i + 1;
                }
            }
            Console.WriteLine($"The sum of the even numbers between 1 and 5000 is { evenSum}");
        }
        int EvenNumAddCallback(int progress)
        {
            return progress/50;
        }

    }
}
