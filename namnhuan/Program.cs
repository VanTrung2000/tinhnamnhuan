using System;

namespace namnhuan
{
    class Program
    {
        static void Main(string[] args)
        {

            int nam;

            Console.Write("Nhap mot nam bat ky: ");
            nam = Convert.ToInt32(Console.ReadLine());

            namnhuan(nam);
        }
        static int namnhuan(int nam){
            if ((nam % 400) == 0)
                Console.WriteLine("la nam nhuan.", +nam);
            else if ((nam % 100) == 0)
                Console.WriteLine(" khong phai la nam nhuan.", +nam);
            else if ((nam % 4) == 0)
                Console.WriteLine(" la nam nhuan.", +nam);
            else
                Console.WriteLine(" khong phai la nam nhuan.", +nam);

            Console.ReadKey();
            return nam;
        }
    }
}
