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
            Console.Write("nhap tu so: ");
            _tuso = int.Parse(Console.ReadLine());
            Console.Write("nhap mau so: ");
            _mauso = int.Parse(Console.ReadLine());
        }
    public void Xuat()
        {
            Console.Write($"tu so la: {_tuso} / {_mauso}");
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
        

  }// end of class PSo
  class Program{
         static void Main()
            {
                
            }
        }// end of class program
}
