
using System;
using System.Speech.Synthesis;
using System.Threading;

public static class myGreenMana
{

    #region StartScreen
    public static void myGreenStartScreen(string welcometo, string mycolor, string manasent)
    {
        GameHelpers.SpaceandClean();



        Mana.myGreenManaColor();
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(welcometo + " Forests ");
        Console.WriteLine("The Power of " + mycolor + manasent);
        GameHelpers.TextAnimation(2500);
    }
    #endregion

    #region greenTxtScreen
    public static void greenTxtScreen()
    {

        GameHelpers.SpaceandClean();
        GameHelpers.TextSpace();
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.White;
    }
    #endregion

}