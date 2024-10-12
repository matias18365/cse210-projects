using System;
using System.Collections;
using System.Collections.Generic;
public class Comment
{
    public string _user;
    public string _commentText;
    public System.DateTime _commentDate;

    public Comment(string user, string comment, System.DateTime commentDate)
    {
        _user = user;
        _commentText = comment;
        _commentDate = commentDate;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_user} commented on {_commentDate}: '{_commentText}'");
    }
}