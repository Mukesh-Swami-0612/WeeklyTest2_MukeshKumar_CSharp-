// Import System namespace
using System;

// Calculator class
// Used only for calculations
class Calculator
{
    // Generic method to calculate total
    public static decimal CalculateTotal<T>(Ledger<T> ledger)
        where T : CashTransaction
    {
        // Variable to store sum
        decimal total = 0;

        // Loop through transactions
        foreach (T item in ledger.All())
        {
            // Add amount to total
            total = total + item.Amount;
        }

        // Return total
        return total;
    }

    // Method to calculate balance
    public static decimal CalculateBalance(decimal income, decimal expense)
    {
        // Income minus expense
        return income - expense;
    }
}
