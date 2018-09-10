using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Task1Console
{
    class Program
    {
        public static void StartCar(Car car)
        {
            if (car.engine.EngineStatus == false)
            {
                car.engine.StartEngine();
                Console.WriteLine("Двигатель заведён");
                car.StartMoveWheels();
                Console.WriteLine("Колеса начали двигаться");
            }
        }
        public static void TurnOffCar(Car car)
        {
            if (car.engine.EngineStatus == true)
            {
                car.StopMoveWheels();
                Console.WriteLine("Колеса остановились");
                car.engine.OffEngine();
                Console.WriteLine("Двигатель выключен");
            }
        }
        static void Main()
        {
            Car car = new Car();
            string modelCar = car.Models;
            while (true)
            {
                string choice = "";
                Console.WriteLine("Выберите действие: ехать, заправляться, менять колесо, вывести марку автомобиля, выход");
                try
                {
                    choice = Console.ReadLine();
                    if (choice == "ехать")
                    {
                        StartCar(car);
                    }
                    if (choice == "заправляться")
                    {
                        TurnOffCar(car);
                        Console.WriteLine("Идёт заправка...");
                        car.Refuel();
                        Console.WriteLine("Бак ПОЛОН, хотите продолжить движение после заправки,тогда напишите все что угодно, если нет то пропустите ввод?");
                        string checkStart = Console.ReadLine();
                        if (checkStart != "")
                        {
                            StartCar(car);
                        }

                    }
                    if (choice == "менять колесо")
                    {
                        TurnOffCar(car);
                        Random rnd = new Random();
                        int randomNumber = rnd.Next(0, 4);
                        car.wheels.RemoveAt(randomNumber);
                        car.AddWheel();
                        Console.WriteLine("Колесо {0} заменено", randomNumber);
                        StartCar(car);
                    }
                    if (choice == "вывести марку автомобиля")
                    {
                        Console.WriteLine(modelCar);
                        Console.ReadLine();
                    }
                    if(choice == "выход")
                    {
                        break;
                    }
                }
                catch(Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Для корректной работы выберите одну команду из предоставленных");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear();
                    Main();
                }
            }
        }
    }
}
