using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;

// Luminosity
// http://luminosity.livejournal.com


namespace Dungeon_Adventure
{


    class Program
    {

        #region myExit
        static void myexit()
        {
            Environment.Exit(0);
        }
        #endregion


        #region myYesNo
        static string myYesNo()
        {
            Console.WriteLine(" Yes or No? \n");
            Console.Write("            ");
            string yn = Console.ReadLine();
            yn = yn.ToUpper();
            if (yn == "YES" || yn == "Y" || yn == "YE")
            {
                yn = "YES";
            }
            else
            {
                yn = "NO";
            }

            GameHelpers.SpaceandClean();
            return yn;
        }
# endregion

        #region myRightLeft
        static string myRightLeft()
        {
            Console.WriteLine(" Right or Left? \n");
            Console.Write("             ");
            string rl = Console.ReadLine();
            rl = rl.ToUpper();
            if (rl == "RIGHT" || rl == "R")
            {
                rl = "RIGHT";

            }
            else
            {
                rl = "LEFT";
            }
            GameHelpers.SpaceandClean();
            return rl;
        }

        #endregion


        //static int mymanagoal(int managoal)
        //{

        //   int  counter = managoal;

        //   return counter;
        //}
        static void Main(string[] args)
        {
           
#region Vars

         string  name, adventure;
            int managoal = 0;
            Int32 answerchoice;
            string mychoice;
            string welcometo = " Welcome to the ";
            string[][] thepowerof = new string[][]{
                            new string[]{" The Power of "},
                            new string[]{" Green ", " Red ", " White ", " Blue ", " Black "},
                            new string[]{" mana infuses you. "}             
                                                      };
            string manasent = " mana infuses you. ";
            string[] mycolor = { " Green ", " Red ", " White ", " Blue ", " Black " };
            string[] mymananame = { "Forest ", " Mountain ", " Plains ", " Islands ", " Swamps " };
            string[] status = { " Initiate ", " Acolyte ", " Adept ", " Master ", " Avatar ", " Planes Walker" };
            string[] powername = {" Dark ", " Lifes' ", " Fires' ", " Trickerys' ", " Lights' "};

            ConsoleColor printblack = ConsoleColor.Black;
            ConsoleColor printwhite = ConsoleColor.White;
            ConsoleColor printdarkgrey = ConsoleColor.DarkGray;
            ConsoleColor printlightgrey = ConsoleColor.Gray;
            ConsoleColor printdarkblue = ConsoleColor.DarkBlue;
            ConsoleColor printlightblue = ConsoleColor.Blue;
            ConsoleColor printlightred = ConsoleColor.Red;
            ConsoleColor printdarkred = ConsoleColor.DarkRed;
            ConsoleColor printdarkyellow = ConsoleColor.DarkYellow;
            ConsoleColor printlightyellow = ConsoleColor.Yellow;
            ConsoleColor printlightgreen = ConsoleColor.Green;
            ConsoleColor printdarkgreen = ConsoleColor.DarkGreen;

#endregion
          
            

        


            // Game Start Up
            GameHelpers.Startup();

            
            
            

         //  Mana.myBlueColorMana();
            //Mana.myRedManaColor();
            //Mana.myGreenManaColor();
            //Mana.myWhiteManaColor();

            Console.WriteLine();


            BlackMana.myBlackManaColor();

            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                BlackMana.myPsychicArcanaTitle();
                synth.Speak("Psychic Arcana");
               
            }


        


            Console.WriteLine("");
            Console.Title = " Mindscape Dungeon Adventure ";
            Console.WriteLine();
            Console.WriteLine(" Welcome Adventurer ");
            Console.WriteLine(" What is your name? ");
            name = Console.ReadLine();

