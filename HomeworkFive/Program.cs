using System;

namespace HomeworkFive
{
    class Program
    {
        static void PrintText(string text)
        {
            Console.WriteLine(text);
        }

        static string[] SplitText (string text)
        {
            string[] splitText = text.Split(' ');
            return splitText;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string inputText = Console.ReadLine();
            string[] lines = SplitText(inputText);
            Console.WriteLine("Вывод приложения:");
            foreach (string element in lines)
            {
                PrintText(element);
            }

            

        }
    }
}
