
// Import System namespace
using System;

// Main Program class
class Program
{
    // Entry point of program
    static void Main()
    {
        // Create Income Ledger
        Ledger<Income> incomeLedger = new Ledger<Income>();

        // Add income transaction
        incomeLedger.Add(new Income
        {
            Id = 1,                      // Set ID
            Date = DateTime.Today,       // Set today's date
            Amount = 1000,               // Set income amount
            Source = "Office Cash",      // Set income source
            Note = "Petty cash received" // Set note
        });

        // Create Expense Ledger
        Ledger<Expense> expenseLedger = new Ledger<Expense>();

        // Add first expense
        expenseLedger.Add(new Expense
        {
            Id = 2,                      // Set ID
            Date = DateTime.Today,       // Set date
            Amount = 200,                // Set amount
            Category = "Food",           // Set category
            Note = "Snacks"              // Set note
        });

        // Add second expense
        expenseLedger.Add(new Expense
        {
            Id = 3,                      // Set ID
            Date = DateTime.Today,       // Set date
            Amount = 150,                // Set amount
            Category = "Stationery",     // Set category
            Note = "Pens & paper"        // Set note
        });

        // Calculate totals
        decimal totalIncome = Calculator.CalculateTotal(incomeLedger);
        decimal totalExpense = Calculator.CalculateTotal(expenseLedger);

        // Calculate balance
        decimal balance = Calculator.CalculateBalance(totalIncome, totalExpense);

        // Display Income
        Console.WriteLine("----- INCOME -----");
        foreach (Income i in incomeLedger.All())
        {
            Console.WriteLine(i.ShowInfo());
        }

        // Display Expense
        Console.WriteLine("\n----- EXPENSE -----");
        foreach (Expense e in expenseLedger.All())
        {
            Console.WriteLine(e.ShowInfo());
        }

        // Display summary
        Console.WriteLine("\n-------------------");
        Console.WriteLine("Total Income  : " + totalIncome);
        Console.WriteLine("Total Expense : " + totalExpense);
        Console.WriteLine("Balance Left  : " + balance);
    }
}
