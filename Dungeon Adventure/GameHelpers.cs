using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


    public static class GameHelpers
    {

        #region Refresh Console
        public static void RefreshConsole()
        {
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    
    }

        #endregion


        #region Space and Clean
        public static void SpaceandClean()
        {
            Console.Clear();
            Console.WriteLine("\n \n");

        }
#endregion

# region TextSpace

public static void TextSpace()
{
    Console.WriteLine("\n \n");
}

#region TextAnimation


public static void TextAnimation(int time)
{
    

    Thread.Sleep(time);
    GameHelpers.SpaceandClean();
}
# endregion

#  endregion

#region Startup
public static void Startup()
        {
            Console.WindowHeight = Console.LargestWindowHeight;

            GameHelpers.RefreshConsole();
            GameHelpers.SpaceandClean();
        }

        #endregion
        #region DieRoll
        public static Int64 DieRoll()
        {

            Random rollone = new Random();
            Int64 temp;
            temp = rollone.Next(0, 6);
            Int64 dieresult;
            dieresult = temp;

            return dieresult;



        }
        #endregion


    }

