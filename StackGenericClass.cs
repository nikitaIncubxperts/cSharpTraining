using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection {
    public class StackGenericClass {
        public static void StackGenericMethod() {
            Stack<int> stackObj = new Stack<int>();
            stackObj.Push(5);
            stackObj.Push(4);
            stackObj.Push(3);
            stackObj.Push(2);
            stackObj.Push(1);

            Console.WriteLine("Printing Stack");
            foreach (var i in stackObj) {
                Console.Write(i + ",");
            }

            Console.WriteLine("\n\nRemove and return top element: "+ stackObj.Pop());
            Console.WriteLine("\nPrinting Stack");
            Console.WriteLine("Item left in stack : "+stackObj.Count());
            foreach (int i in stackObj) {
                Console.Write(i + ",");
            }

            Console.WriteLine("\nChecking existance of elememt '3': "+ stackObj.Contains(3));
            Console.WriteLine("\nPeeking top element: " + stackObj.Peek());

            int[] stackObj1 = new int[stackObj.Count];
            stackObj.CopyTo(stackObj1,0);
            Console.WriteLine("\nCopied Stack: ");
            foreach (int i in stackObj1) {
                Console.Write(i + ",");
            }
        }
    }
}


    /*
     Note:
    1. Generic stack is defined under System.Collections.Generic namespace :: Non-Generic stack is defined under System.Collections namespace.
    2. Generic stack can only store same type of elements ::	Non-Generic stack can store same type or different types of elements.
    3. There is a need to define the type of the elements in the stack :: There is no need to define the type of the elements in the stack.
    4. It is type-safe :: It is not type-safe.
     */
