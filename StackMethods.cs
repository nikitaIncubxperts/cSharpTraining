using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable {
    public class StackMethods {
        public void StackFun() {
            Stack s = new Stack();

            s.Push("Foo");
            s.Push(102);
            s.Push("Bar");
            s.Push(104);
            s.Push("Zoo");

            Console.WriteLine("\nIterating Stack: ");
            foreach (var i in s) {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nremoving element using pop method ");
            Console.WriteLine(s.Pop());     //Removes and returns the object at the top

            Console.WriteLine("\nIterating Stack after removing top element: ");
            foreach (var i in s) {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nReturning top element using peek method ");
            Console.WriteLine(s.Peek());    //Returns the object at the top

            Console.WriteLine("\nCheck existance of Foo element");
            Console.WriteLine(s.Contains("Foo"));       //case sensitive
            Console.WriteLine("\nCheck existance of zoo element");
            Console.WriteLine(s.Contains("Zoo"));

            Console.WriteLine("\nIterating Stack-2 after cloning stack: ");
            foreach (var i in s) {
                Console.WriteLine(i);
            }

            s.Clear();
            Console.WriteLine("\nIterating Stack after cleaning stack: ");
            foreach (var i in s) {
                Console.WriteLine(i);
            }

        }
    }
}
