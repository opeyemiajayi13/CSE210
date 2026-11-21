using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private static Random _random = new Random();

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    // Hide a number of randomly selected visible words
    public void HideRandomWords(int numberToHide)
    {
        List<int> availableWords = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                availableWords.Add(i);
            }
        }

        for (int i = 0; i < numberToHide && availableWords.Count > 0; i++)
        {
            int randomPosition = _random.Next(availableWords.Count);
            int wordIndex = availableWords[randomPosition];

            _words[wordIndex].Hide();

            availableWords.RemoveAt(randomPosition);
        }
    }

    // Check whether all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    // Display the scripture reference and words
    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        return _reference.GetDisplayText() + " " +
               string.Join(" ", displayWords);
    }
}