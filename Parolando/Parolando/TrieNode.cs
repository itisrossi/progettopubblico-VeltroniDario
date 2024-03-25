using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parolando
{
    internal class TrieNode
    {
        public bool IsWord { get; set; }
        public List<string> words = new List<string>();
        public Dictionary<char, TrieNode> Children { get; } = new Dictionary<char, TrieNode>();
    }
}
