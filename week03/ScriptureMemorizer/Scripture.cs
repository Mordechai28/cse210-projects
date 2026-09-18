using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split text by space and initialize Word objects
        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        // Stretch Requirement: Find only words that are NOT hidden yet
        List<Word> unhiddenWords = _words.FindAll(w => !w.IsHidden());

        if (unhiddenWords.Count == 0)
        {
            return;
        }

        for (int i = 0; i < numberToHide && unhiddenWords.Count > 0; i++)
        {
            int index = random.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
            unhiddenWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        List<string> displayedWords = new List<string>();
        foreach (Word word in _words)
        {
            displayedWords.Add(word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()} {string.Join(" ", displayedWords)}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.TrueForAll(w => w.IsHidden());
    }
}