class Comment
{
    private string _userName;
    private string _text;

    //Constructor:
    public Comment(string userName, string text)
    {
        _userName = userName;
        _text = text;
    }

    // Method to display comments:
    public string getDisplayComment()
    {
        return _userName + ": " + _text;
    }

}