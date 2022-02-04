using System;

namespace HomeworkFive_TaskTwo
{
    class Program
    {
        static string[] ReversWords(string inputPhrase)
        {
            string[] splitedText = SplitText(inputPhrase);
            Array.Reverse(splitedText);
            string[] reversedText = splitedText;
            return reversedText;
        }
        static string[] SplitText(string inputPhrase)
        {
            string[] splitedText = inputPhrase.Split(' ');
            return splitedText;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string inputText = Console.ReadLine();
            string[] newText = ReversWords(inputText);
            Console.WriteLine("Перевернутое предложение:");
            foreach (string element in newText) 
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
            
        }
    }
}
