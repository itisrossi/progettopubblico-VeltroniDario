namespace Trie
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            CTrie trie = new CTrie();

            StreamReader fileRead = File.OpenText(@"..\\..\\..\\txt\\parole.txt");
            string parola;
            Console.WriteLine("Partito!");
            while ((parola = fileRead.ReadLine()) != null)
            {
                trie.AddWord(parola);
            }
            bool exit = false;
            Console.WriteLine("Tutte le parole sono state inserite!");
            while (!exit)
            {
                Console.WriteLine("\nScrivi una parola da cercare:    (scrivi 'exit' per terminare il programma)");
                string word = Console.ReadLine();
                if(word == "exit") {
                    exit = true;
                }
                trie.Search(word);

            }
            
        }
    }
}