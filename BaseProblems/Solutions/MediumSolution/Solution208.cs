using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution208
    {
        public class Trie
        {
            private Dictionary<char, Trie> trie;

            public Trie()
            {
                trie = new Dictionary<char, Trie>();
            }

            public void Insert(string word)
            {
                var t = trie;

                foreach (char c in word)
                {
                    if (!t.ContainsKey(c))
                    {
                        t[c] = new Trie();
                    }

                    t = t[c].trie;
                }

                t['~'] = new Trie(); 
            }

            public bool Search(string word)
            {
                var t = trie;

                foreach (char c in word)
                {
                    if (!t.ContainsKey(c))
                    {
                        return false;
                    }

                    t = t[c].trie;
                }

                return t.ContainsKey('~');
            }

            public bool StartsWith(string prefix)
            {
                var t = trie;

                foreach (char c in prefix)
                {
                    if (!t.ContainsKey(c))
                    {
                        return false;
                    }

                    t = t[c].trie;
                }

                return true;
            }
        }
    }
}
