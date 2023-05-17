using System;

class Fraction
{
    private string TopNumber;
    private string BottomNumber;

    // 3 forms, to allow the programmer to input 3 different amount of parameters (0 parameters, 1 parameter
    // or 2 parameters).
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


    // Literally just reports 3/4
    public string GetFractionString(){
        TopNumber = "3";
        BottomNumber = "4";

        string FractionString = TopNumber + "/" + BottomNumber;
        return FractionString;
    }


    // converts fractions to decimals
    public int GetDecimalValue(){
        int TopInt = Int32.Parse(TopNumber);
        int BottomInt = Int32.Parse(BottomNumber);
        int FractionDecimal = TopInt / BottomInt;
        return FractionDecimal;
    }


    // my Setters
    public string SetTop(string Top){
        TopNumber = Top;
        return TopNumber;
    }
    public string SetBottom(string Bottom){
        BottomNumber = Bottom;
        return BottomNumber;
    }


    // my Getters
    public string GetTop(){
        return TopNumber;
    }
    public string GetBottom(){
        return TopNumber;
    }
}