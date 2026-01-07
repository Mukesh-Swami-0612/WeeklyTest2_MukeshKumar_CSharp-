// Import System namespace
// Required for basic C# features
using System;

// Interface declaration
// Interface is used to define rules
// Any class implementing this MUST implement ShowInfo()
interface IPrintable
{
    // Method declaration only (no body)
    // This method must return a string
    string ShowInfo();
}
