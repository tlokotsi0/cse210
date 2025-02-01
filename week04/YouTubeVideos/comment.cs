public class Comment
{
    private string _commenterName;
    private string _text;

    public string CommenterName 
    { 
        get { return _commenterName; } 
        private set { _commenterName = value; } 
    }

    public string Text 
    { 
        get { return _text; } 
        private set { _text = value; } 
    }

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

}
