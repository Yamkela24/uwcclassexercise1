using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    internal class Vowels
    {
        private static bool IsAVowel( char letter)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < vowels.Length; i++)
            {
                if (vowels[i] == letter)
                {
                    return true;
                }
                
            }
            return false;
        
        }

        public static string RemoveallVowels(string letters)
        {
            string returnString = " ";
            for (int index = 0; index < letters.Length; index++)
            {
                char letter = letters[index];
                bool vowel = IsAVowel( letter );

                if (!vowel)
                {
                    returnString += letter;
                }
            }
            return returnString;
        }




    }

}
