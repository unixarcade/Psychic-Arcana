
using System;
using System.Speech.Synthesis;
using System.Threading;

public static class myWhiteMana
{

    #region StartScreen
    public static void myWhiteStartScreen(string welcometo, string mycolor, string manasent)
    {
        GameHelpers.SpaceandClean();
        
        Mana.myWhiteManaColor();
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(welcometo + " Plains ");
        


        Console.WriteLine("The Power of " + mycolor + manasent);
        GameHelpers.TextAnimation(2500);
    }
    #endregion

}