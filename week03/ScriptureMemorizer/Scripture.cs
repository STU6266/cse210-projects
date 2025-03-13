using System;
using System.IO.Compression;

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

    }

    public string GetDisplayText()
    {

    }

    public bool IsCompletelyHidden()
    {

    }


