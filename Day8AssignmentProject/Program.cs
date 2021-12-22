using System;

class Program
{
    public void line()
    {
        Console.WriteLine("Enter two pairs of number (x1,y1)(x2,y2)");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());
        double diffx = Math.Pow((x2 - x1), 2);
        double diffy = Math.Pow((y2 - y1), 2);
        double res = Math.Sqrt(diffx + diffy);
        Console.WriteLine(res);
    }
    static void Main(string[] args)
    {
        Program l= new Program();
        l.line();
    }
}