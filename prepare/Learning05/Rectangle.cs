using System;

class rectangle : shape
{
    private double _length = 0;
    private double _width = 0;

    // Constructor
    public rectangle(double length, double width, string color) : base(color)
    {
        _width = width;
        _length = length;
    }
    // Setters
    public void SetLength(double length)
    {
        _length = length;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }
    // Getters
    public double GetWidth()
    {
        return _width;
    }
    public double GetLength()
    {
        return _length;
    }
    // calculating Area
    public override double GetArea()
    {
        return _width * _length;
    }
}