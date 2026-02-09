using System;

class Switch
{
    public static void vonglap()
    {
    Console.WriteLine("nhap so nguyen lan 1: ");
    int a = int.Parse(Console.ReadLine()!);
    Console.WriteLine("nhap so nguyen lan 2: ");
    int b = int.Parse(Console.ReadLine()!);
    Console.WriteLine("nhap mot ky tu(+ - * /): ");
    char ch = char.Parse(Console.ReadLine()!);

        switch (ch)
        {
            case '+':
            Console.WriteLine($"a + b = {a+b}");
            break;

            case '-':
            Console.WriteLine($"a - b = {a-b}");
            break;

            case '*':
            Console.WriteLine($"a * b = {a*b}");
            break;

            case '/':
                if (b == 0)
                {
                    Console.WriteLine("ERROR!");
                }
                else
                {
                    Console.WriteLine($"a / b = {a/b}");
                }
            break;

            default:
            Console.WriteLine("ky tu khong hop le!");
            break;
        }
    }
}