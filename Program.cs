﻿using System.Collections;

namespace Advanced_Assigment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part02
            #region Q1
            //int[] array= { 1, 2, 3 ,2,1,5,1,3,2,5,5,5};
            // Dictionary<int, int> frequencyTable = new Dictionary<int, int>();
            // foreach (int i in array) 
            // { 
            //     if (frequencyTable.ContainsKey(i))
            //     {
            //         frequencyTable[i]++;

            //     }
            //     else
            //     {
            //         frequencyTable[i] = 1;
            //     }
            // }
            // Console.WriteLine("Element Freq Count");
            // foreach (var pair in frequencyTable) 
            // {
            //    Console.WriteLine($"Element: {pair.Key}, Frequency: {pair.Value}");
            // }

            #endregion
            #region Q2
            // Hashtable ht = new Hashtable()
            //{
            //    {"A",8 },
            //    {"B",25},
            //    {"C",10},
            //    {"D",40 },
            //    {"E",30 }
            //};
            // string MaxKey = null;
            // int MaxValue = int.MinValue;

            // foreach (DictionaryEntry entry in ht)
            // {
            //     {
            //         if ((int)entry.Value > MaxValue)
            //         {
            //             MaxValue = (int)entry.Value;
            //             MaxKey = (string)entry.Key;

            //         }
            //     }

            // }
            // Console.WriteLine($"Key with the highest value:{MaxKey} Value: {MaxValue}");
            #endregion
            #region Q3
            Hashtable ht = new Hashtable
            {
            { "key1", "sama" },
            { "key6", "sama" },
            { "key2", "habiba" },
            { "key3", "zeiad" },
            { "key4", "mohamed" }
            };
            Console.Write("Please Enter Target Value: ");
            string targetvalue=Console.ReadLine();

            bool found = false;
            foreach (DictionaryEntry entry in ht) 
            {
                if ((string)entry.Value == targetvalue) 
                {
                    Console.WriteLin(entry.Key);
                    found = true;
                }
            }
            if (!found) 
            {
                Console.WriteLine("Key not Found");
            }
            #endregion
        }
    }
}
