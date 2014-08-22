using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabblelicious
{
   class ScrabbleChecker
    {
    //    static List<String> perms = new List<String>();
    //    static void Main(string[] args)
    //    {
    //        TreeNode root = new TreeNode(' ', false);
    //        String temp;
    //        StreamReader input = new StreamReader("c:\\temp\\decrypted_deutsch.dic");


    //        while ((temp = input.ReadLine()) != null)
    //        {
    //            String temp1 = parseS(temp).ToLower();
    //            root.addWord(temp1, root);
    //        }

    //        input.Close();


    //        //-testing if possible words works----------------

    //        var word = "rmxyznna";
    //        var liste = tester(word);


    //        Console.Out.WriteLine("Starting Hand: " + word);
    //        Console.Out.WriteLine(liste.Count);
    //        for (int i = 0; i < liste.Count; i++)
    //        {
    //            if (root.isWord(liste[i]))
    //            {
    //                Console.Out.WriteLine(liste[i].ToString());
    //            }

    //        }


    //        Console.In.ReadLine();
    //    }


    //    private static List<String> tester(String s)
    //    {


    //        var list = new List<char>(s.Length);

    //        for (int i = 0; i < s.Length; i++)
    //        {
    //            list.Add(s[i]);
    //        }

    //        var result = new List<List<char>>();
    //        for (int i = 0; i < (1 << list.Count); i++)
    //        { // 1 << n == the n-th power of 2
    //            var sublist = new List<char>();
    //            for (int j = 0; j < list.Count; j++)
    //            {   // analyze each bit in "i"
    //                if ((i & (1 << j)) != 0)
    //                {                                 // if the j-th bit of i is set...
    //                    sublist.Add(list[j]);         // add the item to the current sublist
    //                }
    //            }
    //            result.Add(sublist);                 // add the current sublist to the final result
    //        }

    //        var lists = new List<String>();
    //        for (int i = 0; i < result.Count; i++)
    //        {
    //            String laber = "";
    //            for (int j = 0; j < result[i].Count; j++)
    //            {
    //                laber += result[i][j];
    //            }
    //            lists.Add(laber);

    //            var mehr = Permutation(laber);
    //            for (int j = 0; j < mehr.Count; j++)
    //            {
    //                lists.Add(mehr[j]);
    //            }
    //        }
    //        return lists.Distinct().ToList();
    //    }


    //    private static List<String> Permutation(string input)
    //    {
    //        perms.Clear();
    //        RecPermutation("", input);
    //        return perms;

    //    }

    //    private static void RecPermutation(string soFar, string input)
    //    {
    //        if (string.IsNullOrEmpty(input))
    //        {
    //            perms.Add(soFar);
    //            return;
    //        }
    //        else
    //        {
    //            for (int i = 0; i < input.Length; i++)
    //            {

    //                string remaining = input.Substring(0, i) + input.Substring(i + 1);
    //                RecPermutation(soFar + input[i], remaining);
    //            }
    //        }
    //    }

    //    private static String parseS(String s)
    //    {
    //        string st = s;
    //        int index = s.IndexOf("=");
    //        if (index > 0)
    //        {
    //            st = st.Substring(0, index);
    //        }
    //        return st;
    //    }
    }
}

