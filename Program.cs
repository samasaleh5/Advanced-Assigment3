using System.Collections;

namespace Advanced_Assigment3
{
    internal class Program
    {
        #region ContainsDuplicateFunction
        static bool ContainsDuplicate(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int i in arr)
            {
                if (set.Contains(i)) return true;
                set.Add(i);
            }
            return false;
        }
        #endregion
        #region DisplaySTUFinction
        static void DisplayStudents(SortedDictionary<int, string> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }
        }
        #endregion
        #region DisplayEmp
        static void DisplayEmployees(SortedList<int, string> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }
        }
        #endregion
        #region MissingValueFunction
        static List<int> FindMissingNumbers(int[] array, int N)
        {
            List<int> missingNumbers = new List<int>();

            
            HashSet<int> numbersSet = new HashSet<int>(array);

            for (int i = 1; i <= N; i++)
            {
                if (!numbersSet.Contains(i))
                {
                    missingNumbers.Add(i);
                }
            }

            return missingNumbers;
        }
    
    #endregion
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
            //Hashtable ht = new Hashtable
            //{
            //{ "key1", "sama" },
            //{ "key6", "sama" },
            //{ "key2", "habiba" },
            //{ "key3", "zeiad" },
            //{ "key4", "mohamed" }
            //};
            //Console.Write("Please Enter Target Value: ");
            //string targetvalue=Console.ReadLine();

            //bool found = false;
            //foreach (DictionaryEntry entry in ht) 
            //{
            //    if ((string)entry.Value == targetvalue) 
            //    {
            //        Console.WriteLine(entry.Key);
            //        found = true;
            //    }
            //}
            //if (!found) 
            //{
            //    Console.WriteLine("Key not Found");
            //}
            #endregion
            #region Q4
            //string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //var anagrams=new Dictionary<string,List <string>>();
            //foreach (string word in words)
            //{ 
            //    string sortedword=new string(word.OrderBy(x => x).ToArray());
            //    if(!anagrams.ContainsKey(sortedword))
            //    {
            //        anagrams[sortedword] = new List<string>();
            //    }
            //    anagrams[sortedword].Add(word);
            //}
            //Console.WriteLine("Grouped Anagrams");
            //foreach (var anagram in anagrams.Values)
            //{
            //    Console.WriteLine($"[{string.Join(", ", anagram)}]");
            //}
            #endregion
            #region Q5
            //int[] numbers = { 1, 3, 4, 3, 2, 5 };
            //bool hashdup= ContainsDuplicate(numbers);
            //Console.WriteLine(hashdup?"Array Contains Duplicates":"Array has only unique elments");
            #endregion
            #region Q6
            //SortedDictionary<int,string> students = new SortedDictionary<int,string>();
            //students.Add(122, "sama"); 
            //students.Add(123, "habiba"); 
            //students.Add(124, "salma"); 
            //students.Add(125, "zeiad"); 
            //students.Add(126, "mohamed");


            //int searchid = 125;
            //if(students.TryGetValue(searchid,out string studentname))
            //{
            //    Console.WriteLine($"\nYou Search for Student with ID {searchid}: {studentname}");
            //}
            //else
            //{
            //    Console.WriteLine($"\nStudent ID {searchid} not found.");
            //}
            //int removeid = 126;
            //if (students.Remove(removeid, out studentname)) 
            //{
            //    Console.WriteLine($"\nStudent ID {removeid} removed with name {studentname}.");
            //}

            //DisplayStudents(students);
            #endregion
            #region Q7
            //SortedList<int, string> EmpDirectory = new SortedList<int, string>();
            //EmpDirectory.Add(105, "sama");
            //EmpDirectory.Add(103, "salma");
            //EmpDirectory.Add(102, "habiba");
            //EmpDirectory.Add(101, "huda");

            //Console.WriteLine("Employee Directory (Sorted by ID):");
            //DisplayEmployees(EmpDirectory);

            //int searchid = 105;
            //if (EmpDirectory.TryGetValue(searchid, out string empname))
            //{
            //    Console.WriteLine($"\nYou Search for Student with ID {searchid}: {empname}");
            //}
            //else
            //{
            //    Console.WriteLine($"\nStudent ID {searchid} not found.");
            //}

            //int removeid = 126;
            //if (EmpDirectory.Remove(removeid, out empname))
            //{
            //    Console.WriteLine($"\nStudent ID {removeid} removed with name {empname}.");
            //}

            //DisplayEmployees(EmpDirectory);

            #endregion
            #region Q8
            int N = 10;  
            int[] array = { 1, 2, 4, 6, 7, 8, 10 };  

            List<int> missingNumbers = FindMissingNumbers(array, N);

            Console.WriteLine("Missing numbers:");
            foreach (var num in missingNumbers)
            {
                Console.WriteLine(num);
            }
            #endregion

        }
    }
    }
