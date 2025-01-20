// This class generates random prompts (questions) for journaling.  
// It stores a list of prompts and selects one at random when requested.  
// Prompts help guide what to write in the journal.  

using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts;

    public PromptGenerator()
    {
        // those are my prompts:

        prompts = new List<string>
        {
            "What made me smile today?",
            "What did I learn today?",
            "Who did I help today?",
            "What am I grateful for today?",
            "What challenge did I face today?",
            "What could I have done better today?"
        };
    }

        //This part of the code is to generate a random prompt:
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count); 
        return prompts[index];
    }

    
    public List<string> GetSuggestions(string prompt)
    {
        // I added this part to define example responses for each prompt
        //  https://stackoverflow.com/questions/17887407/dictionary-with-list-of-strings-as-value?

        Dictionary<string, List<string>> _suggestions = new Dictionary<string, List<string>>
        {
            { "What made me smile today?", new List<string> 
                { 
                    "Seeing a beautiful sunset.",
                    "A kind gesture from a friend.",
                    "A funny video I watched online." 
                } 
            },
            { "What did I learn today?", new List<string> 
                { 
                    "How to cook a new recipe.",
                    "A helpful tip from a colleague.",
                    "A new word in another language." 
                } 
            },
            { "Who did I help today?", new List<string> 
                { 
                    "I helped a coworker with a project.",
                    "I listened to a friend who needed support.",
                    "I volunteered at a local charity." 
                } 
            },
            { "What am I grateful for today?", new List<string> 
                { 
                    "My family's health and happiness.",
                    "Having a stable job.",
                    "The little moments of joy I experienced." 
                } 
            },
            { "What challenge did I face today?", new List<string> 
                { 
                    "Balancing work and personal life.",
                    "Overcoming a technical problem at work.",
                    "Staying positive during a tough moment." 
                } 
            },
            { "What could I have done better today?", new List<string> 
                { 
                    "Managed my time more effectively.",
                    "Communicated more clearly in a meeting.",
                    "Taken a moment to relax and recharge." 
                } 
            }
        };

        // Returns suggestions for the prompt or an empty list if none exist.
        return _suggestions.ContainsKey(prompt) ? _suggestions[prompt] : new List<string>();
    }

}

    