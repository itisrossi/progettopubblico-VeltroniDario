namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CMatrix b = new CMatrix(4);
            CMatrix a = new CMatrix(2);
            CMatrix b = new CMatrix(2);
            CMatrix c = new CMatrix(2);

            a.Refill(1, 2);

            a.PrintMatrix();
            b.Refill(1, 2);

            b.PrintMatrix();
            c = a * b;
            c.PrintMatrix();
            

           
            //b.Copia(a.Riduci(a.matrix[0, 0]));
            //a.PrintMatrix();


            Console.ReadLine();
        }
    }
}//LISTA:  aggiungi, togli, arrivare ad un posizione 