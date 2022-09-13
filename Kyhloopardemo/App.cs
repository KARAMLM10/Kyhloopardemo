using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyhloopardemo
{
    internal class App
    {
        public void Run() 
        {
            Console.WriteLine("mata in två tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int summa = tal1 + tal2;
            Console.WriteLine("summan är" + summa);

            Console.WriteLine("vill du fortsätta J/N");

            if(i == "J")
            {
                Console.WriteLine("");
            }






            /*int tal1 = Convert.ToInt32((Console.ReadLine() ));
            int tal2 = Convert.ToInt32((Console.ReadLine()));

            /* for(int i = tal1+1; i < tal2; i++)
             {
                 Console.WriteLine(i);
             }*/
           /* tal1 = tal1 + 1;
                
                while (tal1 < tal2) 
                {
                  Console.WriteLine(tal1);
                     tal1++;

                 }*/

                /*if(tal1 > tal2)
            {
                for(int i = tal1-1; i > tal2; i--)
                {
                    Console.WriteLine(i);
                }*/
                
            }

            



           /* for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            int h = 0;
            while(h <= 10)
            {
                Console.WriteLine(h);
                h++;
            }*/
        }




    }
