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
           
        }
        
    }
}   
