using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();

    public int numComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {numComments()}");
        Console.WriteLine("Comments:");

        foreach (Comment c in _comments)
        {
            c.Display();
        }
    }
}