using System;


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
           
            
           
        }
    }
}   
