using System;
using System.Collections.Generic;

public class Subsets
{
    static string[] words;

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the items (separated by commas):");
        string userInput = Console.ReadLine();


        words = userInput.Split(",");
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].Trim();
        }

        Console.WriteLine("The items you entered are:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        Queue<List<int>> subsetsQueue = new Queue<List<int>>();
        List<int> emptySet = new List<int>();
        subsetsQueue.Enqueue(emptySet);

        while (subsetsQueue.Count > 0)
        {
            List<int> subset = subsetsQueue.Dequeue();
            Print(subset);
            int start = -1;
            if (subset.Count > 0)
            {
                start = subset[subset.Count - 1];
            }
            for (int i = start + 1; i < words.Length; i++)
            {
                List<int> newSubset = new List<int>(subset);
                newSubset.Add(i);
                subsetsQueue.Enqueue(newSubset);
            }
        }
    }

    static void Print(List<int> subset)
    {
        Console.Write("[ ");
        for (int i = 0; i < subset.Count; i++)
        {
            int index = subset[i];
            if (index >= 0 && index < words.Length)
            {
                Console.Write($"{words[index]} ");
            }
        }
        Console.WriteLine("]");
    }
}
