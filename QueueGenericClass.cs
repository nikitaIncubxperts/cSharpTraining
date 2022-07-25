using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection {
    public class QueueGenericClass {
        public static void QueueGenericMethod() { 
            Queue<string> queueObj = new Queue<string>();
            queueObj.Enqueue("Tomato");
            queueObj.Enqueue("Ginger");
            queueObj.Enqueue("Potato");
            queueObj.Enqueue("Chilli");
            queueObj.Enqueue("Rice");

            Console.WriteLine("Queue elements: ");
            foreach (var item in queueObj) {
                Console.WriteLine(item);
            }

            queueObj.Dequeue();
            Console.WriteLine("\nQueue elements after dequeue: ");
            foreach (var item in queueObj) {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nChecking existance of elememt 'Chilli': "+queueObj.Contains("Chilli"));
            Console.WriteLine("\nTotal elements in Queue: " + queueObj.Count());
            Console.WriteLine("\nShowing first element in queue: " + queueObj.Peek());

            string[] queueCopy = new string[queueObj.Count];
            queueObj.CopyTo(queueCopy,0);
            Console.WriteLine("\nCopied Queue: ");
            foreach (var item in queueCopy) {
                Console.WriteLine(item);
            }
        }
    }
}
