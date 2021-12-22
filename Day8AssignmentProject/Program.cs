using System;
// check employee Wage on part time or full time monthly.
class Program
{
    public void mothlyWage()
    {
        //constants
        const int IS_FULL_TIME = 1;
        int EMP_RATE_PER_HOUR = 20;
        const int IS_PART_TIME = 2;
        const int NUM_OF_WORKING_DAYS = 20;

        // Variables
        int emphrs = 0;
        int empwage = 0;
        int totalSalary = 0;

        for (int day = 1; day <= NUM_OF_WORKING_DAYS; day++)
        {
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
            empwage = emphrs * EMP_RATE_PER_HOUR;
            totalSalary = totalSalary + empwage;
        }
        Console.WriteLine(" monthly salry is " + totalSalary);
    }
    static void Main(string[] args)
    {
        Program monthly=new Program();
        monthly.mothlyWage();
    }
}