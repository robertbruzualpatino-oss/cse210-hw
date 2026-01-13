public class Entry
{
    public string date { get; set; }
    public string promptText { get; set; }
    public string entryText { get; set; }

    // Separator for saving to a file. A symbol unlikely to appear in content.
    private const string Separator = "||";

    public Entry()
    {
        date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    // Constructor to create an Entry object from a file line
    public Entry(string fileLine)
    {
        string[] parts = fileLine.Split(new[] { Separator }, StringSplitOptions.None);
        if (parts.Length == 3)
        {
            date = parts[0];
            promptText = parts[1];
            entryText = parts[2];
        }
        else
        {
            throw new FormatException("Invalid entry format in file.");
        }
    }

    public override string ToString()
    {
        return $"Date: {date}\nPrompt: {promptText}\nEntry: {entryText}\n";
    }

    // Format the entry for saving to a file
    public string FormatForFile()
    {
        return $"{date}{Separator}{promptText}{Separator}{entryText}";
    }
}