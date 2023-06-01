using System;

class WritingAssignment : Assignment
{
    string _bookName;
    string _bookAuthor;

    public void SetWritingInformation(string BookName, string BookAuthor)
    {
        _bookName = BookName;
        _bookAuthor = BookAuthor;
    }
    public string GetWritingInformation()
    {
        return $"{_bookName} by {_bookAuthor}";
    }
}