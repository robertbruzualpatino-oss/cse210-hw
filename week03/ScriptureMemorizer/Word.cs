using System;

public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public bool IsHidden()
    {
        return isHidden;
    }

    public string GetDisplayText()
    {
        if (isHidden)
        {
            string underscored = "";
            foreach (char letter in text)
            {
                if (char.IsLetter(letter))
                {
                    underscored += "_";
                }
                else
                {
                    underscored += letter;
                }
            }
            return underscored;
        }
        else
        {
            return text;
        }
    }
}