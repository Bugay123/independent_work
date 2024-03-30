using System;
using System.Collections.Generic;
using System.Text;

namespace ChildTrackerApp
{
    class Child
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Child(string name, int age, double height, double weight)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }
    }

    class Program
    {
        static Stack<Child> childStack = new Stack<Child>();
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Додаток для відстеження росту та розвитку дітей");

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Додати дані дитини");
                Console.WriteLine("2. Подивитись дані дітей зі списку");
                Console.WriteLine("3. Вихід");
                Console.Write("Введіть цифру вибору: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddChild();
                            break;
                        case 2:
                            ViewChildGrowth();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Неправильний вибір. Спробуйте ще");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Неправильний вибір. Спробуйте ще");
                }
            }
        }

        static void AddChild()
        {
            Console.WriteLine("\nВведіть дані дитини:");
            Console.Write("Ім'я: ");
            string name = Console.ReadLine();

            Console.Write("Вік: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Зріст (cm): ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Вага (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Child child = new Child(name, age, height, weight);
            childStack.Push(child);

            Console.WriteLine("Дані дитини додані в систему!");
        }

        static void ViewChildGrowth()
        {
            Console.WriteLine("\nІнформація про дітей:");
            Console.WriteLine("---------------------");

            foreach (Child child in childStack)
            {
                Console.WriteLine($"Name: {child.Name}");
                Console.WriteLine($"Age: {child.Age}");
                Console.WriteLine($"Height: {child.Height} cm");
                Console.WriteLine($"Weight: {child.Weight} kg");
                Console.WriteLine();
            }
        }
    }
}

