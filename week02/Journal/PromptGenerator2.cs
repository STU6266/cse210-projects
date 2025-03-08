using System;
using System.Collections.Generic;

public class PromptGenerator2
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "What could I have done better?",
        "where did I see the hand of the Lord in my day?",
        "What can i learn from today?",
        "What was the hardest part of my day?",
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
