// Import System namespace
// This namespace gives us access to basic C# features
// Example: Console class, DateTime structure
using System;


// Program class declaration
// Every C# application must have a class that contains Main()
class Program
{
    // Main method declaration
    // static → no object of Program class is needed
    // void → this method does not return anything
    // Main() → execution of program starts from here
    static void Main()
    {
        // ----------------------------
        // INCOME LEDGER CREATION
        // ----------------------------

        // Create an object of Ledger class
        // Ledger<Income> means this ledger will store Income objects only
        Ledger<Income> incomeLedger = new Ledger<Income>();

        // Add() method is used to insert a new Income transaction
        incomeLedger.Add(
            
            // Create a new Income object
            new Income
            {
                // Assign value 1 to Id variable
                Id = 1,

                // Assign today's date to Date variable
                // DateTime.Today gives current system date
                Date = DateTime.Today,

                // Assign income amount
                Amount = 1000,

                // Assign income source text
                Source = "Office Cash",

                // Assign description or note
                Note = "Petty cash received"
            }
        );


        // ----------------------------
        // EXPENSE LEDGER CREATION
        // ----------------------------

        // Create an object of Ledger class
        // Ledger<Expense> means this ledger will store Expense objects only
        Ledger<Expense> expenseLedger = new Ledger<Expense>();

        // Add first Expense transaction
        expenseLedger.Add(

            // Create a new Expense object
            new Expense
            {
                // Assign transaction ID
                Id = 2,

                // Assign today's date
                Date = DateTime.Today,

                // Assign expense amount
                Amount = 200,

                // Assign expense category
                Category = "Food",

                // Assign expense note
                Note = "Snacks"
            }
        );

        // Add second Expense transaction
        expenseLedger.Add(

            // Create another Expense object
            new Expense
            {
                // Assign transaction ID
                Id = 3,

                // Assign today's date
                Date = DateTime.Today,

                // Assign expense amount
                Amount = 150,

                // Assign expense category
                Category = "Stationery",

                // Assign expense note
                Note = "Pens & paper"
            }
        );


        // ----------------------------
        // CALCULATIONS
        // ----------------------------

        // Calculate total income
        // Calculator.CalculateTotal() loops through incomeLedger
        // and adds all Amount values
        decimal totalIncome = Calculator.CalculateTotal(incomeLedger);

        // Calculate total expense
        // Calculator.CalculateTotal() loops through expenseLedger
        decimal totalExpense = Calculator.CalculateTotal(expenseLedger);

        // Calculate remaining balance
        // Balance = totalIncome - totalExpense
        decimal balance = Calculator.CalculateBalance(totalIncome, totalExpense);


        // ----------------------------
        // DISPLAY INCOME DETAILS
        // ----------------------------

        // Print heading on console
        Console.WriteLine("----- INCOME -----");

        // foreach loop to go through each Income object in incomeLedger
        foreach (Income i in incomeLedger.All())
        {
            // Call ShowInfo() method of Income class
            // Print formatted income details
            Console.WriteLine(i.ShowInfo());
        }


        // ----------------------------
        // DISPLAY EXPENSE DETAILS
        // ----------------------------

        // Print expense heading with a blank line before it
        Console.WriteLine("\n----- EXPENSE -----");

        // foreach loop to go through each Expense object in expenseLedger
        foreach (Expense e in expenseLedger.All())
        {
            // Call ShowInfo() method of Expense class
            // Print formatted expense details
            Console.WriteLine(e.ShowInfo());
        }


        // ----------------------------
        // DISPLAY SUMMARY
        // ----------------------------

        // Print separator line
        Console.WriteLine("\n-------------------");

        // Print total income value
        Console.WriteLine("Total Income  : " + totalIncome);

        // Print total expense value
        Console.WriteLine("Total Expense : " + totalExpense);

        // Print remaining balance
        Console.WriteLine("Balance Left  : " + balance);
    }
}
