namespace ClassExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 9 };
            bool isOddnumber =OddNumbers.CheckOddNumers(numbers);

            if (isOddnumber)
            {
                Console.WriteLine("The array contains an odd number" + isOddnumber);
            }
            else
            {
                Console.WriteLine("The array does not contain an odd number " + isOddnumber);
            }

            string letters = "Hello World";

            string removedVowelstring = Vowels.RemoveallVowels(letters);

            Console.WriteLine(removedVowelstring);

            
            int[] numbers2 = {-1, 2, 4, 6, 9 };
            string positivenegative = PositiveAndNegativeNumbers.JotNumbers(numbers2);
            Console.WriteLine(" " +positivenegative);


            {
                string words = "Learning programming is cool";
                string longestword = LongestWord.FindLongestWords(words);
                Console.WriteLine("The longest word is " +longestword);


            }
        }
    }
}
