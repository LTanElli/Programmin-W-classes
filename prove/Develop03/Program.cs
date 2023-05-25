using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 9, 6);
        Scripture scripture = new Scripture(reference, "But the Lord knoweth all things from the beginning; wherefore, he prepareth a way to accomplish all his works among the children of men; for behold, he hath all power unto the fulfilling of all his words. And thus it is. Amen.");

        List<Word> wordsToHide = new List<Word>(scripture.GetWords());
        Random random = new Random();

        Console.WriteLine("Press Enter to hide words or type 'quit'.");
        Console.WriteLine();
        scripture.Display();

        while (wordsToHide.Count > 0)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

            for (int i = 0; i < 3; i++)
            {
                if (wordsToHide.Count == 0)
                    break;
                
                int index = random.Next(wordsToHide.Count);
                wordsToHide[index].Hide();
                wordsToHide.RemoveAt(index);
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine();
        }
    }
}

class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = CreateWordList(text);
    }

    private List<Word> CreateWordList(string text)
    {
        List<Word> wordList = new List<Word>();

        string[] wordArray = text.Split(" ");

        foreach (string word in wordArray)
        {
            wordList.Add(new Word(word));
        }
        return wordList;
    }

    public void Display()
    {
        var displayedWords = _words.Select(word =>
        {
            if (word.GetHidden())
            {
                return new string('_', word._GetText().Length);
            }
            else
            {
                return word._GetText();
            }
        });
    }

    public Reference GetReference()
    {
        return _reference;
    }
    public string GetText()
    {
        return _text;
    }
    public List<Word> GetWords()
    {
        return _words;
    }
}

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string Display()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }

    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetStartVerse()
    {
        return _startVerse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }
}

public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public string _GetText()
    {
        return _text;
    }
    public bool GetHidden()
    {
        return _hidden;
    }
}