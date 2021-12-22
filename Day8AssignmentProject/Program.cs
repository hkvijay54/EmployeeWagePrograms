using System;
// check two lines are identical.

class Calcu
{
    public int a, b, c, d;

    public Calcu(int x1, int y1, int x2, int y2)
    {
        this.a = x1;
        this.b = y1;
        this.c = x2;
        this.d = y2;
    }
    public double Result()
    {
        double diffx = Math.Pow((c - a), 2);
        double diffy = Math.Pow((d - b), 2);
        double res = Math.Sqrt(diffx + diffy);
        return res;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Calcu c = new Calcu(1, 1, 5, 5);
        Calcu d = new Calcu(2, 2, 6, 6);
        double output1 = c.Result();
        double output2 = d.Result();
        Console.WriteLine("is two lines idetical? " + output1.Equals(output2));
        Console.WriteLine(output1 + " and " + output2);
    }
}