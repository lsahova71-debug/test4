using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ugaday_chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 100);
            bool guessed = false;
            Console.WriteLine("Добро пожаловать в игру 'угадай число!' ");
            Console.WriteLine("Я загадал число от 1 до 100 ");
            while(!guessed)
            {
                try
                {
                    Console.WriteLine("Введи число:");
                    string userinput = Console.ReadLine();
                    int guess = Convert.ToInt32(userinput);
                    if(guess<1 || guess>100)
                    {
                        Console.WriteLine("Пожалуйста, введи число в диапозоне от 1 до 100");
                        continue;
                    }
                    if(guess<number)
                    {
                        Console.WriteLine("Загаданное число больше. Попробуй еще раз");
                    }
                    else if(guess > number)
                    {
                        Console.WriteLine("Загаданоое число меньше. Попробуй еще");
                    }
                    else
                    {
                        guessed = true;
                        Console.WriteLine($"\n Поздравляю, ты угадал число!");
                        Console.ReadLine();
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Ошибка! Пожалуйста, введи целое число");
                }
               
            }
        }
    }
}
