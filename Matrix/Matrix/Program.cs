namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CMatrix b = new CMatrix(4);
            CMatrix a = new CMatrix(5);

            a.Refill(1, 3);

            a.PrintMatrix();

            
            Console.WriteLine("\n\n\n\nIl determinante è " + a.Determinante());
            //b.Copia(a.Riduci(a.matrix[0, 0]));
            //a.PrintMatrix();


            Console.ReadLine();
        }
    }
}//LISTA:  aggiungi, togli, arrivare ad un posizione 