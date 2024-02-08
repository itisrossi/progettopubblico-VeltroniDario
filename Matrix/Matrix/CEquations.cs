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
        private int[] _r = new int[3];
        private float _x, _y, _z;

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
        public int[] r
        {
            get => _r;
            set => _r = value;
        }
        public float x
        {
            get => _x;
            set => _x = value;
        }
        public float y
        {
            get => _y;
            set => _y = value;
        }
        public float z
        {
            get => _z;
            set => _z = value;
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
            r[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\na2 -->");
            a[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nb2 -->");
            b[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nc2 -->");
            c[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nk -->");
            r[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\na3 -->");
            a[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nb3 -->");
            b[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nc3 -->");
            c[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nl -->");
            r[2] = Convert.ToInt32(Console.ReadLine());



        }


        public void Calculates()
        {
            CMatrix original = new CMatrix(3);
            for (int i = 0; i < 3; i++)
            {
                original.matrix[i, 0] = this.a[i];
            }
            for (int i = 0; i < 3; i++)
            {
                original.matrix[i, 1] = this.b[i];
            }
            for (int i = 0; i < 3; i++)
            {
                original.matrix[i, 2] = this.c[i];
            }

            CMatrix MatrixX = new CMatrix(3);
            for (int i = 0; i < 3; i++)
            {
                MatrixX.matrix[i, 0] = this.r[i];
            }
            for (int i = 0; i < 3; i++)
            {
                MatrixX.matrix[i, 1] = this.b[i];
            }
            for (int i = 0; i < 3; i++)
            {
                MatrixX.matrix[i, 2] = this.c[i];
            }


            CMatrix MatrixY = new CMatrix(3);
            for (int i = 0; i < 3; i++)
            {
                MatrixY.matrix[i, 0] = this.a[i];
            }
            for (int i = 0; i < 3; i++)
            {
                MatrixY.matrix[i, 1] = this.r[i];
            }
            for (int i = 0; i < 3; i++)
            {
                MatrixY.matrix[i, 2] = this.c[i];
            }
            CMatrix MatrixZ = new CMatrix(3);
            for (int i = 0; i < 3; i++)
            {
                MatrixZ.matrix[i, 0] = this.a[i];
            }
            for (int i = 0; i < 3; i++)
            {
                MatrixZ.matrix[i, 1] = this.b[i];
            }
            for (int i = 0; i < 3; i++)
            {
                MatrixZ.matrix[i, 2] = this.r[i];
            }


            /*long a = MatrixX.Determinante();
            long b = MatrixY.Determinante();
            long c = MatrixZ.Determinante();
            long d = original.Determinante();*/



            
            this.x = MatrixX.Determinante() / original.Determinante();
            this.y = MatrixY.Determinante() / original.Determinante();
            this.z = MatrixZ.Determinante() / original.Determinante();

        }
    }

}
