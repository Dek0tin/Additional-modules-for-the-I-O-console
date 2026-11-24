using System;
using System.Data;

namespace main
{
    class Program
    {
        static void Main()
        {
            //Task1 
            Console.Write("Введіть рік: ");

            int week =  Convert.ToInt32(Console.ReadLine());

            if(week % 400 == 0 || week % 4 == 0 && week % 100 != 0)
            Console.WriteLine("Високосний рік");
            else
                Console.WriteLine("Не високосний рік");
            


            //Task2
            Console.Write("Введіть число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num;i ++)
            {
               string spaces = new string(' ', num - i);

               string numbers = string.Concat(Enumerable.Repeat(num + " ", i));

               Console.WriteLine(spaces + numbers);
            }
           
            //Task4
            Console.Write("Введіть вираз: ");
                string input = Console.ReadLine();
 
                DataTable table = new DataTable();
                var result = table.Compute(input, "");

                int name = Convert.ToInt32(result);
        
                Console.WriteLine(name);


                Console.OutputEncoding = System.Text.Encoding.UTF8;


            //Task3
            int score = 0;

            
            string[] questions = {
                "Питання 1. які кольори у прапору України?",
                "Питання 2. в якому місті знаходиться ДТЕУ?",
                "Питання 3. Яка найбільша планета Сонячної системи?",
                "Питання 4. Скільки днів у високосному році?",
                "Питання 5. Яка мова програмування використовується для цього коду?"
            };

            
            string[,] options = {
                { "1.жовтий і блакитний", "2.червоний і зелений", "3.чорний і жовтий", "4.зелений і фіолетовий" },
                { "1.Винниця", "2.Київ", "3.Львів", "4.Одеса" },
                { "1.Земля", "2.Марс", "3.Юпітер", "4.Сатурн" },
                { "1.364", "2.365", "3.366", "4.367" },
                { "1.Python", "2.Java", "3.C++", "4.C#" }
            };

            
            int[] correctAnswers = { 1, 2, 3, 3, 4 };

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"Current User Score: {score}");
                Console.WriteLine(questions[i]);

             
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(options[i, j]);
                }

                Console.Write("Ваша відповідь (1-4): ");
                string inputs = Console.ReadLine();

              
                if (int.TryParse(inputs, out int userAnswer) && userAnswer == correctAnswers[i])
                {
                    Console.WriteLine("Correct answer");
                    score += 100; 
                }
                else
                {
                    Console.WriteLine("Wrong Answer");
                    Console.WriteLine("кінець програми.");
                    return; 
                }
            }

            Console.WriteLine($"Current User Score: {score}");
            Console.WriteLine("Вітаємо! Ви відповіли на всі питання. Кінець програми.");
           
        }
        
    }
}   
