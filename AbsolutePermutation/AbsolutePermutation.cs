
using System;

public class AbsolutePermutation
{

    public static Boolean checkInputValues(int n, int k)
    {
        if (k != 0)
        {
            return checkDivisionPositinAndElement( n,  k);
        }
        return true;
    }

    public static Boolean checkDivisionPositinAndElement(int n, int k)
    {
        if (n % k == 0 && n / k % 2 == 0)
        {
            return true;
        }
        return false;
    }
    
    public static int divisonValueForPosition(int value, int positon)
    {
        return value == 0 ? positon : positon / value;
    }
    public static int calculateValuePermutation(int value, int position)
    {
        return position + 1 + (divisonValueForPosition(value, position) % 2 == 0 ? value : -value);
    }
    public static int[] absolutePermutation(int n, int k)
    {
        
        int[] result; 
        if (checkInputValues(n, k))
        {
            result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = calculateValuePermutation(k, i);
            }
        }
        else
        {
            result =new int[1] {-1} ;
        }
        return result;
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nk = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);
            Console.WriteLine(string.Join(" ", absolutePermutation(n, k)));
        }
        Console.Read();
    }
}
