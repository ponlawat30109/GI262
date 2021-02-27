using System;
using System.Collections.Generic;

namespace Lab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> couse = new Dictionary<string, string>();
            try
            {
                couse.Add("GI262", "Data Structure and Algorithm");
                couse.Add("GI161", "Object-Oriented Programming");
                couse.Add("GI263", "Introduction to Database");
                couse.Add("GI282", "Disruptive Innovation");
                couse.Add("GI365", "Introduction to Computer Graphics");
            }
            catch (ArgumentException err)
            {
                Console.WriteLine(err);
            }

            foreach (KeyValuePair<string, string> kvp in couse)
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }
        }
    }
}

