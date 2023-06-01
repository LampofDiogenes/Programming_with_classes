using System;
class Assignment
{
    protected string _studentName;
    protected string _topic;

    // Method to combine StudentName and the Subject into a single string.
    public string GetSummary()
    {
        return _studentName + ": " + _topic;
    }

    // getters and Setters for subject and Student Name
    public void SetSubject(string subject)
    {
        _topic = subject;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetStudentName(string StudentName)
    {
        _studentName = StudentName;
    }  
    public string GetStudentName()
    {
        return _studentName;
    }
}