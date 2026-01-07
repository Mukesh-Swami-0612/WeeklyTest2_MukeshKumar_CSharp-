// Import System namespace
using System;

// Income class
// Inherits CashTransaction
class Income : CashTransaction
{
    // Stores income source
    public string Source = "";

    // Override ShowInfo() method
    public override string ShowInfo()
    {
        // Return formatted income details
        return "INCOME  | " + Amount + " | " + Source + " | " + Note;
    }
}
