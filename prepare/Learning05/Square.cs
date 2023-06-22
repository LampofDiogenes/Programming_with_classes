using System;

class square : shape
{
    private double _side = 0;


    // constructor
    public square(double side, string color) : base(color)
    {
        _side = side;
    }
    // setters
    public void SetSide(double side)
    {
        _side = side;
    }
    // getters
    public double GetSide()
    {
        return _side;
    }
    // calculating area
    public override double GetArea()
    {
        return _side * _side;
    }
}