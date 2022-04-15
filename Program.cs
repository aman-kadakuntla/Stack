using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackOperations stackOperations = new StackOperations(10);
            stackOperations.show();
            stackOperations.push(3);
            stackOperations.push(4);
            stackOperations.push(5);
            stackOperations.show();
            stackOperations.pop();
            stackOperations.show();
            Console.ReadLine();
        }
    }
}
