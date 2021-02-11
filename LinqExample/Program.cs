using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
          

            var names = new List<string> { "Jon", "Tom", "Bob", "Jeffensy", "Freddy", "Al", "MaryPoppins", "Tonya", "Henderson" };

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };





            //var sumOfNumbers = numbers.Count();

            //Console.WriteLine(sumOfNumbers);

            Console.WriteLine("Numbers divisble by 3");
            var numbersDivisibleByFive = numbers.Where(num => num % 5 == 0);


            foreach(var num in numbersDivisibleByFive)
            {
                
               
                    Console.WriteLine(num);
               
            }
            Console.WriteLine("...............");

            var doggyAge = numbers.Select(y => y * 7);
            Console.WriteLine("ages in dog years");

            foreach (var dog in doggyAge)
            {
                Console.WriteLine(dog);
            }
            Console.WriteLine("...............");
            Console.WriteLine("Smallest number");
            Console.WriteLine(numbers.Min());
            Console.WriteLine("...............");





            //foreach(var num in numbersDivisibleByThree)
            //{
            //    Console.WriteLine(num);
            //}




            Console.WriteLine("Order by name length descending");
            var nameLength = names.OrderByDescending(name => name.Length);

            foreach(var name in nameLength)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("..........................................................");





            names.Append("Freddy Mercury");

            Console.WriteLine("The two winners are:");
            var random = new Random();
            var lotterywinner = random.Next(9);
            foreach(var name in names.Skip(lotterywinner).Take(2))
            {
                Console.WriteLine(name);
            }

          
        }

       




        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

    }
}
