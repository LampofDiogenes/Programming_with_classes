using System;

class Fraction
{
    private string TopNumber;
    private string BottomNumber;

    public void FractionFormat()
    {
        TopNumber = "1";
        BottomNumber = "1";
    }
    public void FractionFormat(string Top){
        TopNumber = Top;
        BottomNumber = "1";
    }
    public void FractionFormat(string Top, string Bottom){
        TopNumber = Top;
        BottomNumber = Bottom;
    }
    public string SetTop(string Top){
        TopNumber = Top;
        return TopNumber;
    }
    public string SetBottom(string Bottom){
        BottomNumber = Bottom;
        return BottomNumber;
    }
}