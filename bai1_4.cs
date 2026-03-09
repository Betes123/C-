using System;
using System.Reflection.Metadata.Ecma335;

class Array
{
    public static int[] nhap()
    {
        Console.WriteLine("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        int[] a= new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"phan tu thu {i} la: ");
             a[i] = int.Parse(Console.ReadLine());
        }
        return a;
    }
}

class InArray
{
    public static int[] xuatmang()
    {
    int[] b = Array.nhap();
    for(int i=0;i<b.Length;i++){
        Console.Write(b[i] + " ");
        }
        Console.WriteLine(); 
        return b;
    }
}

class MAX
{
    public static int caonhattrongmang()
    {
        int[] c = InArray.xuatmang();
        int max= c[0];
        for(int i = 0; i < c.Length; i++)
        {
            if (max < c[i])
            {
                max=c[i];
            }
        }
        Console.Write($"Max la: {max}");
        return max;
    }
}