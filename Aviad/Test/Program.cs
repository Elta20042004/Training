using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        // Can't Do this:   var m1 = new MainClass();
        var m1 = MainClass.Build((decimal)3.56, 3);
    }
}

class MainClass
{
    private decimal g;
    public int G;

    private MainClass()
    {
    }

    public static MainClass Build(decimal g, int G)
    {
        // Long processing !!!
        // Many validations 
        var mainClass = new MainClass();
        mainClass.g = g;
        mainClass.G = G;

        return mainClass;
    }

    public void Display(decimal anArg)
    {
        this.g = anArg;
    }
}