using System;
using System.Collections.Generic;

namespace GenericCollectionsProject {
    class Program {
        static void Main(string[] args) {

            var customers = new Customers();
            customers.LoadCustomers();
            customers.PrintCustomers();

        }
        static void Run() { 

            var rnd = new Random(); // used to generate random number

            List<int> frames = new List<int>(10); // collection has only 10 items

            for(var idx = 0; idx < 10; idx++) { // load 10 scores
                var score = rnd.Next(0, 31);
                frames.Add(score);
            }

            int total = 0;
            foreach(var frame in frames) { // sum the scores
                total += frame;
            }

            Console.WriteLine($"Game score is {total}");

        }
    }
}
