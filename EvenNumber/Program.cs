using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("Podaj liczbę:");
                    if (int.TryParse(Console.ReadLine(), out var number))
                    {
                        if (number % 2 == 0)
                            Console.WriteLine($"Liczba {number} jest parzysta.");
                        else
                            Console.WriteLine($"Liczba {number} jest nieparzysta.");
                    }
                    else
                        Console.WriteLine("Wprowadziłeś nieprawidłowe dane !!!");
                } while (TheEnd());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
           
        }

        static bool TheEnd()
        {
            try
            {
                string end;
                bool error = true;
                Console.WriteLine("Czy chcesz zakończyć, odpowiedz T lub N:");

                do
                {
                    end = Console.ReadLine().ToUpper();
                    if (end.Equals("N") || end.Equals("T"))
                        error = false;
                    else
                    {
                        error = true;
                        Console.WriteLine("Wprowadziłeś zły znak, zakończenie: T, kontynuacja: N");
                    }
                        
                } while (error);

                if (end.Equals("N")) return true;
                else return false;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return true;
            }
        } 
    }
}
