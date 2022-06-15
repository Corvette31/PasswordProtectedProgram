using System;

namespace PasswordProtectedProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "12345";
            string usetInput;
            int tryCount = 3;
            bool isAuthorized = false;

            Console.Write("Введите пароль для доступа к тайному сообщению : ");

            for (int i = 1; i <= tryCount; i++)
            {
                usetInput = Console.ReadLine();

                if (usetInput == password)
                {
                    Console.WriteLine("Это тайное сообщение!!!");
                    isAuthorized = true;
                    break; 
                }
                else
                {
                    Console.WriteLine($"Не верный пароль! У вас осталось {tryCount - i} попыток");
                }
            }

            if (isAuthorized == false)
            {
                Console.WriteLine($"Вы {tryCount} раза ввели не верный пароль! Данная программа самоуничтожится!");
            }
        }
    }
}
