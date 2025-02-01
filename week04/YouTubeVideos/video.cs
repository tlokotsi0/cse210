using System;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public string Title 
    { 
        get { return _title; } 
        private set { _title = value; } 
    }

    public string Author 
    { 
        get { return _author; } 
        private set { _author = value; } 
    }

    public int LengthInSeconds 
    { 
        get { return _lengthInSeconds; } 
        private set { _lengthInSeconds = value; } 
    }

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>(); 
    }

    public void AddComment(string commenterName, string text)
    {
        _comments.Add(new Comment(commenterName, text));
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public List<string> GetCommentSummaries()
    {
        List<string> summaries = new List<string>();
        foreach (var comment in _comments)
        {
            summaries.Add($"{comment.CommenterName}: {comment.Text}");
        }
        return summaries;
    }
}