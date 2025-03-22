using System;
using System.Collections.Generic;

using System.Linq;

public class Scripture
{
    private Reference _reference;
    private string _text;

    private List<Word> _words;

    private Scripture()
    {
        _words = new List<Word>();
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = new List<Word>();

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWord(int numberToHide)
    {
       
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        Random random = new Random();
        int countToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < countToHide; i++)
        {
           
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();

            
            visibleWords.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        
        return $"{_reference.GetDislpayText()} - {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
   
        return _words.All(word => word.IsHidden());
    }
}
