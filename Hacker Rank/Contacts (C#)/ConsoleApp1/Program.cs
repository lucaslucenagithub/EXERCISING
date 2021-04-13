using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    class Node
    {
        public Node()
        {
            Children = new List<Node>();
            Ends = 0;
        }

        public Node(char letter)
        {
            Letter = letter;
            Children = new List<Node>();
            Ends = 0;
        }

        public char Letter { get; private set; }
        public List<Node> Children { get; private set; }
        public int Ends { get; private set; }

        public Node FindOrCreateChild(char letter)
        {
            Ends++;
            return FindChild(letter) ?? CreateChild(letter);
        }

        public Node CreateChild(char letter)
        {
            var newChild = new Node(letter);
            Children.Add(newChild);
            return newChild;
        }

        public Node FindChild(char letter)
        {
            return Children.Where(x => x.Letter == letter).FirstOrDefault();
        }
    }

    class Trie
    {
        public Trie()
        {
            Root = new Node();
        }

        char Char { get; set; }
        Node Root { get; set; }
        int Ends { get; set; }

        public void Add(string word)
        {
            var currentNode = Root;

            foreach (char letter in word)
            {
                currentNode = currentNode.FindOrCreateChild(letter);
            }

            currentNode.FindOrCreateChild('*');
        }

        public int GetMatchCount(string partial)
        {
            var currentNode = Root;
            foreach (char letter in partial)
            {
                var childNode = currentNode.FindChild(letter);
                if (childNode == null) return 0;

                currentNode = childNode;
            }

            return currentNode.Ends;
        }
    }

    static List<int> contacts(string[][] queries)
    {
        var result = new List<int>();
        var trie = new Trie();

        for (int i = 0; i < queries.Count(); i++)
        {
            if (queries[i][0] == "add")
            {
                trie.Add(queries[i][1]);
            }

            if (queries[i][0] == "find")
            {
                result.Add(trie.GetMatchCount(queries[i][1]));
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter("TESTE", true);

        int queriesRows = Convert.ToInt32(Console.ReadLine());

        string[][] queries = new string[queriesRows][];

        for (int queriesRowItr = 0; queriesRowItr < queriesRows; queriesRowItr++)
        {
            queries[queriesRowItr] = Console.ReadLine().Split(' ');
        }

        List<int> result = contacts(queries);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
