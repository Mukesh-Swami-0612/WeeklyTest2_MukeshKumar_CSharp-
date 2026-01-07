// Import System namespace
using System;

// Import generic collections
using System.Collections.Generic;

// Generic Ledger class
// T must be a CashTransaction type
class Ledger<T> where T : CashTransaction
{
    // List to store transactions
    private List<T> list = new List<T>();

    // Method to add transaction
    public void Add(T item)
    {
        // Add item to list
        list.Add(item);
    }

    // Method to get all transactions
    public List<T> All()
    {
        // Return list
        return list;
    }
}
