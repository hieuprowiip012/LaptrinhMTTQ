using System;

namespace ThaoTacSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSo1, nSo2, nTong = 0;
            Console.Clear();
            Console.Write("{0}", "Nhap So Thu Nhat: ");
            //read first number form you user 
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap So thu Hai:");
            //read second number form you user 
            nSo2 = Convert.ToInt32(Console.ReadLine());
            nTong = nSo1 + nSo2; Console.WriteLine(" Tong Cua " + nSo1 + " va " + nSo2 + " là " + nTong);
            Console.ReadLine();
        }
    }
}
