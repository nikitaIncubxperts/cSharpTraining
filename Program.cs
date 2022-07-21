using System;
using System.Collections;
namespace HashTable {
    public class Program {
        static void Main(string[] args) {
            Hashtable hashdata = new Hashtable();
            
            hashdata.Add(101,"harry");
            hashdata.Add(102, "greko");
            hashdata.Add(103, "malphoy");
            hashdata.Add(104, "harmieny");
            hashdata.Add(105, "ginger");

            Console.WriteLine("keys   Values");
            Console.WriteLine("--------------");
            foreach (DictionaryEntry k in hashdata) {                
                Console.WriteLine(k.Key+"   "+k.Value);
            }

            Console.WriteLine("\n");
            hashdata[103] = "dumbledore";
            Console.WriteLine("updated 103th index value in hashtable: ");
            foreach (DictionaryEntry k in hashdata) {
                Console.WriteLine(k.Key + "   " + k.Value);
            }

            Console.WriteLine("\n");
            hashdata.Remove(103);
            Console.WriteLine("Removed 103th index value: ");
            foreach (DictionaryEntry k in hashdata) {
                Console.WriteLine(k.Key + "   " + k.Value);
            }

            Console.WriteLine("\n");
            bool decision = hashdata.Contains(101);
            Console.WriteLine(decision);
                        
            DictionaryEntry[] hashdata2 = new DictionaryEntry[hashdata.Count];
            hashdata.CopyTo(hashdata2,0);
            Console.WriteLine("copying hashdata values to hashdata2");
            foreach (DictionaryEntry k in hashdata2) {
                Console.WriteLine(k.Key + "   " + k.Value);
            }

            Console.WriteLine("\n");
            hashdata.Clear();
            Console.WriteLine("cleared table: ");
            foreach (DictionaryEntry k in hashdata) {
                Console.WriteLine(k.Key + "   " + k.Value);
            }
        }
    }
}
