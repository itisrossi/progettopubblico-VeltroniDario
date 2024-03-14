using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    internal class CTrie
    {
        private readonly TrieNode _root = new TrieNode();


        public string chiave(string word)
        {
            char[] caratteri = word.ToCharArray();

            // Ordino l'array di caratteri in ordine alfabetico
            Array.Sort(caratteri);

            // Creo una nuova stringa con i caratteri ordinati
            string risultato = new string(caratteri);

            return risultato;
        }
        public void AddWord(string word)
        {
            var node = _root;
            chiave di word
            foreach (char c in word)
            {
                if (!node.Children.ContainsKey(c))
                {
                    node.Children[c] = new TrieNode();
                }
                    
                node = node.Children[c];
            }
            node.IsWord = true;
        }
        public bool Search(string word)
        {
            var node = _root;
            foreach (char c in word)
            {
                if (!node.Children.ContainsKey(c))
                {
                    Console.WriteLine("\nLa parola <" + word + "> NON c'è nel Trie\n");
                    return false;
                }
                
                node = node.Children[c];
            }
            Console.WriteLine("\nLa parola <" + word + "> è presente nel Trie\n");
            return node.IsWord;
        }
        
    }
}
