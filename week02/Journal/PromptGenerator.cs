using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What was the best part of your day?",
            "Who was the most interesting person you met today?",
            "How did you see the hand of God in your life today?",
            "What is something you are grateful for today?",
            "What was the strongest emotion you felt today?",
            "What challenge did you overcome today?",
            "What is one thing you learned today?",
            "If you could change one thing about today, what would it be?",
            "What made you smile today?",
            "What is one goal you want to achieve tomorrow?"
        };

        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);

        return _prompts[index];
    }
}