using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    internal class PositiveAndNegativeNumbers
    {
        public static string JotNumbers(int[] numbers)
        {
            int positiveNumber = 0;
            int negativeNumber = 0;

            for (int i = 0; i < numbers.Length; i++)   
            {
                int number = numbers[i];

                if (number < 0)
                {
                    negativeNumber++;
                }
                else
                {
                    positiveNumber++;
                }
            }
            string outPut = "Total Positive: " + positiveNumber +" Total Negative: " + negativeNumber;

            return outPut;
        }
    }
}
