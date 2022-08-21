using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTwo
{
    public delegate int CallbackDelegate(int progress);
    internal class EvenNumberAddition
    {

        /// <summary>
        /// A method to add the even numbers between 1 and 5000
        /// A callback function using delegate to return the percentage left
        /// </summary>
        /// <param name="cb"></param>
        /// 
        
        public void EvenAdd(CallbackDelegate callbackDelegate)
        {
            int evenSum = 0;
            for (int i=0; i < 5000; i++)
            {
                Console.WriteLine($"{100- callbackDelegate(i)}% to go");
                if (((i+1) % 2) == 0)
                {
                    evenSum += i + 1;
                }
            }
            Console.WriteLine($"The sum of the even numbers between 1 and 5000 is { evenSum}");
        }


        //callback method
        public int EvenNumAddCallback(int progress)
        {
            return progress / 50;
        }
    }
}
