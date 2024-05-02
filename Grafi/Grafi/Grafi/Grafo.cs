using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafi
{
    internal class Grafo
    {
        private int[,] matriceAdiacenza;
        private int numeroNodi;

        public Grafo(int numeroNodi)
        { 
            this.numeroNodi = numeroNodi;
            matriceAdiacenza = new int[numeroNodi, numeroNodi];
            for (int i = 0; i < numeroNodi; i++)
            {
                for (int j = 0; j < numeroNodi; j++)
                {
                    matriceAdiacenza[i, j] = 0;
                }
            }

        }

        public void AggiungiArco(int nodo1, int nodo2)
        {
            if (nodo1 < 0 || nodo1 >= numeroNodi || nodo2 < 0 || nodo2 >= numeroNodi)
            {
                throw new ArgumentException("Nodo non valido");
            }

            matriceAdiacenza[nodo1, nodo2] = 1;
            matriceAdiacenza[nodo2, nodo1] = 1;
        }

        public void RimuoviArco(int nodo1, int nodo2)
        {
            if (nodo1 < 0 || nodo1 >= numeroNodi || nodo2 < 0 || nodo2 >= numeroNodi)
            {
                throw new ArgumentException("Nodo non valido");
            }

            matriceAdiacenza[nodo1, nodo2] = 0;
            matriceAdiacenza[nodo2, nodo1] = 0;
        }

        public bool EsisteArco(int nodo1, int nodo2)
        {
            if (nodo1 < 0 || nodo1 >= numeroNodi || nodo2 < 0 || nodo2 >= numeroNodi)
            {
                throw new ArgumentException("Nodo non valido");
            }

            return matriceAdiacenza[nodo1, nodo2] == 1;
        }

        public void AggiungiNodo()
        {
            int[,] nuovaMatriceAdiacenza = new int[numeroNodi + 1, numeroNodi + 1];

            for (int i = 0; i < numeroNodi; i++)
            {
                for (int j = 0; j < numeroNodi; j++)
                {
                    nuovaMatriceAdiacenza[i, j] = matriceAdiacenza[i, j];
                }
            }

            matriceAdiacenza = nuovaMatriceAdiacenza;
            numeroNodi++;
        }

        public void RimuoviNodo(int nodo)
        {
            int[,] nuovaMatriceAdiacenza = new int[numeroNodi - 1, numeroNodi - 1];

            for (int i = 0; i < numeroNodi && i!=nodo; i++)
            {
                for (int j = 0; j < numeroNodi && i != nodo; j++)
                {
                    nuovaMatriceAdiacenza[i, j] = matriceAdiacenza[i, j];
                }
            }

            matriceAdiacenza = nuovaMatriceAdiacenza;
            numeroNodi--;
        }
        public void StampaMatrice()
        {
            for (int i = 0; i < matriceAdiacenza.GetLength(0); i++)
            {
                for (int j = 0; j < matriceAdiacenza.GetLength(1); j++)
                {
                    Console.Write(matriceAdiacenza[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
