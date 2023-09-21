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
        Vector2 AB = new Vector2((float)(Bx - Ax), (float)(By - Ay));
        Vector2 CD = new Vector2((float)(Dx - Cx), (float)(Dy - Cy));
        Vector2 AC = new Vector2((float)(Cx - Ax), (float)(Cy - Ay));
        Vector2 AD = new Vector2((float)(Dx - Ax), (float)(Dy - Ay));
        float ProductACCD = AC.X * CD.Y - AC.Y * CD.X;
        float ProductADCD = AD.X * CD.Y - AD.Y * CD.X;
        if (ProductACCD <= 0 && ProductADCD <= 0)
        {
            float Ox = (float)(Cx) + ((float)(Dx) - (float)(Cx)) * Math.Abs(ProductACCD) / Math.Abs(ProductADCD - ProductACCD);
            float Oy = (float)(Cy) + ((float)(Dy) - (float)(Cy)) * Math.Abs(ProductACCD) / Math.Abs(ProductADCD - ProductACCD);
            Console.WriteLine(Ox + ", " + Oy);
        }
        else
        {
            Console.WriteLine("Не пересекаются");
        }
    }
}