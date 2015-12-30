using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public static class PsychicArcana
    {


      public static void saymypower(int powernameindex, int managoal)
       {
           string[] powername = {" Dark ", " Lifes' ", " Fires' ", " Trickerys' ", "Lights' "};
        Console.Write(" You have grown in {0} Power  ",  powername[powernameindex]);
       Console.WriteLine(managoal);
        }

      public static void powerfail(int powernameindex, int managoal)
      {
          string[] powername = { " Dark ", " Lifes' ", " Fires' ", " Trickerys' ", "Lights' " };
          Console.Write(" You may never have grow strong enough to Weild {0} Power  ", powername[powernameindex]);
          Console.WriteLine(managoal);

      }


        #region Color Starts
        public static void blueStart()
       {
           GameHelpers.SpaceandClean();
           Mana.myBlueMana();
           GameHelpers.TextSpace();
           Console.BackgroundColor = ConsoleColor.DarkBlue;
           Console.ForegroundColor = ConsoleColor.White;

       }

        public static void blueColorStart()
        {
            GameHelpers.SpaceandClean();
            Mana.myBlueColorMana();
            GameHelpers.TextSpace();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void redStart()
        {
            GameHelpers.SpaceandClean();
            Mana.myRedMana();
            GameHelpers.TextSpace();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void redColorStart() {

            GameHelpers.SpaceandClean();
            Mana.myRedManaColor();
            GameHelpers.TextSpace();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void greenStart()
        {
            GameHelpers.SpaceandClean();
            Mana.myGreenMana();
            GameHelpers.TextSpace();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void greenColorStart()
        {

            GameHelpers.SpaceandClean();
            Mana.myGreenManaColor();
            GameHelpers.TextSpace();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void whiteStart()
        {
            GameHelpers.SpaceandClean();
            Mana.myWhiteMana();
            GameHelpers.TextSpace();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void whiteColorStart()
        {

            GameHelpers.SpaceandClean();
            Mana.myWhiteManaColor();
            GameHelpers.TextSpace();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void blackStart()
        {
            GameHelpers.SpaceandClean();
            BlackMana.myBlackMana();
            GameHelpers.TextSpace();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void blackColorStart()
        {

            GameHelpers.SpaceandClean();
            BlackMana.myBlackManaColor();
            GameHelpers.TextSpace();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        #endregion Color Starts

        #region Blue
        //public static void blueColorFooter(powername[3], mycolor[3], managoal)
        //{
            
        //    Console.WriteLine(" You have grown in {0}, power  ", powername[3]);
        //    Console.WriteLine(" You have Grown in the power of {0}, mana!", mycolor[3]);
        //    Console.WriteLine(" Mana Collected: {0}", managoal);
        //}

       //end blue
        #endregion


    }

   

