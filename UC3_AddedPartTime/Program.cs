﻿namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1, partTime = 0, emp_Rate_Per_Hr = 20, empHrs = 0, empWage = 0;
            for (int i = 0; i< 10; i++)
            {
                Random rannum = new Random();
                int checkPresent = rannum.Next(0, 3);
                Console.WriteLine("Random Number: " + checkPresent);
                switch (checkPresent)
                {
                    case 1:
                        empHrs = 8;
                        Console.WriteLine("Employee is Present Full TIme");
                        break;
                    case 2:
                        empHrs = 4;
                        Console.WriteLine("Employee is Present Part Time");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                empWage = empHrs * emp_Rate_Per_Hr;
                Console.WriteLine("Employee Wage: " + empWage);
            }
        }
    }
}