using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    internal class TrieNode
    {
        public bool IsWord { get; set; }
        public Dictionary<char, TrieNode> Children { get; } = new Dictionary<char, TrieNode>();
    }
}
