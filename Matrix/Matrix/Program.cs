namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

         
            

            CEquations e = new CEquations();
            e.Calculates();

            Console.WriteLine("x = " + e.x  + " y =  " + e.y + " z = " +  e.z);


            Console.ReadLine();
        }
    }
}//LISTA:  aggiungi, togli, arrivare ad un posizione 