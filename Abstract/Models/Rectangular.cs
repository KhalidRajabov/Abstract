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
                if (value < 0)
                {
                    Console.WriteLine("teref menfi ola bilmez");
                    return;
                    
                }
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
                if (value < 0) 
                {


                    Console.WriteLine("teref menfi ola bilmez");
                    return ;


                }
                _length = value;
            } 
        }

        public override void CalcArea()
        {
            int result = _width * _length;
            if (Width > 0 && Length > 0)
            {
                Console.WriteLine($"Rectangle Area={result}");
            }
        }
    }
}
