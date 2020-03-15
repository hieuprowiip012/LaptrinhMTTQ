using System;

namespace TinhDienTich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************Tinh Chu VI & DIen Tich ****************************");
            //OOP Tính diện tích và chu vi của hình chữ nhật
            Console.Write("Nhap vao chieu dai: ");
            double d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao chieu rong: ");
            double r = Convert.ToInt32(Console.ReadLine());
            hcn tdt = new hcn();
            hcn tcv = new hcn();
            Console.WriteLine("Chu vi = {0}", tcv.cv(d, r));
            Console.WriteLine("Dien tich = {0}", tdt.dt(d, r));
            
        }

        public class hcn
        {
            //public double dai;
            //public double rong;
            public double dt(double dai, double rong)
            {
                return dai * rong;
            }
            public double cv(double dai, double rong)
            {
                return (dai + rong) * 2;
            }
        }
    }
}
