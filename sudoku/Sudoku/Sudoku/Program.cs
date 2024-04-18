namespace Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMatrix a = new CMatrix(9,9);

            a.Start();
            a.PrintMatrix();


            Console.WriteLine("Hello, World!");
        }
    }
}