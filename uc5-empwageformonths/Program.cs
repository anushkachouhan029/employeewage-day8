﻿namespace EmployeeWageComputation
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NO_OF_WORKING_DAYS = 22;
        static void Main(string[] args)
        {
            //Variables

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            //computation

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            totalEmpWage = empWage * NO_OF_WORKING_DAYS;
            Console.WriteLine("Total working hours : " + empHrs * NO_OF_WORKING_DAYS);

            Console.WriteLine("Total Emp Wage : " + totalEmpWage);

        }
    }
}