using System;
using System.Data;

namespace main
{
    class Program
    {
        static void Main()
        {
            //Умовні інструкції
            Console.Write("Введіть рік: ");

            int week =  Convert.ToInt32(Console.ReadLine());

            if(week % 400 == 0 || week % 4 == 0 && week % 100 != 0)
            Console.WriteLine("Високосний рік");
            else
                Console.WriteLine("Не високосний рік");
            


            
            Console.Write("Введіть число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num;i ++)
            {
               string spaces = new string(' ', num - i);

               string numbers = string.Concat(Enumerable.Repeat(num + " ", i));

               Console.WriteLine(spaces + numbers);
            }
           
            Console.Write("enter an expression: ");
                string input = Console.ReadLine();
 
                DataTable table = new DataTable();
                var result = table.Compute(input, "");

                int name = Convert.ToInt32(result);
        
                Console.WriteLine(name);



                 Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            int score = 0;

            // --- Питання 1 ---
            Console.WriteLine("Питання 1: Скільки днів у тижні?");
            Console.WriteLine("1. 7");
            Console.WriteLine("2. 5");
            Console.WriteLine("3. 10");
            Console.WriteLine("4. 12");
            Console.Write("Ваша відповідь: ");
            
            string answer1 = Console.ReadLine();

            if (answer1 == "1")
            {
                Console.WriteLine("Correct answer");
                score += 100;
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine($"Current User Score: {score}\n");

            // --- Питання 2 ---
            Console.WriteLine("Питання 2, в якому місті знаходиться ДТЕУ?");
            Console.WriteLine("1. Вінниця");
            Console.WriteLine("2. Київ");
            Console.WriteLine("3. Львів");
            Console.WriteLine("4. Одеса");
            Console.Write("Ваша відповідь: ");
            
            string answer2 = Console.ReadLine();

            if (answer2 == "2") // Правильна відповідь — Київ (варіант 2)
            {
                Console.WriteLine("Correct answer");
                score += 100;
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine($"Current User Score: {score}\n");

            Console.WriteLine("кінець програми.");
           
        }
        
    }
}   
