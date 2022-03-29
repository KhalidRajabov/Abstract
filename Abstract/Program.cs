using System;
using Abstract.Models;
namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Rectangular Square = new Rectangular();
            Square.CalcArea();
            Square square = new Square();
            square.CalcArea();*/

            Console.WriteLine("Select the figure to calculate the area: \n" +
                "1. Square \n" +
                "2. Rectangular \n" +
                "0. Quit program");

            int select = Convert.ToInt32(Console.ReadLine());
           
            do
            {
                switch (select)
                {
                    case 1:
                        {
                            Console.Write("What is the length of square's side? ");
                           
                            Square square = new Square();
                            square.Side=int.Parse(Console.ReadLine());
                            square.CalcArea();
                           
                          
                        }
                        break;
                    case 2:
                        {
                            Rectangular area = new Rectangular();
                            Console.Write("What is the length of Rectangular's width? ");
                            area.Width= Convert.ToInt32(Console.ReadLine());
                            Console.Write("What is the length of Rectangular's length? ");
                            area.Length= Convert.ToInt32(Console.ReadLine());

                          
                            area.CalcArea();
                        }
                        break;

                    case 0:
                        {
                            return;
                         
                        }
                     
                    default:
                        break;
                }
            } while (select <0 || select >2 );
            
        }

      


    }
    
 
}
