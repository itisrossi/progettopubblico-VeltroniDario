namespace Parolando
{
    internal class Program
    {
        public static string[] GetLetters()
        {
            string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", };
           
            string[] alphabet = new string[8];
            Random t = new Random();
            for (int i = 0; i < 8; i++)
            {
                alphabet[i] = letters[t.Next(26)];
            }

            return alphabet;
        }
         
        public static string Ordina(string[] word)
        {
            string W = "";
            for (int i = 0; i < word.Length; i++)
            {
                W += word[i];
            }
            char[] caratteri = W.ToCharArray();



            Array.Sort(caratteri);

            string risultato = new string(caratteri);

            return risultato;
        }
        
        static void Main(string[] args)
        {
            CTrie trie = new CTrie();
            trie.FillTrie();
            int numerogiocatore = 1;
            string[] letters = GetLetters();
            CRiga riga = new CRiga();
            

            while (numerogiocatore < 9)
            {
                Console.WriteLine("Giocatore " + numerogiocatore + ": " + Ordina(letters));
                for(int i = 0;i < 8; i++)
                {
                    Console.WriteLine("\n" + riga.row[i]);
                }


                 


                numerogiocatore++;
                riga = new CRiga();
                letters = GetLetters();
            }
           
            Console.WriteLine("Hello, World!");
        }
    }
}