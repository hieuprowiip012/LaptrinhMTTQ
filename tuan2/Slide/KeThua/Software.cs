using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    class Software
    {
        private int m_z;

        public int m_v;

        protected int m_x;

        public Software()

        {

            m_x = 100;

        }

        public Software(int y)

        {

            m_x = y;

        }

    }

    class MicrosoftSoftware : Software

    {

        public MicrosoftSoftware()

        {

            Console.WriteLine(m_x);

        }

    }

    class IBMSoftware : Software

    {

        public IBMSoftware(int y) : base(y)

        {

            Console.WriteLine(m_x);

        }

        public IBMSoftware(string s, int f) : this(f)

        {

            Console.WriteLine(s);

        }
    }
}
