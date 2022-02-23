using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant5_topolja
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения гласных букв латинского алфавита в строку (не различая регистры).

            //List<string> vowels = new List<string> { "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y" };
            //double vowelCount = 0;
            //double result = 0;

            //Console.WriteLine("Your text");
            //string Text = Console.ReadLine();
            //char[] lText = Text.ToCharArray();

            //foreach (char item in lText)
            //{
            //    if (vowels.Contains(item.ToString()))
            //    {
            //        vowelCount += 1;
            //    }
            //}
            //Console.WriteLine($"Vowels are {Math.Round(result = vowelCount / lText.Length *100)}% of text");
            //Console.ReadLine();

            //2. Задан массив действительных чисел из N элементов (используйте генератор случайных чисел). Определить количество элементов, значения которых находятся в диапазоне от -100 до +100.

            //Random rnd = new Random();
            //List<int> numbers = new List<int>();
            //int count = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    numbers.Add(rnd.Next(-500, 500));
            //}
            //foreach (int item in numbers)
            //{
            //    Console.Write($"{item}, ");
            //    if (item>=-100 && item<=100)
            //    {
            //        count += 1;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Result: {count}");
            //Console.ReadLine();

            //3. Написать подпрограмму, которая вычисляет подоходный налог для введеной пользователем зарплаты.

            Console.WriteLine("Your salary");
            double salary = double.Parse(Console.ReadLine());
            double taxes = 0;

            if (salary<=500)
            {
                taxes = salary * 0;
            }
            else if (salary>500 && salary<=2100)
            {
                taxes = (salary - 500) / 5;
            }
            else
            {
                taxes = salary / 5;
            }
            Console.WriteLine($"You have to pay: {taxes}$");
            Console.ReadLine();
        }
    }
}
