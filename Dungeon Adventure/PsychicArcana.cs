using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public static class PsychicArcana
    {


       //static string saymypower(powername[n])
       //{
       //     string[] powername = {" Dark ", " Lifes' ", " Fires' ", " Trickerys' ", "Lights' "};
       //    Console.Write(" You have grown in {0} Power  "powername(n));
       //                        // Console.WriteLine(managoal);
       //    return 
        //}




        #region Color Starts
        public static void blueStart()
       {
           GameHelpers.SpaceandClean();
           Mana.myBlueMana();
           GameHelpers.TextSpace();
       }

        public static void blueColorStart()
        {
            GameHelpers.SpaceandClean();
            Mana.myBlueColorMana();
            GameHelpers.TextSpace();
        }

        public static void redStart()
        {
            GameHelpers.SpaceandClean();
            Mana.myRedMana();
            GameHelpers.TextSpace();
        }

        public static void redColorStart() {

            GameHelpers.SpaceandClean();
            Mana.myRedManaColor();
            GameHelpers.TextSpace();
        }


        public static void greenStart()
        {
            GameHelpers.SpaceandClean();
            Mana.myGreenMana();
            GameHelpers.TextSpace();
        }

        public static void greenColorStart()
        {

            GameHelpers.SpaceandClean();
            Mana.myGreenManaColor();
            GameHelpers.TextSpace();
        }

        public static void whiteStart()
        {
            GameHelpers.SpaceandClean();
            Mana.myWhiteMana();
            GameHelpers.TextSpace();
        }

        public static void whiteColorStart()
        {

            GameHelpers.SpaceandClean();
            Mana.myWhiteManaColor();
            GameHelpers.TextSpace();
        }

        public static void blackStart()
        {
            GameHelpers.SpaceandClean();
            BlackMana.myBlackMana();
            GameHelpers.TextSpace();
        }

        public static void blackColorStart()
        {

            GameHelpers.SpaceandClean();
            BlackMana.myBlackManaColor();
            GameHelpers.TextSpace();
        }
        #endregion Color Starts

    }

   

