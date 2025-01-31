using System.Transactions;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

// Constructor:
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // Add comment no return , just to add.
    public void AddComment (Comment comment)
    {
        _comments.Add(comment);
    }

    //method to return the number of comments.
    public int getCommentCount()
    {
        return _comments.Count;
    }

    //Method for displaing video content.
    public string getDisplayContent()
    {
        string displayContent = "Title: "+ _title + 
        "\nAuthor: " + _author + 
        "\nLength: " + _length + " seconds" + 
        "\nNumber of comments: " + getCommentCount() + "\n";

        foreach (var comment in _comments)
        {
            displayContent = displayContent + "- " + comment.getDisplayComment() + "\n";
        }
        return displayContent;
    }

}