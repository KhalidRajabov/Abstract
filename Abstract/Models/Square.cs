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
            {if (value < 0)
                {
                    Console.WriteLine("Side menfi ola bilmez");
                    return;
                }
            
                _side = value;

                return;
            } 
           
        }

        public override void CalcArea()
        {
            int result = Side * Side;
            if (Side > 0)
            {

                Console.WriteLine($"Square Area= {result}");
            }
            
            
        }
    }
}
