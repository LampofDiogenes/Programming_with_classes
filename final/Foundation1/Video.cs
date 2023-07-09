using System;
using System.Linq;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private int _seconds;
    List<Comment> _allComments = new List<Comment>();
    
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetTitle()
    {
        return _title;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public void SetSeconds(int seconds)
    {
        _seconds = seconds;
    }
    public int GetSeconds()
    {
        return _seconds;
    }
    public void StoreComment(Comment comment)
    {
        _allComments.Add(comment);
    }
    public List<Comment> ShowComments()
    {
        return _allComments;
    }
}