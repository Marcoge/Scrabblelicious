/** class takes string and dictionary tree
 * possible words are put in List<String> _results *
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabblelicious
{
    class WordTester
    {
        private static TreeNode _dict;
        static List<String> _perms = new List<String>();
        private List<String> _results;
        private static int _maxLength= 0;

        public WordTester(String w, TreeNode d, int length)
        {
            _dict = d;
            _maxLength = length;
            _results = tester(w);
        }

        public List<String> Results { get { return _results; } set { } }
        
        
        private static List<String> tester(String s)
        {


            var list = new List<char>(s.Length);
            List<String> endresult = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                list.Add(s[i]);
            }

            var result = new List<List<char>>();
            for (int i = 0; i < (1 << _maxLength); i++)
            { // 1 << n == the n-th power of 2
                var sublist = new List<char>();
                for (int j = 0; j < list.Count; j++)
                {   // analyze each bit in "i"
                    if ((i & (1 << j)) != 0)
                    {                                 // if the j-th bit of i is set...
                        sublist.Add(list[j]);         // add the item to the current sublist
                    }
                }
                result.Add(sublist);                 // add the current sublist to the final result
            }

            var lists = new List<String>();
            for (int i = 0; i < result.Count; i++)
            {
                String laber = "";
                for (int j = 0; j < result[i].Count; j++)
                {
                    laber += result[i][j];
                }
                lists.Add(laber);

                var mehr = Permutation(laber);
                for (int j = 0; j < mehr.Count; j++)
                {
                    lists.Add(mehr[j]);
                }
            }

            var temp = lists.Distinct().ToList();
            foreach (string st in temp)
            {
                if (_dict.isWord(st))
                {
                    endresult.Add(st);
                }
            }            
            
            return endresult;
        }


        private static List<String> Permutation(string input)
        {
            _perms.Clear();
            RecPermutation("", input);
            return _perms;

        }

        private static void RecPermutation(string soFar, string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                _perms.Add(soFar);
                return;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {

                    string remaining = input.Substring(0, i) + input.Substring(i + 1);
                    RecPermutation(soFar + input[i], remaining);
                }
            }
        }

    }
}
