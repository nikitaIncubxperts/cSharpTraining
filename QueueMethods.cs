using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable {
    public class QueueMethods {
        public void QueueMethodFun() {
            Queue queue = new();
            queue.Enqueue("QFoo");
            queue.Enqueue("QBar");
            queue.Enqueue("QZoo");
            queue.Enqueue(302);
            queue.Enqueue(908);

            Console.WriteLine("Count Total elements of Queue: "+queue.Count);

            Console.WriteLine("\nIterating Queue: ");
            foreach (var i in queue) {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nRemoved Top element of Queue is: "+queue.Dequeue());   //Removed Top element

            Console.WriteLine("\nReturning top element using peek method ");
            Console.WriteLine(queue.Peek());    //Returns the object at the top

            Console.WriteLine("\nCheck existance of QFoo element");
            Console.WriteLine(queue.Contains("QFoo"));       //case sensitive
            Console.WriteLine("\nCheck existance of 302 element");
            Console.WriteLine(queue.Contains(302));

            object[] arr = queue.ToArray();     //due to multiple datatypes, used object for copying queque
            Console.WriteLine("\nIterating Copied Array: ");
            foreach (var i in arr) {
                Console.WriteLine(i);
            }

            queue.Clear();
            Console.WriteLine("\nIterating queue after cleaning: ");
            foreach (var i in queue) {
                Console.WriteLine(i);
            }
        }
    }
}
