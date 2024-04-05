namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMatrix m = new CMatrix(3,3);
            CMatrix m2 = new CMatrix(2,2);
            m.Refill(1,4);
            m.PrintMatrix();
            m2.Copia(m.Riduci(2,2));
            m2.PrintMatrix();

            Console.ReadLine();
        }         
    }
}//LISTA:  aggiungi, togli, arrivare ad un posizione 