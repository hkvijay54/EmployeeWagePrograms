using System;
// check employee pesent or not
class Program
{
    public void empChek()
    {
        //constants
        int IS_FULL_TIME = 1;
        Random random = new Random();

        int empCheck = random.Next(0, 2);
        if (empCheck == IS_FULL_TIME)
        {
            Console.WriteLine("Employee is Present = " + empCheck);
        }
        else
        {
            Console.WriteLine("Employee is absent = " + empCheck);
        }
    }
    static void Main(string[] args)
    {
        Program emp = new Program();
        
        emp.empChek();
    }
}