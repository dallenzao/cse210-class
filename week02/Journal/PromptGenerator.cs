using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What lesson did I learn today?",
        "What made me smile today?",
        "What is something I could have done better today?",
        "Who showed kindness to me today?",
        "What was the most challenging part of my day?",
        "What are three things I am grateful for today?",
        "How did I grow as a person today?",
        "What did I do today that made me proud?",
        "What made today unique?",
        "How did I take care of myself today?",
        "What surprised me today?",
        "Whats something I want to remember from today?",
        "How did I connect with others today?",
        "What was something new I learned today?",
        "What did I do today that aligned with my values?",
        "If I could change one thing about today, what would it be?",
        "What small moment made today better?",
        "What made me feel at peace today?",
        "What was the hardest decision I faced today?",
        "What is one way I helped someone today?"
    };

    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            return "No prompts available.";
        }

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}