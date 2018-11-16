using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20181116_ZAD1_Obsluga_wyjatkow
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = null;

            if(args.Length > 0 )
            {
                path = args[0];
            }

            Console.Write($"Podaj sciezke dostepu:{path}");
            path = Console.ReadLine();

            try
            {
                FileSystemWatcher folder = new FileSystemWatcher(path);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Exception!{ex.Message}");               
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exception!{ex.Message}");
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine($"Exception!{ex.Message}");
            }
           
            Console.ReadKey();
        }
    }
}
