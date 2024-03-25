using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    internal class CTrie
    {
        private readonly TrieNode _root = new TrieNode();


        public string key(string word)
        {
            char[] caratteri = word.ToCharArray();

            Array.Sort(caratteri);

            string risultato = new string(caratteri);

            return risultato;
        }
        public void AddWord(string word)
        {
            var node = _root;
            string keyword = key(word);
            if (Search2(word))
            {
                Console.WriteLine("\nLa parola <" + word + "> è già presente nel Trie\n");
                return;
            }
            /*foreach (char c in keyword)
            {
                if (!node.Children.ContainsKey(c))
                {
                    node.Children[c] = new TrieNode();
                }
                    
                node = node.Children[c];
            }*/
            for(int i = 0; i < keyword.Length; i++)
            {
                if (!node.Children.ContainsKey(keyword[i]))
                {
                    node.Children[keyword[i]] = new TrieNode();
                }
                node = node.Children[keyword[i]];
                if(i==keyword.Length-1)
                {
                    node.words.Add(word);
                }
            }
            
            node.IsWord = true;
        }
        public void anagramma(string word)
        {
            var node = _root;
            string keyword = key(word);
            foreach (char c in keyword)
            {
                if (!node.Children.ContainsKey(c))
                {
                    Console.WriteLine("\nLa parola <" + word + "> NON c'è nel Trie\n");
                    return;
                }

                node = node.Children[c];
            }
            if (node.words.Contains(word))
            {
                foreach (var elemento in node.words)
                {
                    Console.WriteLine("\n" + elemento);
                }
            }
            else
            {
                Console.WriteLine("\nLa parola <" + word + "> NON c'è nel Trie\n");
                return;
            }
        }
        public bool Search(string word)
        {
            var node = _root;
            string keyword = key(word);
            foreach (char c in keyword)
            {
                if (!node.Children.ContainsKey(c))
                {
                    Console.WriteLine("\nLa parola <" + word + "> NON c'è nel Trie\n");
                    return false;
                }
                
                node = node.Children[c];
            }
            if (node.words.Contains(word))
            {
                Console.WriteLine("\nLa parola <" + word + "> è presente nel Trie\n");
                return node.IsWord;
            }
            else
            {
                Console.WriteLine("\nLa parola <" + word + "> NON c'è nel Trie\n");
                return false;
            }
            
            
        }
        private bool Search2(string word)
        {
            var node = _root;
            string keyword = key(word);
            foreach (char c in keyword)
            {
                if (!node.Children.ContainsKey(c))
                {
                    
                    return false;
                }

                node = node.Children[c];
            }
            if (node.words.Contains(word))
            {
               
                return node.IsWord;
            }
            else
            {
               
                return false;
            }


        }

    }
}
