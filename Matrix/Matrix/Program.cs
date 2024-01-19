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
            a.Refill(0, 3);
            a.PrintMatrix();
            

            
            Console.ReadLine();
        }
    }
}