            #region Game Loop
            // Game Loop
            do {
                GameHelpers.RefreshConsole();
                


            Console.WriteLine(" Would you like to go on an adventure " + name);

           
            string mycode;
            mycode = myYesNo();

            if (mycode == "NO")
            {
                myexit();
            }

            if (mycode == "YES")
            {

                

                Console.WriteLine(" Then let the adventure begin ");
                Console.Write(" Do you want to go to the ");  
                Console.ForegroundColor = printlightgreen;
                Console.Write(" Forests, ");
                Console.ForegroundColor = printlightred;
                Console.Write(" Mountains, ");
                Console.ForegroundColor = printlightyellow;
                Console.Write(" Plains, ");
                 Console.ForegroundColor = printlightblue;
                Console.Write(" Islands, ");
                 Console.ForegroundColor = printlightgrey;
                Console.Write(" Swamps?  \n");


                adventure = Console.ReadLine();
                adventure = adventure.ToUpper();

               
#region Adventure_Short_Cut
                if ( adventure == "S")
                {
                adventure = "SWAMPS";
                }
                else if (adventure == "I")
                {
                    adventure = "ISLANDS";
                }else if (adventure == "F")
                {
                    adventure = "FORESTS";
                }
                else if (adventure == "M")
                {
                    adventure = "MOUNTAINS";
                }
                else if (adventure == "P")
                {
                    adventure = "PLAINS";
                }
               
#endregion






                switch (adventure)
                {

                    #region Forest Region
                    case "FORESTS":
                        // colorint = 0;
                        Mana.myGreenMana();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(welcometo + " Forests ");
                        Console.WriteLine(thepowerof[0][0] + mycolor[0] + manasent);
                        #region Adventure Choice One
                        // Adventure Choice One

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the forest you see some thing moving would you like to investigate further yes or no?");


                        mycode = myYesNo();
                        if (mycode == "YES")
                        {
                            Console.WriteLine(" Under further investigation you see a twinkle among the trees. ");
                            Console.WriteLine(" Would you like to climb the trees to try to get a better look yes or no?");
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                Console.WriteLine(" You see the forest sprites dancing around and they invite you down to play ");
                            }
                            else
                            {
                                GameHelpers.SpaceandClean();


                                Console.WriteLine("The forest sprites cast a spell on you and you fall into an eternal slumber");
                                break;
                            }
                            
                            //managoal++;
                            managoal = 2;


                            PsychicArcana.greenStart();

                            Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                            Console.Write(" You have grown in Dark Power  ");
                            Console.WriteLine(managoal);

                            Console.ReadKey();


                        }
                        else
                        {

                            GameHelpers.SpaceandClean();

                            
                            Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                            break;
                        }
                        # endregion

                        #region Adventure Choice Two
                        // Adventure Choice Two

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 2)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.greenStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Three
                        // Adventure Choice Three

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 3)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;



                                PsychicArcana.greenStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion




