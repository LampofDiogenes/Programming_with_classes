using System;

class circle : shape
{
    private double _radius = 0;
    // Constructor

    public circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }
    // Setters
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    // Getters
    public double GetRadius()
    {
        return _radius;
    }
    // calculating area
    public override double GetArea()
    {
        return _radius * 2 * Math.PI;
    }
}