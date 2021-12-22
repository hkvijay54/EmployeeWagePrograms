using System;
// check employee Wage on part time or full time using switch case.
class Program
{
    public void empswitch()
    {
        //constants
        const int IS_FULL_TIME = 1;
        int EMP_RATE_PER_HOUR = 20;
        const int IS_PART_TIME = 2;

        // Variables
        int emphrs = 0;
        int empwage = 0;

        Random random = new Random();

        int empCheck = random.Next(0, 3);

        switch (empCheck)
        {
            case IS_FULL_TIME:
                Console.WriteLine("Employee is full time");
                emphrs = 8;
                break;
            case IS_PART_TIME:
                Console.WriteLine("Employee is part time");
                emphrs = 4;
                break;
            default:
                Console.WriteLine("Employee is absent");
                emphrs = 0;
                break;
        }

        empwage = emphrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("emp Wage: " + empwage);
    }
    static void Main(string[] args)
    {
        Program empSwitch = new Program();
        empSwitch.empswitch();
    }
}