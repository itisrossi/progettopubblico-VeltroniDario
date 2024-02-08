namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

         
            

            CEquations e = new CEquations();
            e.Calculates();

            Console.WriteLine("x = {0:F2} y = {0:F2} z = {0:F2}", e.x, e.y, e.z);


            Console.ReadLine();
        }
    }
}//LISTA:  aggiungi, togli, arrivare ad un posizione 