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


        #region color pallette for foreground
        
      
      
       
       
     


        #region darkyellow
        public static void darkyellow()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        #endregion
        #region darkred
        public static void darkred()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        #endregion

        #region red
        public static void red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
#endregion


        #region blue
        public static void blue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        #endregion


        #region darkblue
        public static void darkblue()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }

        #endregion


        #region
        public static void darkgrey()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        #endregion

        #region gray
        public static void gray()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        #endregion


        #region white
        public static void white()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        #region darkgreen
        public static void darkgreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        #endregion
        #region black


        public static void black()
        {
            Console.ForegroundColor = ConsoleColor.Black;
        }
        #endregion

        #region lightgreen
        public static void lightgreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        #endregion

        #region yellow
        public static void yellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        #endregion

        #endregion
   
    
    }

