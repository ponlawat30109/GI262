using System;
using System.Collections.Generic;
using System.Linq;

namespace GI262
{
    class Program
    {
        static void Main(string[] args)
        {
            //BackwardPrint();
            //SumOfOdd();
            //Interest();
            //SplitStr();
            //Array();
            printMultiplicationTable();
        }

        static void Interest()
        {
            double money = 1000, firstMoney;
            firstMoney = money;
            for (int i = 1; i <= 5; i++)
            {
                money = money * 1.05;
                Console.WriteLine($"Result year {i} : {money:0.##}");
            }
            Console.WriteLine($"Total interest : {money - firstMoney:0.##}");
        }

        static void BackwardPrint()
        {
            for (int i = 10; i >= 0; i--)
            {
                //if (i != 4 && i != 8 && i != 9)
                //{
                //    Console.WriteLine(i);
                //}

                Console.Write((i != 4 && i != 8 && i != 9) ? $"{i}\n" : "");

                //if (i == 4 || i == 8 || i == 9)
                //{
                //    continue;
                //}
                //Console.WriteLine(i);
            }
        }

        static void SumOfOdd()
        {
            int sum = 0;
            for (int i = 1; i <= 30; i++)
            {
                //if (i%2==1)
                //{
                //    Console.WriteLine(i);
                //}
                //sum += i;

                Console.Write((i % 2 == 1) ? $"{i}" : "\n");
                sum = (i % 2 == 1) ? sum = i : sum;
            }
            Console.WriteLine("Sum of odd beetween 1-30 is " + sum);
        }

        static void SplitStr()
        {
            string username = "Username";
            string text = "Username:message";
            string[] temp = text.Split(':');
            foreach (var i in temp)
            {
                Console.WriteLine(i);
            }

            if (temp[0] == username)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            //Console.WriteLine(text);
        }

        static void Array()
        {
            //List<int> number = new List<int>(Enumerable.Range(1, 10));
            //foreach (var i in number)
            //{
            //    Console.Write((i % 2 == 0) ? $"{i}\n" : null);
            //}

            Console.Write($"Please enter number of Rows: ");
            int.TryParse(Console.ReadLine(), out int rows);
            Console.Write($"Please enter number of Columns: ");
            int.TryParse(Console.ReadLine(), out int cols);
            Console.WriteLine("Matrix A is");

            int[,] matrixA = new int[rows, cols];
            int count = 0;
            int resultLenght = (rows * cols).ToString().Length;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrixA[i, j] = ++count;
                    if (matrixA[i, j].ToString().Length < resultLenght)
                    {
                        var temp = resultLenght - matrixA[i, j].ToString().Length;
                        Console.Write(string.Concat(Enumerable.Repeat(" ", temp)));
                    }
                    Console.Write($"{matrixA[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static int[,] createMultiplicationMatrix(int thenumber)
        {
            int[,] matrix = new int[9, 3];
            int count = 1;

            for (int i = 0; i < 9; i++)
            {
                matrix[i, 0] = thenumber;
                matrix[i, 1] = count++;
                matrix[i, 2] = thenumber * matrix[i, 1];
            }
            return matrix;
        }

        static void printMultiplicationTable()
        {
            Console.Write("Please enter multiplicationnumber: ");
            int.TryParse(Console.ReadLine(), out int number);
            //int[,] mulTable = createMultiplicationMatrix(int.Parse(Console.ReadLine()));
            Console.WriteLine("Program by: Ponlawat Suwanyukabordin 1620703171 2531 ");
            Console.WriteLine($"Multiplication table of {number} is:");
            int[,] mulTable = createMultiplicationMatrix(number);

            for (int i = 0; i < mulTable.GetLength(0); i++)
            {
                for (int j = 0; j < mulTable.GetLength(1); j++)
                {
                    Console.Write($"{mulTable[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
