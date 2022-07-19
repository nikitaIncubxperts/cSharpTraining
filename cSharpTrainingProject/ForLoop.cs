using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpTrainingProject {
    public class ForLoop {
        public void ForLoopMethod() {
            string[] names = { "Ajay", "Mehul", "Girija" };
            int[] age = new int[4];
            age[0] = 12;
            age[1] = 10;
            age[2] = 16;
            age[3] = 20;
            Console.WriteLine("printing Names and Age using for loop");
            for (int n = 0; n < names.Length; n++) {
                Console.WriteLine("names: " + names[n] + " age: " + age[n]);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("Printing names using forEach Loop");
            foreach (string n in names) {
                Console.WriteLine(n);
            }
        }
        public void DoWhileLoop() {
            int age = 1;
            do {
                Console.WriteLine(age);
                if (age == 7) {
                    break;
                } else {
                    age++;
                }
            } while (age < 10);
        }
        public int WhileLoopMethod(int num) {
            int fact = 1;
            while (num != 1) {
                fact = fact * num;
                num--;
            }
            return fact;
        }

        public void NestedLoopMethod() {
            int i = 0, j = 0;
            for (i = 0; i <= 5; i++) {
                for (j = 0; j <= i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (i = 1; i <= 5; i++) {
                for (j = 1; j <= i; j++) {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        public void TernaryOperatorMethod() {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            bool canDrive = (age >= 18) ? true : false;
            if (canDrive == true) {
                Console.WriteLine("Age is valid for driving licence");
            } else {
                Console.WriteLine("Age is not valid for driving licence");
            }
        }
    }
}


