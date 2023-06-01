using System;

class MathAssignent : Assignment
{
    string _textbookSection;
    string _problems;

    public void SetHomeworkList(string textBookSection, string problems)
    {
        _textbookSection = textBookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{_textbookSection} - {_problems}";
    }
}