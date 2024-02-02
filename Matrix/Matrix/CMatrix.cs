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
            rows = 2;
            columns = 2;
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
        public long this[int row, int column]
        {
            get
            {
                return matrix[row, column];
            }
            set
            {
                matrix[row, column] = value;
            }
        }

        public CMatrix(int n)
        {
            rows = n;
            columns = n;
            matrix = new long[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }





        public static CMatrix operator +(CMatrix a, CMatrix b)
        {
            CMatrix c = new CMatrix(a.rows, a.columns);
            if (a.rows == b.rows && a.columns == b.columns)
            {
                for (int i = 0; i < a.rows; i++)
                {
                    for (int j = 0; j < a.columns; j++)
                    {
                        c.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
                    }
                }
            }
            else
            {
                Console.WriteLine("\nLe matrici non possono essere sommate\n");
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
            else
            {
                Console.WriteLine("\nCon queste matrici è impossibile eseguire la differenza\n");
            }
            return c;

        }
        public void Copia(CMatrix a)
        {
            if (this.rows != a.rows || this.columns != a.columns)
            {
                Console.WriteLine("Impossibile fare la copia di matrici diverse");
                return;

            }
            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < a.columns; j++)
                {
                    this.matrix[i, j] = a.matrix[i, j];
                }
            }


        }

        public void Refill(int da, int a)
        {
            Random r = new Random();
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    this.matrix[i, j] = r.Next(da, a + 1);
                }
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    if (j % this.columns == 0)
                    {
                        Console.WriteLine("\n\n");
                    }
                    Console.Write(this.matrix[i, j] + "\t");
                }
            }
            Console.WriteLine("\n");
        }

        public void Trasposta()
        {
            bool end = false;
            long a;
            int I = 0;
            int J = 0;
            while (!end)
            {
                for (int i = I; i < this.rows; i++)
                {
                    a = this.matrix[i, J];
                    this.matrix[i, J] = this.matrix[J, i];
                    this.matrix[J, i] = a;
                }
                I++;
                J++;
                if (J == this.columns)
                {
                    end = true;
                }
            }
        }

        public static CMatrix operator *(CMatrix a, CMatrix b)
        {
            CMatrix c = new CMatrix(a.rows, b.columns);
            long r = 0;
            long[] c1 = new long[b.columns];
            long[] c2 = new long[a.rows];

            if (a.columns != b.rows)
            {
                throw new ArgumentException("\nImpossible to do the moltiplication\n");
            }

            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < b.columns; j++)
                {
                    for (int n = 0; n < b.columns; n++)
                    {
                        c1[n] = a.matrix[i, n];
                    }
                    for (int m = 0; m < b.columns; m++)
                    {
                        c2[m] = b.matrix[m, j];
                    }
                    for (int l = 0; l < a.rows; l++)
                    {
                        r += c1[l] * c2[l];
                    }
                    c.matrix[i, j] = r;
                    r = 0;
                }
            }
            return c;
        }
        public static long Do(CMatrix a, CMatrix b,int i,int j)
        {

            long r = 0;
            long[] c1 = new long[b.columns];
            long[] c2 = new long[a.rows];
           
            for (int n = 0; n < a.rows; n++)
            {
                    c1[n] = a.matrix[n, j];
                            }
            for (int m = 0; m < b.columns; m++)
            {
                c2[m] = b.matrix[i, m];
            }
            for (int l = 0; l < a.rows; l++)
            {
                    r += c1[l] * c2[l];
            }
            
            return r;
        }

        public static CMatrix operator *(CMatrix a, CMatrix b)
        {
            CMatrix c = new CMatrix(a.rows, b.columns);
            long[] p = new long[b.columns];
            if (a.columns != b.rows)
            {
                throw new ArgumentException("\nImpossible to do the moltiplication\n");
            }
            Task[] tasks = new Task[a.rows];

            for (int i=0;i<a.rows; i++)
            { 
                tasks[0] = Task.Run(() =>
                {
                        int righe = i;
                        for(int j=0; j<b.columns; j++)
                        {
                            long y = Do(a,b,righe,j);
                            c.matrix[righe,j] = y;
                        }
                   
                });
            }
            Task.WaitAll(tasks);
            
            return c;

            
            
        }

       

        public long Determinante()
        {
            long d = 0;
            CMatrix r = new CMatrix(this.rows - 1);
            r.Refill(1, 3);
            if (this.rows != this.columns)
            {
                Console.WriteLine("\nLa matrice non è quadrata!\n");
                return -1;
            }
            if (this.rows == 1)
            {
                return this.matrix[0, 0];
            }
            if (this.rows == 2)
            {
                return (this.matrix[0, 0] * this.matrix[1, 1]) - (this.matrix[1, 0] * this.matrix[0, 1]);
            }
            if (this.rows == 3)
            {
                return this.Sarrus();
            }
            for (int i = 0; i < this.rows; i++)
            {
                r.Copia(this.Riduci(0, i));

                d += (long)Math.Pow(-1, (i + 2)) * this.matrix[0, i] * r.Determinante();
            }

            return d;

        }


        private long Sarrus()
        {
            long c1 = 1;
            long c2 = 1;

            c1 = (this.matrix[0, 0] * this.matrix[1, 1] * this.matrix[2, 2]) + (this.matrix[0, 1] * this.matrix[1, 2] * this.matrix[2, 0]) + (this.matrix[0, 2] * this.matrix[1, 0] * this.matrix[2, 1]);
            c2 = -(this.matrix[0, 2] * this.matrix[1, 1] * this.matrix[2, 0]) - (this.matrix[0, 0] * this.matrix[1, 2] * this.matrix[2, 1]) - (this.matrix[0, 1] * this.matrix[1, 0] * this.matrix[2, 2]);
            return c1 + c2;
        }

        public CMatrix Riduci(int X, int Y)
        {


            CMatrix r = new CMatrix(this.columns - 1);
            CMatrix c = new CMatrix(this.rows);
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    c.matrix[i, j] = this.matrix[i, j];
                }
            }

            for (int i = 0; i < this.rows; i++)
            {
                c.matrix[i, Y] = -1;
            }
            for (int j = 0; j < this.columns; j++)
            {
                c.matrix[X, j] = -1;
            }


            int x = 0, y = 0;
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    if (c.matrix[i, j] != -1)
                    {
                        r.matrix[x, y] = c.matrix[i, j];
                        y++;
                        if (y % (this.columns - 1) == 0)
                        {
                            y = 0;
                            x++;
                        }
                    }
                }
            }
            return r;

        }


    }
}