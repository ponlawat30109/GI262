using System;
using System.Collections.Generic;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = new int[] { 1001, 1002, 1003, 1004 };
            int[] secondArr = new int[] { 1005, 1006, 1007, 1008, 1009 };

            LinkedList<int> intLL = new LinkedList<int>(firstArr);

            foreach (int add in secondArr)
            {
                intLL.AddLast(add);
            }

            Console.Write($"There are {intLL.Count} members in Linked List, Members are : ");

            int count = 0;
            foreach (int data in intLL)
            {
                count += 1;
                if (count == intLL.Count)
                {
                    Console.Write(data);
                }else{
                    Console.Write(data + " ,");
                }
            }
        }
    }
}

