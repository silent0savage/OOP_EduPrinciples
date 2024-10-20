using System;
using TestEdu;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Выберите программу для запуска:");
            Console.WriteLine("1. Программа инкапсуляции (BankAccount)");
            Console.WriteLine("2. Программа наследования (Employee)");
            Console.WriteLine("3. Программа полиморфизма (Animal)");
            Console.WriteLine("4. Программа абстракции (Vehicle)");
            Console.WriteLine("5. Выход");
            Console.Write("Ваш выбор: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Пример инкапсуляции
                    BankAccount account = new BankAccount(100);
                    account.Deposit(50);
                    Console.WriteLine($"Баланс: {account.GetBalance()}");
                    break;

                case "2":
                    // Пример наследования
                    Employee emp1 = new Manager("Alice");
                    Employee emp2 = new Developer("Bob");
                    emp1.Work();
                    emp2.Work();
                    break;

                case "3":
                    // Пример полиморфизма
                    Animal[] animals = { new Dog(), new Cat() };
                    foreach (Animal animal in animals)
                    {
                        animal.Speak();
                    }
                    break;

                case "4":
                    // Пример абстракции
                    TransportService transportService = new TransportService();
                    IVehicle vehicle = new Car();
                    transportService.StartTrip(vehicle);
                    vehicle = new Bicycle();
                    transportService.StartTrip(vehicle);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Выход из программы.");
                    break;

                default:
                    Console.WriteLine("Неверный выбор, попробуйте еще раз.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
