using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        double Ax = Convert.ToDouble(Console.ReadLine());
        double Ay = Convert.ToDouble(Console.ReadLine());
        double Bx = Convert.ToDouble(Console.ReadLine());
        double By = Convert.ToDouble(Console.ReadLine());
        double Cx = Convert.ToDouble(Console.ReadLine());
        double Cy = Convert.ToDouble(Console.ReadLine());
        double Dx = Convert.ToDouble(Console.ReadLine());
        double Dy = Convert.ToDouble(Console.ReadLine());
        double kAB = (Ay - By) / (Ax - Bx);
        double bAB = Ay - Ax * kAB;
        double kCD = (Cy - Dy) / (Cx - Dx);
        double bCD = Cy - Cx * kCD;
        if (kAB == kCD)
        {
            Console.WriteLine("Прямые не пересекаются.");
        }
        else
        {
            double pointX = (bCD - bAB) / (kAB - kCD);
            double pointY = pointX * kAB - bAB;
            Console.WriteLine($"(x, y) = ({pointX}, {pointY})");
        }
    }
}