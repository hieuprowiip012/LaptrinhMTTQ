using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    public class Point
    {
        public int m_x;

        public int m_y;

        public Point() { }

        public Point(int xx, int yy)

        {

            m_x = xx;

            m_y = yy;

        }

        public static Point operator +(Point p1, Point p2)

        {

            Point result = new Point();

            result.m_x = p1.m_x + p2.m_y;

            result.m_y = p1.m_x + p2.m_y;

            return result;
        }
    }
}
