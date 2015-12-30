
using System;
using System.Speech.Synthesis;
using System.Threading;

public static class myRedMana
{

    #region StartScreen
    public static void myRedStartScreen(string welcometo, string mycolor, string manasent)
    {
        GameHelpers.SpaceandClean();

        
        Mana.myRedManaColor();
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(welcometo + " Mountains");
        


        Console.WriteLine("The Power of " + mycolor + manasent);
        GameHelpers.TextAnimation(2500);
    }
    #endregion

}