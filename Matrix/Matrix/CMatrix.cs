using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Matrix
{
    internal class CMatrix
    {
        //private variables
        private int _rows;
        private int _columns;
        private long[,] _matrix;
        //get-set
        public int rows
        {
            get => _rows;
            set => _rows = value;
        }
        public int columns
        {
            get => _columns;
            set => _columns = value;
        }
        public long[,] matrix
        {
            get => _matrix;
            set => _matrix = value;
        }
        //constructor
        public CMatrix(int r, int c)
        {
            rows = r;
            columns = c;
            matrix = new long[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        public CMatrix()
        {
            rows = 3;
            columns = 3;
            matrix = new long[rows, columns];
            Random r = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }


        

        
        public static CMatrix operator + (CMatrix a, CMatrix b)
        {
            CMatrix c = new CMatrix(a.rows, a.columns);
            if(a.rows == b.rows && a.columns == b.columns)
            {
                for (int i = 0; i < a.rows; i++)
                {
                    for (int j = 0; j < a.columns; j++)
                    {
                        c.matrix[i, j] = a.matrix[i, j] + b.matrix[i,j];
                    }
                }
            }
            return c;
            
        }

        public static CMatrix operator -(CMatrix a, CMatrix b)
        {
            CMatrix c = new CMatrix(a.rows, a.columns);
            if (a.rows == b.rows && a.columns == b.columns)
            {
                for (int i = 0; i < a.rows; i++)
                {
                    for (int j = 0; j < a.columns; j++)
                    {
                        c.matrix[i, j] = a.matrix[i, j] - b.matrix[i, j];
                    }
                }
            }
            return c;

        }

        public void Trasposta()
        {
            bool end = false;
            long a;
            int I = 0;
            int J = 0;
            while (!end)
            {
                for (int i = I; i< this.rows; i++)
                {
                    a = this.matrix[i, J];
                    this.matrix[i,J] = this.matrix[J, i];
                    this.matrix[J,i] = a;
                }
                I++;
                J++;
                if (J == this.columns)
                {
                    end = true;
                }
            }
        }

        static CMatrix ChangeVariable(ref CMatrix c, int I, int J, CMatrix a, CMatrix b)
        {
            long r = 0;
            long[] c1 = new long[b.columns];
            long[] c2 = new long[a.rows];
            for(int j=0;j < b.columns; j++)
            {
                c1[j] = a.matrix[I,j];
            }
            for (int i = 0; i < b.columns; i++)
            {
                c2[i] = a.matrix[i, J];
            }
            for (int i=0; i < a.rows; i++)
            {
                r += c1[i] * c2[i];
            }

            c.matrix[I, J] = r;
            return c;
        }

        public static CMatrix operator *(CMatrix a, CMatrix b)
        {
            CMatrix c = new CMatrix(a.rows,b.columns);
           
            if(a.columns != b.rows)
            {
                throw new ArgumentException("Impossible to do the moltiplication");
            }

            for(int i=0; i< a.rows; i++)
            {
                for (int j=0; j< b.columns; j++)
                {
                    Task.Run(() => ChangeVariable(ref c, i, j, a, b));
                }
            }
            Task.WhenAll().ContinueWith(_ =>
            {
                return c;
            });
            return c;

        }



    }
}
