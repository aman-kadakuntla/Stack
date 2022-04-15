using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation
{
    internal class StackOperations
    {
        static int top;
        static int[] arr;
        public StackOperations(int capacity)
        {
            arr = new int[capacity];
            top = -1;
        }
        public void push(int a)
        {
            if (top == arr.Length - 1)
                Console.WriteLine("Stack is full");
            else
            {
                arr[++top] = a;
            }
        }
        public void pop()
        {
            if (top == -1)
                Console.WriteLine("Stack is empty");
            else
                top--;
        }
        public void pop(int NumberOfElementsToBeDeleted)
        {
            if (top == -1)
                Console.WriteLine("Stack is empty");
            else
            {
                for (int i = 0; i < NumberOfElementsToBeDeleted; i++)
                    top--;
            }
        }
        public void show()
        {
            if (top == -1)
                Console.WriteLine("Stack is empty");
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
