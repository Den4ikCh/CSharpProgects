using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string Result = AddLongNumbers(a, b);
        Console.WriteLine(Result);
    }

    static string AddLongNumbers(string a, string b)
    {
        char[] achars = a.ToCharArray();
        char[] bchars = b.ToCharArray();
        int[] aints = new int[achars.Length];
        int[] bints = new int[bchars.Length];
        for (int i = 0; i < achars.Length; i++)
        {
            aints[i] = (int)Char.GetNumericValue(achars[i]);
        }
        for (int i = 0; i < bchars.Length; i++)
        {
            bints[i] = (int)Char.GetNumericValue(bchars[i]);
        }
        int x = achars.Length;
        int y = bchars.Length;
        char NameMax = '0';
        int min = (int)MathF.Max(x, y);
        int max = (int)MathF.Max(x, y);
        if (max == y)
        {
            NameMax = 'b';
        }
        else
        {
            NameMax = 'a';
        }
        int[] resints = new int[max];
        int diff = max - min;
        char[] result = new char[max]; 
        for (int i = 0; i < max; i++)
        {
            if (NameMax == 'a')
            {
                resints[i] = aints[i];
                if (i >= diff)
                {
                    resints[i] += bints[i - diff];
                }
            }
            else
            {
                resints[i] = bints[i];
                if (i >= diff)
                {
                    resints[i] += aints[i - diff];
                }
            }
        }
        for (int i = resints.Length - 1; i >= 0; i--)
        {
            if (resints[i] > 9 & i != 0)
            {
                resints[i] -= 10;
                resints[i - 1]++;
            }
        }
        bool isMoreSymbols = false;
        if (resints[0] > 9)
        {
            isMoreSymbols = true;
            resints[0] -= 10;
        }
        for (int i = 0; i < max; i++)
        {
            result[i] = (char)(resints[i] + 48);
        }
        string Result = new string(result);
        if (isMoreSymbols)
        {
            Result = "1" + Result;
        }
        return Result;
    }
}