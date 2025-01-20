// This class represents a single journal entry with a date, a prompt, and a response.  
// The date is automatically set to the current date when the entry is created.  
// The ToString method formats the entry for display.  

using System;

public class Entry
{
    public string _prompt; 
    public string _response; 
    public string _date; 

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        
    }

    public override string ToString()
    {
        return "Date: " + _date + " - Prompt: " + _prompt + "\n" + _response;
    }
}