                        #region Adventure Choice Four
                        // Adventure Choice Four

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 4)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.greenStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Five
                        // Adventure Choice Five

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 5)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.greenStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion






                        #region Adventure Choice Six
                        // Adventure Choice Six

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 6)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;



                                PsychicArcana.greenStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion

                        #region Adventure Choice Seven
                        // Adventure Choice Seven

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 7)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.greenStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Eight
                        // Adventure Choice Eight

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 8)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.greenStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion




                        #region Adventure Choice Nine
                        // Adventure Choice Nine

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 9)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;



                                PsychicArcana.greenColorStart();

                                Console.WriteLine();
                                Console.WriteLine(" {0} You have found the sacred heart of the {1} the Mox Emerald. \n", name, mymananame[0]);

                                Console.Write(" You have grown in Lifes' Power  ");
                                Console.WriteLine(managoal);
                                

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Ten
                        // Adventure Choice Ten
                        if (managoal == 10)
                        {


                            PsychicArcana.greenColorStart();
                            Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");


                            mycode = myYesNo();

                            if (mycode == "YES")
                            {




                                GameHelpers.SpaceandClean();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();
                            }
                                break;


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        
                        
                       
                        
                        
                        # endregion
                        
                    #endregion
                        


                    #region Mountain Region
                    case "MOUNTAINS":
                        Mana.myRedMana();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(welcometo + " Mountains");
                        Console.WriteLine(thepowerof[0][0] + mycolor[1] + manasent);


                        #region Adventure Choice One
                        // Adventure Choice One

                        GameHelpers.SpaceandClean();
                        Console.WriteLine(" You See the Mountains in the distance. \n");
                        Console.WriteLine(" You continue walking forward the Mountains getting closer with every step. \n");
                        Console.WriteLine("At the edge of the Mountain you see a path do you continue with the ascent, yes or no? \n");


                        mycode = myYesNo();
                        if (mycode == "YES")
                        {


                            //managoal++;
                            managoal = 2;


                            PsychicArcana.redStart();

                            Console.WriteLine("{0}, You start to ascend the Mountain and you start to feel the red mana. ", name);




                         
                            PsychicArcana.saymypower(2, managoal);
                            Console.WriteLine(managoal);

                            Console.ReadKey();


                        }
                        else
                        {

                            GameHelpers.SpaceandClean();


                            Console.WriteLine("You may never grow strong enough to Wield the {0} Power", powername[2]);
                            break;
                        }
                        # endregion

                        #region Adventure Choice Two
                        // Adventure Choice Two

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("You walk on the mountain path and you make it to a fork in the road, do you want to go right or left?");

                        if (managoal == 2)
                        {
                            mycode = myRightLeft();
                            if (mycode == "RIGHT")
                            {
                                managoal++;



                                PsychicArcana.redStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                               
                                PsychicArcana.saymypower(2, managoal);
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else if (mycode == "LEFT")
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }

                            else
                            {
                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Three
                        // Adventure Choice Three

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 3)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;



                                PsychicArcana.redStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion




                        #region Adventure Choice Four
                        // Adventure Choice Four

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 4)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.redStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Five
                        // Adventure Choice Five

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 5)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.redStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion






                        #region Adventure Choice Six
                        // Adventure Choice Six

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 6)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;



                                PsychicArcana.redStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion

                        #region Adventure Choice Seven
                        // Adventure Choice Seven

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 7)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.redStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Eight
                        // Adventure Choice Eight

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 8)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.redStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion




                        #region Adventure Choice Nine
                        // Adventure Choice Nine

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 9)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;





                                PsychicArcana.redColorStart();

                                Console.WriteLine();
                                Console.WriteLine(" {0} You have found the sacred heart of the {1} the Mox Ruby. \n", name, mymananame[1]);

                                Console.Write(" You have grown in Fires' Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Ten
                        // Adventure Choice Ten
                        if (managoal == 10)
                        {
                            PsychicArcana.redColorStart();
                            Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");


                            mycode = myYesNo();

                            if (mycode == "YES")
                            {




                                GameHelpers.SpaceandClean();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();
                            }
                            break;


                        }
                        else
                        {

                            GameHelpers.SpaceandClean();
                            Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                            break;
                        }





                        # endregion
                    #endregion 



                    #region Plains Region
                    case "PLAINS":
                        Mana.myWhiteMana();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(welcometo + " Plains ");

                        Console.WriteLine(thepowerof[0][0] + mycolor[2] + manasent);


                        #region Adventure Choice One
                        // Adventure Choice One

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");


                        mycode = myYesNo();
                        if (mycode == "YES")
                        {


                            //managoal++;
                            managoal = 2;


                            PsychicArcana.whiteStart();

                            Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                            Console.Write(" You have grown in Dark Power  ");
                            Console.WriteLine(managoal);

                            Console.ReadKey();


                        }
                        else
                        {

                            GameHelpers.SpaceandClean();


                            Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                            break;
                        }
                        # endregion

                        #region Adventure Choice Two
                        // Adventure Choice Two

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 2)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.whiteStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Three
                        // Adventure Choice Three

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 3)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;



                                PsychicArcana.whiteStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion




                        #region Adventure Choice Four
                        // Adventure Choice Four

                        PsychicArcana.whiteStart();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 4)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                GameHelpers.SpaceandClean();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Five
                        // Adventure Choice Five

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 5)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.whiteStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion






                        #region Adventure Choice Six
                        // Adventure Choice Six

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 6)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;



                                PsychicArcana.whiteStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion

                        #region Adventure Choice Seven
                        // Adventure Choice Seven

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 7)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.whiteStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Eight
                        // Adventure Choice Eight

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 8)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.whiteStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion




                        #region Adventure Choice Nine
                        // Adventure Choice Nine

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 9)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;



                                PsychicArcana.whiteColorStart();

                                Console.WriteLine();
                                Console.WriteLine(" {0} You have found the sacred heart of the {1} the Mox Pearl. \n", name, mymananame[2]);

                                Console.Write(" You have grown in Lights' Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Ten
                        // Adventure Choice Ten
                        if (managoal == 10)
                        {
                            GameHelpers.SpaceandClean();
                            Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");


                            mycode = myYesNo();

                            if (mycode == "YES")
                            {




                                PsychicArcana.whiteColorStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.Write(" You have grown in Dark Power  ");
                                Console.WriteLine(managoal);

                                Console.ReadKey();
                            }
                            break;


                        }
                        else
                        {

                            GameHelpers.SpaceandClean();
                            Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                            break;
                        }





                        # endregion
                    #endregion



                    #region Island Region
                    case "ISLANDS":
                        Console.ReadKey();
                        GameHelpers.SpaceandClean();
                        Mana.myBlueMana();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(welcometo + " Islands ");
                        Console.WriteLine(thepowerof[0][0] + mycolor[3] + manasent);

                        #region Adventure Choice One
                        // Adventure Choice One

                        
                         Console.ReadKey();
                        GameHelpers.SpaceandClean();
                        Console.WriteLine(" You set off to the islands ");
                        Console.WriteLine(" {0} it's you the crew and the shallows ", name);
                        Console.WriteLine(" Do you want to continue to the open sea?");
                       


                        mycode = myYesNo();
                        if (mycode == "YES")
                        {


                            //managoal++;
                            managoal = 2;


                            PsychicArcana.blueStart();

                            Console.WriteLine("  Out to the open sea you sail, {0}. ", name);




                            //Console.WriteLine(" You have grown in {0} power. \n  ", powername[3]);
                            //Console.WriteLine(" You have Grown in the power of {0}, mana!", mycolor[3]);
                            //Console.WriteLine(" Mana Collected: {0}", managoal);
                            PsychicArcana.saymypower(3, managoal);

                            Console.ReadKey();


                        }
                        else
                        {

                            GameHelpers.SpaceandClean();


                            Console.WriteLine("You may never grow strong enough to Wield the {0} Power", powername[3]);
                            break;
                        }
                        # endregion

                        #region Adventure Choice Two
                        // Adventure Choice Two

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 2)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;



                                PsychicArcana.blueStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                PsychicArcana.saymypower(3, managoal);
                           

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the {0} Power", powername[3]);
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Three
                        // Adventure Choice Three


                        GameHelpers.SpaceandClean();


                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 3)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;



                                GameHelpers.SpaceandClean();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.WriteLine(" You have grown in {0} power. \n  ", powername[3]);
                                Console.WriteLine(" You have Grown in the power of {0}, mana!", mycolor[3]);
                                Console.WriteLine(" Mana Collected: {0}", managoal);
                           

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the {0} Power", powername[3]);
                                break;
                            }
                        }
                        # endregion




                        #region Adventure Choice Four
                        // Adventure Choice Four

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 4)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.blueStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.WriteLine(" You have grown in {0} power. \n  ", powername[3]);
                                Console.WriteLine(" You have Grown in the power of {0}, mana!", mycolor[3]);
                                Console.WriteLine(" Mana Collected: {0}", managoal);
                           

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the {0} Power", powername[3]);
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Five
                        // Adventure Choice Five

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 5)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.blueStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.WriteLine(" You have grown in {0} power. \n  ", powername[3]);
                                Console.WriteLine(" You have Grown in the power of {0}, mana!", mycolor[3]);
                                Console.WriteLine(" Mana Collected: {0}", managoal);
                           

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the {0} Power", powername[3]);
                                break;
                            }
                        }
                        # endregion






                        #region Adventure Choice Six
                        // Adventure Choice Six

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 6)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;



                                PsychicArcana.blueStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.WriteLine(" You have grown in {0} power. \n  ", powername[3]);
                                Console.WriteLine(" You have Grown in the power of {0}, mana!", mycolor[3]);
                                Console.WriteLine(" Mana Collected: {0}", managoal);
                           

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the {0} Power", powername[3]);
                                break;
                            }
                        }
                        # endregion

                        #region Adventure Choice Seven
                        // Adventure Choice Seven

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 7)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.blueStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.WriteLine(" You have grown in {0} power. \n  ", powername[3]);
                                Console.WriteLine(" You have Grown in the power of {0}, mana!", mycolor[3]);
                                Console.WriteLine(" Mana Collected: {0}", managoal);
                           

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the {0} Power", powername[3]);
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Eight
                        // Adventure Choice Eight

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 8)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.blueStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.WriteLine(" You have grown in {0} power. \n  ", powername[3]);
                                Console.WriteLine(" You have Grown in the power of {0}, mana!", mycolor[3]);
                                Console.WriteLine(" Mana Collected: {0}", managoal);
                           

                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the {0} Power", powername[3]);
                                break;
                            }
                        }
                        # endregion




                        #region Adventure Choice Nine
                        // Adventure Choice Nine

                        GameHelpers.SpaceandClean();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");

                        if (managoal == 9)
                        {
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                managoal++;


                                PsychicArcana.blueColorStart();

                                Console.WriteLine();
                                Console.WriteLine(" {0} You have found the sacred heart of the {1} the Mox Sapphire. \n", name, mymananame[3]);
                   
                                Console.Write(" You have grown in Trickerys' Power  ");
                                Console.WriteLine(managoal);
                                
                                Console.ReadKey();


                            }
                            else
                            {

                                GameHelpers.SpaceandClean();
                                Console.WriteLine("You may never grow strong enough to Wield the {0} Power", powername[3]);
                                break;
                            }
                        }
                        # endregion



                        #region Adventure Choice Ten
                        // Adventure Choice Ten
                        if (managoal == 10)
                        {
                            GameHelpers.SpaceandClean();
                            Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");


                            mycode = myYesNo();

                            if (mycode == "YES")
                            {




                                PsychicArcana.blueColorStart();
                                Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);




                                Console.WriteLine(" You have grown in {0} power. \n  ", powername[3]);
                                Console.WriteLine(" You have Grown in the power of {0}, mana!", mycolor[3]);
                                Console.WriteLine(" Mana Collected: {0}", managoal);
                           

                                Console.ReadKey();
                            }
                            break;


                        }
                        else
                        {

                            GameHelpers.SpaceandClean();
                            Console.WriteLine("You may never grow strong enough to Wield the {0} Power", powername[3]);
                            break;
                        }





                        # endregion

                    #endregion



                    #region Swamp Region
                    case "SWAMPS":
                        
                        GameHelpers.RefreshConsole();
                        BlackMana.myBlackMana();
                        Console.WriteLine(" ");
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(welcometo + " Swamps ");
                        Console.WriteLine(thepowerof[0][0] + mycolor[4] + manasent);             
                    
