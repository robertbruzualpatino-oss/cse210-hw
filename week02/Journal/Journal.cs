using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>
    {
        "What made you smile today?",
        "Describe a challenge you faced recently.",
        "What are you grateful for today?",
        "Write about a memorable moment from this week.",
        "What is a goal you have for the next month?",
        "Reflect on a book or movie that impacted you.",
        "Describe a place you would like to visit and why."
    };

    private Random random = new Random();

    public void WriteNewEntry()
    {
        string randomPrompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"\nPrompt: {randomPrompt}");
        Console.Write("Your Entry: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry
        {
            promptText = randomPrompt,
            entryText = response
        };
        entries.Add(newEntry);
        Console.WriteLine("Entry saved successfully.");
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("\nJournal is empty.");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
        Console.WriteLine("-----------------------");
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    outputFile.WriteLine(entry.FormatForFile());
                }
            }
            Console.WriteLine($"Journal saved to {filename} successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while svaving: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    entries.Add(new Entry(line));
                }
            }
            Console.WriteLine($"Journal loaded from {filename} successfully. Total entries: {entries.Count}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: The file {filename} was not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading: {ex.Message}");
        }
    }
}