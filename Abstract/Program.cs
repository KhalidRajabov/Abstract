﻿using System;
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
            int uSquare;
            int width;
            int length;
            do
            {
                switch (select)
                {
                    case 1:
                        {
                            Console.Write("What is the length of square's side? ");
                            uSquare = Convert.ToInt32(Console.ReadLine());
                            Square square = new Square();
                            square.CalcArea(uSquare, 0);
                        }
                        break;
                    case 2:
                        {
                            Console.Write("What is the length of Rectangular's width? ");
                            width= Convert.ToInt32(Console.ReadLine());
                            Console.Write("What is the length of Rectangular's length? ");
                            length= Convert.ToInt32(Console.ReadLine());

                            Rectangular area= new Rectangular();
                            area.CalcArea(width, length);
                        }
                        break;

                    case 0:
                        {

                        }
                        break;


                    default:
                        break;
                }
            } while (select < 0 || select > 4);

        }

        static int GetInt(string name, int min = int.MinValue, int max = int.MaxValue)
        {
            int input;
            do
            {
                Console.Write(name);
                input = Convert.ToInt32(Console.ReadLine());
                if (min > input || max < input)
                {
                    Console.WriteLine("Age must not be less than 1, and more than 120");
                }
            } while (input < min || input > max);
            return input;
        }


    }
    
 
}