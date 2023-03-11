using FitnessApp.BL.Controller;
using System;

namespace FitnessApp.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует FitnessApp.");

            Console.WriteLine("Введите имя пользователя.");
            var name = Console.ReadLine();

            Console.WriteLine("Введите пол.");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождния.");
            var birthdata = DateTime.Parse(Console.ReadLine()); //TODO: Переписать.

            Console.WriteLine("Введите вес.");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост.");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthdata, weight, height);
            userController.Save();
            
        }
    }
}
