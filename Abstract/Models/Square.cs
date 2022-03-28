using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Models
{
    internal class Square:Figure
    {
        private int _side;
        public int Side 
            { 
            get 
            {
                return _side; 
            }
            set 
            {
                _side = value;
            } 
        }

        public override void CalcArea(int num1, int num2)
        {

            int sq;
            if (num1>0)
            {
                sq = num1 *2;
                Console.WriteLine($"Area of your square is: '{num1*2}'       ({num1} x 2 = {sq})");
            }
            else
            {
                Console.WriteLine("Side can not be negative");
            }
            
        }
    }
}
