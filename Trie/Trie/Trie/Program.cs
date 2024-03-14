namespace Trie
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            CTrie trie = new CTrie();
            



            StreamReader fileRead = File.OpenText(@"C:\Users\9698074\Desktop\rockyou.txt");
            string parola;
            Console.WriteLine("Partito!");
            while ((parola = fileRead.ReadLine()) != null)
            {
                trie.AddWord(parola);
            }
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nInserisci una parola da cercare:");
                string word = Console.ReadLine();
                if(word == "exit") {
                    exit = true;
                    break;
                }
                trie.Search(word);

            }
            Console.WriteLine("Terminato");
            

            Console.ReadLine();
        }
    }
}