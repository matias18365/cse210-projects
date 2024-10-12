using System;
public class Comment
{
    public string _user;
    public string _commentText;
    public datetime _commentDate;

    public Comment(string user, string comment, datetime commentDate)
    {
        _user = user;
        _commentText = comment;
        _commentDate = commentDate;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_user} commented on {_commentDate}: "{_commentText}"");
    }
}