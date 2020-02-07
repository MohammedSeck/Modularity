using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1_Modular_App
{
    class Calculator
    {
        //This is a calculator class and below are the member functions:

        //Funcion to wok out the area of Circle
        public double Circle(double radius, double pi)
        {
            pi = 3.142;
            return pi * radius * radius;
        }

        //Function to work out the area of triangle
        public double Triangle(double length, double width)
        {
            if (length > width)
            {
                return length * width / 2;

            }
            return length * width / 2;
        }

        //Function to work out the area of the rectangle...
        public double Rectangle(double length, double width)
        {
            return length * width;
        }

    }
}
