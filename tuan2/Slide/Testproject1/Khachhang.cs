using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject1
{
    class Khachhang
    {
        private string maKH;
        private string tenKH;

        private static string diachi;
     

        public  Khachhang()
        {
            this.maKH = "0";
            this.tenKH = "ABC";
        }
        public Khachhang(string maKH, string tenKH)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
        }
       

    }
}
