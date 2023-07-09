using System;

class Comment
{
    string _authorName;
    string _commentContent;
    public void SetAuthor(string author)
    {
        _authorName = author;
    }
    public string GetAuthor()
    {
        return _authorName;
    }
    public void SetComment(string comment)
    {
        _commentContent = comment;
    }
    public string GetComment()
    {
        return _commentContent;
    }
}