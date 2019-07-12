using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // RESTRICTION / FILTERING OPERATIONS
            // Find the words in the collection that start with the letter 'L'
            // List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            // IEnumerable<string> LFruits = from fruit in fruits
            //                               where fruit.StartsWith("L")
            //                               select fruit;

            // LFruits.ToList().ForEach(fruit => Console.WriteLine(fruit));


            // Which of the following numbers are multiples of 4 or 6
            // List<int> numbers = new List<int>()
            //     {
            //         15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            //     };

            // IEnumerable<int> fourSixMultiples = numbers.Where(num =>
            // {
            //     return num % 4 == 0 || num % 6 == 0;
            // });

            // fourSixMultiples.ToList().ForEach(num => Console.WriteLine(num));

            // ORDERING OPERATIONS
            // Order these student names alphabetically, in descending order (Z to A)
            // List<string> names = new List<string>()
            // {
            //     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            //     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            //     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            //     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            //     "Francisco", "Tre"
            // };

            // List<string> descend = names.OrderByDescending(i => i).ToList();

            // descend.ForEach(name => Console.WriteLine(name));


            // Build a collection of these numbers sorted in ascending order
            // List<int> numerals = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // List<int> numeralsAsc = numerals.OrderBy(i => i).ToList();

            // numeralsAsc.ForEach(num => Console.WriteLine(num));


            // AGGREGATE OPERATIONS
            // Output how many numbers are in this list
            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // Console.WriteLine(numbers.Count);


            // How much money have we made?
            // List<double> purchases = new List<double>()
            // {
            //     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            // };

            // Console.WriteLine(purchases.Sum());


            // What is our most expensive product?
            // List<double> prices = new List<double>()
            // {
            //     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            // };

            // Console.WriteLine(prices.Max());


            // PARTITIONING OPERATIONS
            /*
            Store each number in the following List until a perfect square
            is detected.

            Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            // List<int> wheresSquaredo = new List<int>()
            // {
            //     66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            // };

            // IEnumerable<int> beforeSquaredNum = wheresSquaredo.TakeWhile(num =>
            // {
            //     var number = Convert.ToInt32(Math.Sqrt(num));
            //     return number * number != num;
            // });

            // beforeSquaredNum.ToList().ForEach(num => Console.WriteLine(num));


            // USING CUSTOM TYPES
            // Build a collection of customers who are millionaires

            // List<Customer> customers = new List<Customer>() {
            //     new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            //     new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            //     new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            //     new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            //     new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            //     new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            //     new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            //     new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            //     new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            //     new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            // };

            // var millionaires = from customer in customers
            //                    where customer.Balance >= 1000000.00
            //                    select customer;


            // var banksGroup = from millionaire in millionaires
            //                  group millionaire by millionaire.Bank into newGroup
            //                  select new { Bank = newGroup.Key, Customers = newGroup.ToList() };

            // banksGroup.ToList().ForEach(bank =>
            // {
            //     Console.WriteLine($"{bank.Bank} - {bank.Customers.Count}");
            // });


            // JOINING TWO RELATED COLLECTIONS
            // Create some banks and store in a List
            List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
            };

            // Create some customers and store in a List
            List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

            /*
                You will need to use the `Where()`
                and `Select()` methods to generate
                instances of the following class.

                public class ReportItem
                {
                    public string CustomerName { get; set; }
                    public string BankName { get; set; }
                }
            */

            var millionaireReport = from customer in customers
                                    where customer.Balance >= 1000000.00
                                    orderby customer.Name.Split(' ')[1] ascending
                                    join b in banks on customer.Bank equals b.Symbol
                                    select new { CustomerName = customer.Name, BankName = b.Name };


            foreach (var item in millionaireReport)
            {
                Console.WriteLine($"{item.CustomerName} at {item.BankName}");
            }

        }
    }

    public class Bank
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
    }

    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }

    public class ReportItem
    {
        public string CustomerName { get; set; }
        public string BankName { get; set; }
    }
}
