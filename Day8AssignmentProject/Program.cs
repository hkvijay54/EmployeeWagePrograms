using System;
// Calculate Wages till a condition of total working hours or
// days is reached for a month

class Employee
{
    public void empWage()
    {
        //constants
        const int IS_FULL_TIME = 1;
        int EMP_RATE_PER_HOUR = 20;
        const int IS_PART_TIME = 2;
        const int NUM_OF_WORKING_DAYS = 20;
        const int MAX_HRS_IN_MONTH = 100;

        // Variables
        int emphrs = 0;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;

        while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
        {
            totalWorkingDays++;
            Random random = new Random();

            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IS_FULL_TIME:
                    emphrs = 8;
                    break;
                case IS_PART_TIME:
                    emphrs = 4;
                    break;
                default:
                    emphrs = 0;
                    break;
            }
            totalEmpHrs = totalEmpHrs + emphrs;
            Console.WriteLine("Working day " + totalWorkingDays + " Employee hours " + emphrs);
        }
        int totalSalary = totalEmpHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine(" Total salary is " + totalSalary);
    }
}


class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.empWage();
    }
}