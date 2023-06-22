using System;

class shape
{
    string _color = "";

    //constructor
    public shape(string color)
    {
        _color = color;
    }
    protected void SetColor(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public virtual double GetArea()
    {
        return -1;
    }
}