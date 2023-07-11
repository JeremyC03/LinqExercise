using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum of numbers:");
            Console.WriteLine(numbers.Sum());
            Console.WriteLine();

            //TODO: Print the Average of numbers
            Console.WriteLine("Average of numbers:");
            Console.WriteLine(numbers.Average());
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Numbers in ascending order:");
            var ascendingOrder = numbers.OrderBy(x => x);
            foreach (int item in ascendingOrder)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine("Numbers in descending order:");
            var descendingOrder = numbers.OrderByDescending(x => x);
            foreach (int item in descendingOrder)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers greater than 6:");
            var greaterThanSix = numbers.Where(x => x > 6);
            foreach (int item in greaterThanSix)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Four numbers in ascending order:");
            var fourNumbers = numbers.Where(x => x > 2 && x < 7);
            foreach (int item in fourNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("Numbers in descending order with age:");
            numbers[4] = 28;
            var ageDescendingOrder = numbers.OrderByDescending(x => x);
            foreach (int item in ageDescendingOrder)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Employee names starting with C or S in ascending order.");
            var namesCS = employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S').OrderBy(x => x.FirstName);
            foreach(Employee item in namesCS)
            {
                Console.WriteLine(item.FullName);
            }
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Employee names and age over 26.");
            var fullNameAge = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var item in fullNameAge)
            {
                Console.WriteLine($"Name: {item.FullName} - Age: {item.Age}");
            }

            Console.WriteLine();

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Sum and average of employees' work experience <= 10 and age > 35");
            var workExperienceSum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            var workExperienceAverage = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine($"Sum: {workExperienceSum}");
            Console.WriteLine($"Average: {workExperienceAverage}");
            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("Added employee");
            Employee newEmployee = new Employee() { FirstName = "Jeremy", LastName = "Cabrera"};
            var temp = employees.Append(newEmployee);
            foreach(var item in temp)
            {
                Console.WriteLine(item.FullName);
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
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
        #endregion
    }
}
