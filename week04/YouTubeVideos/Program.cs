using System;
using System.Collections.Generic;

class Comment
{
    public string _name;
    public string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"  - {_name}: \"{_text}\"");
    }
}

class Video
{
    public string _title;
    public string _author;
    public int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length: {_length}s");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video v1 = new Video("How to Learn C#", "CodeAcademy", 300);
        v1.AddComment(new Comment("Alice", "Great video!"));
        v1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        v1.AddComment(new Comment("Charlie", "Can you make part 2?"));
        videos.Add(v1);

        Video v2 = new Video("Cooking Pasta", "ChefMario", 450);
        v2.AddComment(new Comment("David", "Looks delicious."));
        v2.AddComment(new Comment("Eve", "Tried this, turned out great."));
        v2.AddComment(new Comment("Frank", "Simple and easy."));
        videos.Add(v2);

        Video v3 = new Video("Abstracting Code", "TechGuru", 600);
        v3.AddComment(new Comment("Grace", "Abstracting explained well."));
        v3.AddComment(new Comment("Heidi", "The analogy was perfect."));
        v3.AddComment(new Comment("Ivan", "Cleared up my confusion."));
        videos.Add(v3);

        foreach (Video vid in videos)
        {
            vid.Display();
        }
    }
}