#region Adventure Choice One
                        // Adventure Choice One

                        GameHelpers.SpaceandClean();
                        Console.WriteLine(" In the swamp you see a bat do you kill it with your magic yes or no?");


                        mycode = myYesNo();
                        if (mycode == "YES")
                        {
                            //managoal++;
                            managoal  = 2;


                            PsychicArcana.blackStart();
                            Console.WriteLine("{0},  As try to focus the forces of mana through, you start to sweat. ", name);
                            Console.WriteLine("");
                            Console.WriteLine(" The force is felt through you as you tense and point your finger at the bat.");
                            Console.WriteLine("");
                            Console.WriteLine(" You feel an exchange in life between you and the bat as it falls to the swamp floor with a thud.");



                            Console.Write(" You have grown in Dark Power  ");
                            Console.WriteLine(managoal);

                            Console.ReadKey();
                            
                        }
                        else
                        {
                            
                            GameHelpers.SpaceandClean();
                            Console.WriteLine(" You may never grow strong enough to Wield the Dark Power");
                            break;
                        }
# endregion


#region  Adventure Choice Two
                        // Adventure Choice Two
                        GameHelpers.SpaceandClean();


                        if (managoal == 2)

           if (managoal == 2)
                        {
                           
                            PsychicArcana.blackStart();
                            Console.WriteLine(" {0} As you go deeper in the swamp you see a person deeply garbed in ashen robes, with a spindly hand asking for directions. ", name);
                            Console.WriteLine();
                            Console.WriteLine(" You know the way out of the swamp do you tell them the way?");
                            mycode = myYesNo();
                            if (mycode == "NO")
                            {
                                GameHelpers.SpaceandClean();

                                managoal++;
                               

                              
                                BlackMana.BlackManaCount(name, managoal);
                            }
                            else
                            {
                                GameHelpers.SpaceandClean();

                                Console.WriteLine(" The Force of Dark Power is still out of your Grasp. ");
                                break;
                            }
                        }
