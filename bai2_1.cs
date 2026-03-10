using System;
using Microsoft.VisualBasic;

namespace two_one {
    // khai bao phan so
    class PSo
{
    private int _tuso;
    private int _mauso;

    public int Tuso
    {
        get {return _tuso; }
        set {_tuso =value; }
    }
    public int MauSo
    {
        get {return _mauso; }
        set {_mauso = value; }
    }

    public PSo(int ts, int ms)
    {
         _tuso = ts;
         _mauso = ms;
    }

    public PSo(PSo p)
        {
            _tuso = p._tuso;
            _mauso = p._mauso;
        }

    public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            _tuso = int.Parse(Console.ReadLine()!);
            do
            {
                 Console.Write("Nhap mau so (khac 0): ");
            _mauso = int.Parse(Console.ReadLine()!);
        }while(_mauso == 0);
        }
    public void Xuat()
        {
            Console.WriteLine($"{_tuso} / {_mauso}");
        }
      public int UCLN(int a,int b)
        {
            while(b != 0)
            {
                int r= a%b;
                a=b;
                b=r;
            }
            return a;
        }
    public void Toigian()
        {
            int a = UCLN(_tuso,_mauso);
            _tuso/= a;
            _mauso/=a;
        }
    // a/b + c/d
    public PSo Cong(PSo p)
        {
           int ts = _tuso * p._mauso + p._tuso * _mauso;
           int ms = _mauso * p._mauso;

           PSo ketqua = new PSo(ts,ms);
           ketqua.Toigian();

           return ketqua;
        }

    public PSo Tru(PSo p)
        {
            int ts = _tuso * p._mauso - p._tuso * _mauso;
            int ms = _mauso * p._mauso;
            PSo ketqua = new PSo(ts,ms);
            ketqua.Toigian();
            return ketqua;
        }
    

  }// end of class PSo
  class Program{
         static void Main()
            {
            PSo a = new PSo(0, 1);
            PSo b = new PSo(0, 1);

            Console.WriteLine("=== NHAP PHAN SO ===");
            Console.WriteLine("Phan so a:");
            a.Nhap();

            Console.WriteLine("\nPhan so b:");
            b.Nhap();

            Console.WriteLine("sau khi toi gian!");
            a.Toigian();
            b.Toigian();

            Console.Write("a sau khi toi gian = ");
            a.Xuat();

            Console.Write("b sau khi toi gian = ");
            b.Xuat();

            Console.WriteLine("\n=== CAC PHAN SO DA NHAP ===");
            Console.Write("a = ");
            a.Xuat();

            Console.Write("b = ");
            b.Xuat();

            PSo c = a.Cong(b);

            Console.WriteLine("\n=== KET QUA ===");
            Console.Write("a + b = ");
            c.Xuat();

            PSo d = a.Tru(b);
            Console.Write("a - b = ");
            d.Xuat();

            }
        }// end of class program
}
