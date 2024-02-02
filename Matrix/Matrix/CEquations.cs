using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class CEquations
    {
        private int[] _a = new int[3]; 
        private int[] _b = new int[3];
        private int[] _c = new int[3];
        private double _x, _y, _z;
        private int _j, _k, _l;
        //ax + by + cz = j 
        public int[] a
        {
            get => _a;
            set => _a = value;
        }
        public int[] b
        {
            get => _b;
            set => _b = value;
        }
        public int[] c
        {
            get => _c;
            set => _c = value;
        }
        public double x
        {
            get => _x;
            set => _x = value;
        }
        public double y
        {
            get => _y;
            set => _y = value;
        }
        public double z
        {
            get => _z;
            set => _z = value;
        }
        public int j
        {
            get => _j;
            set => _j = value;
        }
        public int k
        {
            get => _k;
            set => _k = value;
        }
        public int l
        {
            get => _l;
            set => _l = value;
        }
        public CEquations()
        {
            Console.WriteLine("\nInserisci tutti i valori di a,b,c,j,k,l\n");
            Console.WriteLine("\nLa forma del sitema è\na1x + b1y + c1z = j\na2x + b2y + c2z = k\na3x + b3y + c3z = l\n");
            Console.WriteLine("\na1 -->");
            a[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nb1 -->");
            b[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nc1 -->");
            c[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nj -->");
            j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\na2 -->");
            a[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nb2 -->");
            b[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nc2 -->");
            c[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nk -->");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\na3 -->");
            a[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nb3 -->");
            b[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nc3 -->");
            c[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nl -->");
            l = Convert.ToInt32(Console.ReadLine());

        }


        public void Calculates()
        {
            
            
            
        }
    }

    }

