using System;

namespace PhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Giai va bien luan ptb1*****************");
            Console.Write("Nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b:");
            int b = int.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("Phuong Trinh co vo so nghiem");
            else
                    Console.WriteLine("Phuong Trinh vo  nghiem");
            else
            {
                int ketqua = -b / a;
                Console.WriteLine("Phuong Trinh co  mot nghiem x ={0}",ketqua.ToString());

            }
            Console.ReadKey();


        }
    }
}
