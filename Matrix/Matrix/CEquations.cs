using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class CEquations
    {
        private int[] _a; 
        private int[] _b;
        private int[] _c;
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
            Console.WriteLine("\nQuante incognite vuoi avere nel sistema?");
            int ne = Convert.ToInt32(Console.ReadLine());
            switch (ne)
            {
                case 1:
                    Console.WriteLine("");
                    break;
            }

        }
    }

    }

