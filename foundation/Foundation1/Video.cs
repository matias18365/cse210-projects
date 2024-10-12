using System;
using System.Collections.Generic;
public class Video
{
    public string _title;
    public string _author;
    public int _lenghtInSeconds;
    public List<Comment> Comments;

    public Video(string title, string author, int lenghtInSeconds)
    {
        _title = title;
        _author = author;
        _lenghtInSeconds = lenghtInSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Lenght: {_lenghtInSeconds}");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
    }

    public void DisplayComment()
    {
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}