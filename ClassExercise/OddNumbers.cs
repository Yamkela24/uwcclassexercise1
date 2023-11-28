using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    internal class OddNumbers
    {
        public static bool CheckOddNumers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];

                if (number % 2 > 0)
                {
                    return true;
                }
            }
            return false;
        }    
    }
}
