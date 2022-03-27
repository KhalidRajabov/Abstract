using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Models
{
    internal class Rectangular:Figure
    {
        private int _width;
        private int _length;
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public int Length
        {
            get 
            {
                return _length;
            }
            set 
            { 
                _length=value;
            } 
        }

        public override void CalcArea(int num1, int num2)
        {
            int area;
            if (num1 > 0 && num2 >0)
            {
                Console.WriteLine($"Area of the rectangular is '{area = num1 * num2}'              ({num1} x {num2} = {area})");
                
            }
            else
            {
                Console.WriteLine("Width or length can not be negative");
            }
        }
    }
}
