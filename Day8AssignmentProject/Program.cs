using System;
// check employee Wage on part time or full time
class Program
{
    public void fullOrPartEmp()
    {
        //constants
        int IS_FULL_TIME = 1;
        int EMP_RATE_PER_HOUR = 20;
        int IS_PART_TIME = 2;

        // Variables
        int emphrs = 0;
        int empwage = 0;

        Random random = new Random();

        int empCheck = random.Next(0, 3);
        if (empCheck == IS_FULL_TIME)
        {
            emphrs = 8;
        }
        else if (empCheck == IS_PART_TIME)
        {
            emphrs = 4;
        }
        else
        {
            emphrs = 0;
        }
        empwage = emphrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("emp Wage: " + empwage);
    }
    static void Main(string[] args)
    {
        Program fullPart=new Program();
        fullPart.fullOrPartEmp();
        
    }
}