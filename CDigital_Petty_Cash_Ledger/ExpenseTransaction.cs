// Import System namespace
using System;

// Expense class
// Inherits CashTransaction
class Expense : CashTransaction
{
    // Stores expense category (Food, Travel etc.)
    public string Category = "";

    // Override ShowInfo() method
    public override string ShowInfo()
    {
        // Return formatted expense details
        return "EXPENSE | " + Amount + " | " + Category + " | " + Note;
    }
}
