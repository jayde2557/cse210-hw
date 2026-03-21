using System;
using System.Collections.Generic;
public class Scripture
{
    
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }

    }
    public void HideRandomWords(int numberToHide)
    {
       Random rand = new Random();
       for (int i = 0; i <numberToHide; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        } 
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (Word w in _words)
        {
            displayWords.Add(w.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()}\n\n{string.Join(" ", displayWords)}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }

        return true;
    }


}