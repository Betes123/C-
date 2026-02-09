using System;

class ViTrung
{
    static int soluong;
    static int thoigian;
    public static int Sum()
    {
        Console.WriteLine("nhap so luong vi trung: ");
        soluong = int.Parse(Console.ReadLine()!);
        Console.WriteLine("nhap so gio can tinh: ");
        thoigian = int.Parse(Console.ReadLine()!);
        for(int i = 0; i < thoigian; i++)
        {
            soluong = soluong*2; 
        }
        return soluong;
    }
}