#endregion


#region Adventure Choice Three
                        // Adventure Choice Three
                        GameHelpers.SpaceandClean();


                        if (managoal == 3)
                        {
                            PsychicArcana.blackStart();
                            Console.WriteLine(" {0} On the path of this winding road within the swamp you see in the distance a dimly lit cave. ", name);
                            Console.WriteLine();
                            Console.WriteLine(" Do you enter? ");
                            Console.WriteLine();
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                GameHelpers.SpaceandClean();


                                    Console.WriteLine(" The old spindly man you met earlier sits at a roll top desk. \n");
                                   
                                    Console.WriteLine(" He looks up at you and laughs. \n");
                                  
                                    Console.WriteLine(" The cave smells of sulphur are abound and large tombs of arcane lore abound. \n ");
                                    Console.WriteLine("Would you like to study with me you want to study with me he asks? \n");
                                    
                                    mycode = myYesNo();
                                    if (mycode == "YES") {


                                        GameHelpers.SpaceandClean();
                                        Console.WriteLine(" You study with the Dark Tutor for a year. \n ");
                                      
                                        Console.WriteLine(" In this time you learn this is not just a man but some sort of spirit. \n");
                                       
                                        Console.WriteLine(" You are ready to continue down the path to the heart of the swamp, as an adept crackling with mana." + " Mana Force: {0}  \n", managoal);
 
                                        managoal++;
                                        BlackMana.BlackManaCount(name, managoal);
                                    
                                    }  else  {

                                        GameHelpers.SpaceandClean();
                                        Console.WriteLine(" You leave the cave and the swamp crackling with black mana " + " Mana Force: {0}  \n", managoal);
                                        break;
                                }                          
                            }
                        }
                        else
                        {
                            GameHelpers.SpaceandClean();
                            Console.WriteLine(" One Day you may be a master, Adept.");
                            Console.WriteLine(" Your Mana Force is : " + managoal);
                            break;
                        }
# endregion

