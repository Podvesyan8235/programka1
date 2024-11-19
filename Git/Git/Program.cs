using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вызов методов
            int sum = AddTwoNumbers(5, 7);
            Console.WriteLine("Сумма чисел: " + sum);

            GreetUser("Алексей");

            // Работа с классом Пользователь
            User user = new User();
            user.Name = "Иван";
            user.Email = "ivan@example.com";
            user.Age = 25;

            Console.WriteLine($"Имя пользователя: {user.Name}");
            Console.WriteLine($"Email пользователя: {user.Email}");
            Console.WriteLine($"Возраст пользователя: {user.Age}");
            Console.ReadLine();
        }

        private static int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }


        public static void GreetUser(string name)
        {
            Console.WriteLine("Привет, " + name + "!");
        }

        class User
        {
            public string Name { get; set; }   // Имя пользователя
            public string Email { get; set; } // Email пользователя
            public int Age { get; set; }      // Возраст пользователя
        }

        

    }
}
