using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Shape
    {
        protected float m_Height = 5;

        protected float m_Width = 10;


        public abstract void CalculateArea();

        public abstract void CalculateCircumference();



        public void PrintHeight()

        {

            Console.WriteLine("Height = {0}", m_Height);

        }

        public void PrintWidth()

        {

            Console.WriteLine("Width = {0}", m_Width);

        }

    }

    class Rectangle : Shape

    {

        public Rectangle()
        {

            m_Height = 20;

            m_Width = 30;

        }

        public override void CalculateArea()

        {

            Console.WriteLine("Area : {0}", m_Height * m_Width);

        }

        public override void CalculateCircumference()

        {

            Console.WriteLine("Circumference =  {0}", (m_Height + m_Width) * 2);

        }
    }
}