#region Adventure Choice Four
                        // Adventure Choice Four
                        GameHelpers.SpaceandClean();
                        
                        if (managoal == 4)
                        {
                            PsychicArcana.blackStart();
                            Console.WriteLine();
                            Console.WriteLine(" You feel the black mana growing as you find your way deeper into the swamps maze.");
                            Console.WriteLine();
                            Console.WriteLine(" Your vision blurries as the mana creeps into your soul.");
                            Console.WriteLine();
                            Console.WriteLine(" In your blurried vision you see a fiend self producing itself from the swamps mana");
                            Console.WriteLine();
                            Console.WriteLine(" Do you engage this foe with the magic might you have fought so hard to procur?");
                            mycode = myYesNo();
                            
                            if(mycode == "YES"){
                                GameHelpers.SpaceandClean();

                                Console.WriteLine(" You Engage this swamp fiend, and at first your mind is in terror, even as your power has grown");
                                Console.WriteLine();
                                Console.WriteLine(" The mana flows through you and you regain your composure.");
                                Console.WriteLine();
                                Console.WriteLine(" The beast that terrified you now also knows fear.");
                                Console.WriteLine();

                               // Attack Choice
                                Console.WriteLine(" How will you attack please input 1, 2, or 3");
                                Console.WriteLine("Choice 1 Howl from beyond");
                                Console.WriteLine("Choice 2 Drain Life");
                                Console.WriteLine("Choice 3 Syphon Soul");



                                Int32 attackchoice;
                                
                                // convert string to int
                               mychoice = Console.ReadLine();
                                
                              attackchoice = Convert.ToInt32(mychoice);
                              if (attackchoice <= 3 && attackchoice > 0)
                              {
                                  if (attackchoice == 1)
                                  {
                                      GameHelpers.SpaceandClean();
                                      Art.HowlFromBeyond();

                                      Console.WriteLine();
                                          Console.WriteLine(" You Howl at the moon ");
                                          Console.WriteLine("");
                                          Console.WriteLine(" As you howl you become the moon beast ");
                                          Console.WriteLine("");
                                      Console.WriteLine(" The being has stirred in your heart for quite sometime. ");
                                      Console.WriteLine("");
                                      Console.WriteLine(" The fiend comes upon you but you smile as you rend and tear in to the fiend ");
                                          Console.WriteLine(" What is left of the fiend is blood and gristle ");
                                          Console.WriteLine("");
                                      Console.WriteLine(" You smile your deadly smile as you transform again from wolf to man. ");
                                      Console.WriteLine("");
                                  
                                  } else if( attackchoice == 2)
                                  {
                                      GameHelpers.SpaceandClean();
                                      Art.DrainLife();


                                      Console.WriteLine(" Killing the bat comes back to you ");
                                      Console.WriteLine("");
                                      Console.WriteLine(" The spirit of the bat flutters in your mind ");
                                      Console.WriteLine("");
                                      Console.WriteLine(" The icon and reality of the small spell larger ");
                                      Console.WriteLine("");
                                      Console.WriteLine(" As you delve into the deep of the minds spell ");
                                      Console.WriteLine("");
                                      Console.WriteLine(" You feel the swamp fiend crushed underneath your magic ");



                                      
                                         
                                  } else if(attackchoice == 3)
                                  {

                                      GameHelpers.SpaceandClean();

                                      Art.SyphonSoul();
                                      Thread.Sleep(1000);

                                      Console.WriteLine(" Syphon Soul seemed to do something against this ghastly field ");
                                      Console.WriteLine("");
                                          Console.WriteLine(" Under the bad moon the fiend simply seemed to get more angry as it grinned ");
                                          Console.WriteLine("");
                                          Console.WriteLine(" Death comes upon you in this swamps maze ");
                                          BlackMana.myBlackManaAnimation();
                                          myexit();
                                   }
                              }
                              else
                              {
                                  GameHelpers.SpaceandClean();

                                  Console.WriteLine(" The swamp fiend has defeated you ");
                                  Console.ReadKey();
                                  BlackMana.myBlackManaAnimation();
                                  myexit();
                              }



                                BlackMana.myBlackMana();
                                managoal++;
                                BlackMana.BlackManaCount(name, managoal);
                                Console.ReadKey();
                            }
                            else
                            {
                                GameHelpers.SpaceandClean();

                                Console.WriteLine(" You will spend all of your years in the swamp, Adept. ");
                                Console.WriteLine(" Your Mana Force is : " + managoal);
                                break;
                            }                           
                        }
                        else
                        {
                            GameHelpers.SpaceandClean();

                            Console.WriteLine(" One Day you may be a master, Adept. ");
                            Console.WriteLine(" Your Mana Force is : " + managoal);
                            break;
                        }
#endregion


