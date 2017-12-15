using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Démarrage de l'application Console");
            try
            {
                using (var ctx = new CoreLibrary.BookStoreEntities())
                {
                    foreach (var p in ctx.Persons)
                    {
                        Console.WriteLine(p.LastName);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write("Une erreur est survenue :");
                Console.Error.WriteLine(ex);
            }
            Console.WriteLine("Appuyez sur une touche pour quitter");
            Console.ReadKey();
        }
    }
}
