using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo grafo = new Grafo(5);
            grafo.StampaMatrice();
            Console.ReadLine();

        }
    }
}
