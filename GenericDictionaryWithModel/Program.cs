using System;
using System.Collections.Generic;

namespace GenericDictionaryWithModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Customer> MyDictionary = new Dictionary<string, Customer>();

            Customer c1 = new Customer() { Eno = 1, EName = "Vishal Alok"};
            Customer c2 = new Customer() { Eno = 2, EName = "Abhay" };
            Customer c3 = new Customer() { Eno = 3, EName = "Rohit" };


            MyDictionary.Add("BanaloreEmployee", c1);
            MyDictionary.Add("HyderabadEmployee", c2);
            MyDictionary.Add("ChennaiEmployee", c3);

            foreach (string s in MyDictionary.Keys)
                Console.WriteLine(s + " " +" ENo: "+ MyDictionary[s].Eno + " Ename: "+ MyDictionary[s].EName);
            Console.ReadLine();
        }
    }
    class Customer
    {
        public int Eno { get; set; }
        public string EName { get; set; }
    }
}
