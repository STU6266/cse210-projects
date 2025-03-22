using System;
public class Reference
{
    private string _book;
    private int _chapter;

    private int _verse;
    private int _verseEnd;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;

        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _verseEnd = verseEnd;
    }

    public string GetDislpayText()
    {
        string text = $"{_book} {_chapter}:{_verse}";
        if (_verseEnd != 0 && _verseEnd != _verse)
        
        {
            text += $"-{_verseEnd}";
        }
        return text;
    }
}
