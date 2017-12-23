using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hw15
{
    class Program
    {
        static void Main(string[] args)
        {
            taskOne();

            taskTwo();

            Console.ReadLine();
        }
        static void taskOne()
        {
            string text;
            using (StreamReader reader = new StreamReader(@"C:\name_of_folder\some_file.txt"))
            {
                text = reader.ReadToEnd();
            }

            //Console.WriteLine(text);

            string[] numbers = text.Split(' ');

            int countElements = numbers.Length;
            /*
             f(i) = f(i-1) + f(i-2) - формула Фибоначчи
             */

            for (int i = 0; i < countElements; i++)
            {
                numbers = text.Split(' ');

                //складываем два последних элемента для получения нового элемента последовательности Фибоначчи
                int lastElementFibonachi = int.Parse(numbers[numbers.Length - 2]) + int.Parse(numbers[numbers.Length - 1]);

                text = text + " " + lastElementFibonachi;
            }

            using (StreamWriter writer = new StreamWriter(@"C:\name_of_folder\some_file.txt"))
            {
                writer.Write(text);
            }
        }
        static void taskTwo()
        {
            string text;
            using (StreamReader reader = new StreamReader(@"C:\name_of_folder\input.txt"))
            {
                text = reader.ReadToEnd();
            }

            string[] numbers = text.Split(' ');

            int sum = int.Parse(numbers[0]) + int.Parse(numbers[1]);

            using (StreamWriter writer = new StreamWriter(@"C:\name_of_folder\output.txt"))
            {
                writer.Write(sum + "");
            }
        }
    }
}