#region  Adventure Choice Five
                        // Adventure Choice Five
                        Console.Clear();


                        if (managoal == 5)
                        {

                            PsychicArcana.blackStart();
                            managoal++;
                           
                            Console.WriteLine(" You take the cloak from the swamp fiend \n");
                            Console.WriteLine(" You then adorn yourself with this cloak \n");
                            Console.WriteLine(" You feel the manarush through you becoming you \n");
                            Console.WriteLine(" Once again you move in rank and form \n");
                            Console.WriteLine(" No Longer an Adept you become a Master \n");

                          
                            BlackMana.BlackManaCount(name, managoal);

                            Console.ReadKey();

                        }
                        else
                        {
                            GameHelpers.SpaceandClean();

                            Console.WriteLine(" The seed of black mana has been planted in your heart, " + status[3]);
                            Console.WriteLine(" Your Mana Force is : " + managoal);
                            break;
                        }

#endregion


#region Adventure Choice Six
                        GameHelpers.SpaceandClean();
                    
                    // Adventure Choice Six
                        if (managoal == 6)
                        {
                            // convert string to int
                          

                           


                            do
                            {
                                PsychicArcana.blackStart();

                            Console.WriteLine(" {0} As you find yourself ever deeper into the depths of the swamps and marshes \n ", name);
                            Console.WriteLine(" You see a being that resembles yourself  \n ");
                            Console.WriteLine(" Your body seems to move against its will  \n ");
                            Console.WriteLine(" You sit across from a being that seems to have had its eyes forcefully removed  \n ");
                            Console.WriteLine(" Its speech is in echoes  \n ");
                            Console.WriteLine(" What is the primary virtue of the black hand path  \n ");


                            Console.WriteLine(" How will you answer the question please input 1, 2, or 3");
                            Console.WriteLine("Choice 1: Peace");
                            Console.WriteLine("Choice 2: Sin");
                            Console.WriteLine("Choice 3: Power");



                           
                           
                           
                                
                                
                            mychoice = Console.ReadLine();

                            answerchoice = Convert.ToInt32(mychoice);
                           
                                if (answerchoice < 4 && answerchoice > 0)
                                {
                                    if (answerchoice == 1)
                                    {
                                        Console.Clear();

                                        Console.WriteLine(" Peace is an admirable answer \n");

                                        Console.WriteLine(" Even peace is achievable via the path \n");

                                        Console.WriteLine(" As you may soon see \n");

                                        Console.ReadKey();


                                    }
                                    else if (answerchoice == 2)
                                    {
                                        Console.Clear();

                                        Console.WriteLine(" Sin is a foolish response \n");
                                        Console.WriteLine(" The swamp alit with willow of the wisps \n");
                                        Console.WriteLine(" Sin is missing the mark \n");
                                        Console.WriteLine(" Missing the mark is never what we should do, though we may \n");
                                        Console.WriteLine(" I will let you live this time \n");
                                        Console.ReadKey();


                                    }
                                    else if (answerchoice == 3)
                                    {

                                        Console.Clear();


                                        Console.WriteLine(" Power is the answer \n");
                                        Console.WriteLine(" Though you will want to contemplate both the question and answer in the future \n");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.Clear();

                                    Console.WriteLine("You are a wiley" + status[3]);
                                    Console.ReadKey();
                                    BlackMana.myBlackManaAnimation();
                                    myexit();
                                }

                            } while (answerchoice != 3);



                            BlackMana.myBlackMana();
                            managoal++;



                            Console.Write(" You have grown in Dark Power  ");
                            Console.WriteLine(managoal);

                            Console.ReadKey();
                          
                        }
                        else
                        {
                            GameHelpers.SpaceandClean();

                            Console.WriteLine(" The seed of black mana has been planted in your heart, Adept");
                            Console.WriteLine(" Your Mana Force is : " + managoal);
                            break;   
                        }

#endregion


#region Adventure Choice Seven
                        GameHelpers.SpaceandClean();
                    
                    // Adventure Choice Seven

                        if (managoal == 7)
                        {
                            PsychicArcana.blackStart();
                           
                            Console.WriteLine(" The being in front of you fades into a floating ball of undulating light  \n");
                            Console.WriteLine(" This ball of light this swamp spirit floats off into the swamp glittering this way or that  \n");
                            Console.WriteLine(" You see this might be a nice place to relax for a while and contemplate that question  \n");

                            //


                            Console.WriteLine("Would you like to study with me you want to study with me he asks? ");
// this is where i am working
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                GameHelpers.SpaceandClean();

                               
                               
                                 #region forloop
                                int questioncounter = 0;
                                Console.WriteLine("Would you like to study a year? \n");
                                mycode = myYesNo();
                                for (int x = 0; x <= 3; x++)
                                {
                                    //questioncounter++;
                                    //Console.WriteLine("Would you like to study a year? \n");
                                    //mycode = myYesNo();
                                    //if (mycode == "YES")
                                    //{
                                       
                                        if (mycode == "YES") {
                                            Console.WriteLine("Would you like to study a year? \n");
                                            mycode = myYesNo();
                                            GameHelpers.SpaceandClean();
                                            questioncounter++;
                                            Console.WriteLine("You have studied {0} years \n", questioncounter);
                                            
                                        if (questioncounter == 3)
                                        {
                                            Console.WriteLine(" After Ten Years of Study you have attained the answer you have sought");
                                            managoal++;
                                            break;
                                        }
                                        } else if(mycode == "NO") {

                                        Console.WriteLine(" Though you may be a " + status[3] + "You still have yet to understand the teachings of BlackMana ");
                                        BlackMana.myBlackManaAnimation();
                                        myexit();
                                    }

                                }
                                }
                                  
                            
#endregion
                          
                            
                        }




