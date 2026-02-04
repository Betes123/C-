using System;

namespace TinhTienDien
{
    class KWH
    {
        const int muc1=100, muc2=150,muc3=300;
        const int gia1=2000, gia2=2500, gia3=3000;
        public static double TinhToan()
        {
            Console.WriteLine("nhap kwh de tinh tien dien: ");
            int kwh=Convert.ToInt32(Console.ReadLine());
        
            double sotien=0;
            if (kwh <= muc1)
            {
                sotien=kwh*gia1;
            }
            else
            {
                if (kwh < muc2)
                {
                    sotien=(muc1*gia1) + (kwh-muc1)*gia2;
                    //130 = 100*2000      130-100=30*2500
                }
                else
                {
                    if (kwh > muc2)
                    {
                        sotien=(muc1*gia1) + (muc2-muc1)*gia2 + (kwh - muc2)*gia3;
                        // 151  100*2000      150-100=50*2500 +  151-150=1*3000     
                    }
                }
            }
            if(kwh > muc3)
            {
                sotien*=1.1;
            }
            return sotien;
        }
    }
}