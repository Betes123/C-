using System;
    class Program
    {
        static void Main()
        {
            double tien= KWH.TinhToan();
            Console.WriteLine("tien dien la: "+tien);
            Switch.vonglap();
            int soluong = ViTrung.Sum();
            Console.WriteLine($"so luong sau gio la: {soluong}");

            int[] a = InArray.xuatmang();
            int max = MAX.caonhattrongmang();
        }
    }