#endregion


#region Adventure Choice Eight
                        GameHelpers.SpaceandClean();
                    
                    // Adventure Choice Eight


                        if (managoal == 8)
                        {





                            PsychicArcana.blackStart();


                            Console.WriteLine(" You see now with new eyes of mastery \n");
                            Console.WriteLine(" As you peer into the maze where you have sat in life and in study ");
                            Console.WriteLine(" You see a path that would lead you back to the world from whence you came. ");

                            Console.WriteLine(" Do you want to end your quest or push on further 1, 2 ");
                            Console.WriteLine(" Choice 1: Leave the swamp ");
                            Console.WriteLine(" Choice 2: Press deeper into the dark ");
                            








                            mychoice = Console.ReadLine();

                            answerchoice = Convert.ToInt32(mychoice);

                            if (answerchoice < 3 && answerchoice > 0)
                            {
                                if (answerchoice == 1)
                                {
                                    GameHelpers.SpaceandClean();

                                    Console.WriteLine(" You leave the swamp a victor \n");
                                    Console.WriteLine(" And a {0} of {1} Magic! \n", status[3], mycolor[4]);
                                    Console.ReadKey();
                                    myexit();

                                }
                                else if (answerchoice == 2)
                                {
                                   GameHelpers.SpaceandClean();

                                    Console.WriteLine(" You push further into the dark \n");
                                    Console.WriteLine(" You find yourself changing in marked ways \n");
                                    Console.WriteLine(" Only you know the way the dark has kissed your soul \n");
                                    Console.ReadKey();
                                    
                                    BlackMana.myBlackMana();
                                    managoal++;



                                    Console.Write(" You have grown in Dark Power  ");
                                    Console.WriteLine(managoal);


                                }
                             
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine(" You are a wiley " + status[3]);
                                Console.ReadKey();
                                BlackMana.myBlackManaAnimation();
                                myexit();
                            }

                            
                            Console.ReadKey();
                           
                        }
                        else
                        {
                            GameHelpers.SpaceandClean();

                            Console.WriteLine(" The seed of black mana has been planted in your heart, " + status[3]);
                            Console.WriteLine(" Your Mana Force is : " + managoal);
                            break;
                        }

#endregion


#region Adventure Choice Nine
                        GameHelpers.SpaceandClean();
                    
                    // Adventure Choice Nine

                        if (managoal == 9)
                        {
                            PsychicArcana.blackColorStart();

                            Console.WriteLine();
                            Console.WriteLine(" {0} You have found the sacred heart of the swamp the mox jet. ", name);
                            Console.WriteLine();
                            managoal++;
                            Console.ReadKey();
                           
                        }
                        else
                        {
                            GameHelpers.SpaceandClean();

                            Console.WriteLine(" The seed of black mana has been planted in your heart, " + status[3]);
                            Console.WriteLine(" Your Mana Force is : " + managoal);
                            break;
                        }
#endregion



#region Adventure Choice Ten
                        GameHelpers.SpaceandClean();
                    
                    // Adventure Choice Ten
                            if (managoal == 10)
                            {
                                PsychicArcana.blackColorStart();
                                for (int victory = 0; victory < 10; victory++)
                                {
                                    BlackMana.myBlackMana();
                                    GameHelpers.RefreshConsole();
                                    BlackMana.myBlackManaColor();
                                    GameHelpers.RefreshConsole();
                                    
                                }
                                    Console.WriteLine(" " + name + " are now the " + status[4] + " of Black Mana");
                                break;
                            }
                            else
                            {
                                GameHelpers.SpaceandClean();
                                
                                Console.WriteLine(" The Force of Dark Power is still out of your Grasp.");
                                break;
                            }
                           default:
                            GameHelpers.SpaceandClean();

                                Console.WriteLine(" I did not hear you correctly. Where did you want to go? ");
                                break;
                        }             
                Console.ReadKey();
#endregion // choice ten


                    #endregion // swamp decision tree





            }
                // End Game Loop
            GameHelpers.RefreshConsole();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            #endregion
        
        }
        }
    }