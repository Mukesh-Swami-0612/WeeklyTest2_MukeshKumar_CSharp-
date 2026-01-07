// Import System namespace
// Needed for DateTime
using System;

// Abstract class declaration
// Abstract class cannot be directly created (no object)
abstract class CashTransaction : IPrintable
{
    // Stores unique ID of transaction
    public int Id;

    // Stores date of transaction
    public DateTime Date;

    // Stores amount of transaction
    public decimal Amount;

    // Stores extra note or description
    public string Note = "";

    // Abstract method
    // Child classes MUST implement this
    public abstract string ShowInfo();
}
