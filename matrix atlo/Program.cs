using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_atlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a mátrix méretét: ");
            int atlo = Convert.ToInt32(Console.ReadLine());

            Random vel = new Random();
            
            int[,] matrix = new int[atlo, atlo];

            for (int sor = 0; sor < atlo; sor++)
            {
                for (int oszlop = 0; oszlop < atlo; oszlop++)
                {
                    matrix[sor, oszlop] = vel.Next(20);
                }
                
            }

            for (int sor = 0; sor < atlo; sor++)
            {
                for (int oszlop = 0; oszlop < atlo; oszlop++)
                {
                    Console.Write($"{matrix[sor, oszlop],4}");  
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int sor  = 0; sor < atlo ; sor++)
            {
                for (int oszlop = 0; oszlop < atlo ; oszlop++)
                {
                    if (sor == oszlop)
                    {
                        sum += matrix[sor, oszlop];
                    }
                    
                }
                
            }

            Console.WriteLine(sum);



            Console.ReadKey();
        }
    }
}
