using System;
using System.Collections.Generic;

namespace Lab2_3
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Plate { get; set; }
        public Car(string brand, string model, int year, string plate)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Plate = plate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] BrandArr = new string[] { "Toyota", "Honda", "BMW" };
            string[] ModelArr = new string[] { "Camry", "Civic", "Series 5" };
            int[] YearArr = new int[] { 2018, 2019, 2020 };
            string[] PlateArr = new string[] { "AB1234", "BA456", "CC5555" };
            LinkedList<Car> CarLL = new LinkedList<Car>();
            CarLL = convertArrayToLinkedList(BrandArr, ModelArr, YearArr, PlateArr);
            printList(CarLL);
        }
        static LinkedList<Car> convertArrayToLinkedList(string[] brandArr, string[] modelArr, int[] yearArr, string[] plateArr)
        {
            LinkedList<Car> Cars = new LinkedList<Car>();
            for (int i = 0; i < brandArr.Length; i++)
            {
                Car newCar = new Car(brandArr[i], modelArr[i], yearArr[i], plateArr[i]);
                Cars.AddLast(newCar);
            }
            return Cars;
        }

        static void printList(LinkedList<Car> cList)
        {
            int i = 1;
            foreach (var car in cList)
            {
                Console.WriteLine($"No.{i} is");
                Console.WriteLine($"Brand: {car.Brand}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"License Plate: {car.Plate}");
                Console.WriteLine($"==============================================================");
                i++;
            }
        }
    }
}

