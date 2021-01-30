using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Work19Jan
{
    class SortedListEg
    {
        static void Main()
        {
            char ch = 'y';
            SortedList sl = new SortedList();
            sl.Add("A","FIRST");
            sl.Add("C", "THIRD");
            sl.Add("B", "SECOND");
            sl.Add("D", "FOURTH");
            foreach (DictionaryEntry de in sl)
            {
                Console.WriteLine(de.Key +"-->"+ de.Value);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Menu Driven Program for *SORTEDLIST METHODS* ");
            while (ch == 'y')
            {
                //ListOfMethods
                Console.WriteLine("\n");
                Console.WriteLine("1.Contains");
                Console.WriteLine("2.ContainsKey and Containsvalue");
                Console.WriteLine("3.CopyTo");
                Console.WriteLine("4.GetEnumerator");
                Console.WriteLine("5.GetHashCode");
                Console.WriteLine("6.IndexOfKey");
                Console.WriteLine("7.RemoveAt");
                Console.WriteLine("8.SetByIndex");
                Console.WriteLine("9.TrimToSize");
                Console.WriteLine("10.EXIT");
                Console.WriteLine("-----------------------------------");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Contains int A ? " + sl.Contains("A"));
                        break;

                    case 2:
                        Console.WriteLine("Contains key C ? " + sl.ContainsKey("C"));
                        Console.WriteLine("Contains value Third ? " + sl.ContainsValue("Third"));
                        //case sentitive
                        break;

                    case 3:
                        Console.WriteLine("\n Using CopyTo");
                        DictionaryEntry[] de1 = new DictionaryEntry[sl.Count];
                        sl.CopyTo(de1, 0); //(Array, ArrayIndex)
                        for (int i = 0; i < de1.Length; i++)
                            Console.WriteLine(de1[i].Key + " --> " + de1[i].Value);
                        break;

                    case 4:
                        Console.WriteLine("\n Using GetEnumerator: ");
                        IDictionaryEnumerator ie2 = sl.GetEnumerator();
                        while (ie2.MoveNext())
                            Console.WriteLine(ie2.Key + " --> " + ie2.Value);
                        break;

                    case 5:
                        Console.WriteLine("HashCode as : " + sl.GetHashCode());
                        break;

                    case 6:
                        Console.WriteLine("\n Using IndexOfKey : ");
                        Console.WriteLine("Index of B is : " + sl.IndexOfKey("B"));
                        break;

                    case 7:
                        Console.WriteLine("After Removing C : THIRD: ");
                        sl.RemoveAt(2);
                        foreach (DictionaryEntry de in sl)
                        {
                            Console.WriteLine($"Key is : {de.Key} and value as : {de.Value}");
                        }
                        break;

                    case 8:
                        Console.WriteLine("After Setting Index of [2] Look at C : ");
                        sl.SetByIndex(2, "TWO");
                        foreach (DictionaryEntry de in sl)
                        {
                            Console.WriteLine($"Key is : {de.Key} and value as : {de.Value}");
                        }
                        break;

                    case 9:
                        Console.WriteLine("After Trimming : ");
                        sl.TrimToSize(); //sets to original sorted list 
                        foreach (DictionaryEntry de in sl)
                        {
                            Console.WriteLine($"Key is : {de.Key} and value as : {de.Value}");
                        }
                        break;

                    case 10:
                        Console.WriteLine("Exit Application\n");
                        ch = 'n';
                        break;

                    default:
                        Console.WriteLine("Invalid Input\n");
                        break;
                }
            }
            Console.WriteLine("To get keyList");
            IList il = sl.GetKeyList();
            foreach (var item in il)
            {
                Console.WriteLine(item);

            }
        }
    }
}
