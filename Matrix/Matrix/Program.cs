namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMatrix a = new CMatrix();
            CMatrix b = new CMatrix();
            CMatrix c = new CMatrix();
            Random r = new Random();
            for(int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < a.columns; j++)
                {
                    a.matrix[i, j] = r.Next(0, 2);
                    b.matrix[i, j] = r.Next(0, 2);
                }
            }
            c = a + b;

            Console.WriteLine("Hello, World!");
        }
    }
}