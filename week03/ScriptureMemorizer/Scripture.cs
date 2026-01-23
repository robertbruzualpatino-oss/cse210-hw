using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private ScriptureReference reference;
    private List<Word> words;
    private Random random;

    public Scripture(ScriptureReference reference, string text)
    {
        this.reference = reference;
        this.words = new List<Word>();
        this.random = new Random();

        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < count; i++)
        {
            if (visibleWords.Any())
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in words)
        {
            text += word.GetDisplayText() + " ";
        }
        return $"{reference.GetReference()} {text.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        return words.All(w => w.IsHidden());
    }
}