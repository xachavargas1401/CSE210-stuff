using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private ScriptReference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(ScriptReference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{referenceText}\n\n{wordsText}";
    }

    public void HideRandomWords()
    {
        int wordsToHide = 3;
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
