using System;
using System.Speech.Synthesis;
using System.Threading;

public static class myBlueMana
{

    #region StartScreen
    public static void myBlueStartScreen(string welcometo,  string mycolor, string manasent)
    {
        GameHelpers.SpaceandClean();
        Mana.myBlueMana();
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(welcometo + " Islands ");
        //Console.WriteLine(thepowerof[0][0] + mycolor[3] + manasent);

        Console.WriteLine("The Power of " + mycolor + manasent);
        GameHelpers.TextAnimation(2500);
    }
    #endregion

}