﻿using System;

namespace EmployeeAttendance
{
    class Program
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;
        public const int rate_per_hour = 20;
        public const int num_of_working_days = 2;
        static void Main(string[] args)
        { 
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < num_of_working_days; day++)
            {


                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case is_part_time:
                        empHrs = 4;
                        break;
                    case is_full_time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * rate_per_hour;
                totalEmpWage = totalEmpWage + empWage;
                Console.WriteLine("Emp Wage : " + empWage);
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}
