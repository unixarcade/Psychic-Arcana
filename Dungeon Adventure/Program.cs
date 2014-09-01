using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;

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
            Console.WriteLine(" Yes or No? ");

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

            return yn;
        }
# endregion



        //static int mymanagoal(int managoal)
        //{

        //   int  counter = managoal;

        //   return counter;
        //}
        static void Main(string[] args)
        {
           
#region Vars
            string name, adventure;
            int managoal = 0;

#endregion
          
            

            //BlackMana.myBlackMana();


            // Game Start Up

            GameHelpers.RefreshConsole();

         //   Mana.myBlueColorMana();

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
                Console.WriteLine(" Do you want to go to the Forests, Mountains, Plains, Islands, Swamps? ");
                adventure = Console.ReadLine();
                adventure = adventure.ToUpper();

                string welcometo = " Welcome to the ";

                string[][] thepowerof = new string[][]{
                            new string[]{" The Power of "},
                            new string[]{" Green ", " Red ", " White ", " Blue ", " Black "},
                            new string[]{" mana infuses you. "}             
                                                      };

                string manasent = " mana infuses you. ";
                string[] mycolor = { " Green ", "Red", "White", "Blue", " Black " };
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

                        break;
                    #endregion



                    #region Mountain Region
                    case "MOUNTAINS":
                        Mana.myRedMana();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(welcometo + " Mountains");
                        Console.WriteLine(thepowerof[0][0] + mycolor[1] + manasent);


                        break;
                    #endregion 



                    #region Plains Region
                    case "PLAINS":
                        Mana.myWhiteMana();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(welcometo + " Plains ");

                        Console.WriteLine(thepowerof[0][0] + mycolor[2] + manasent);


                        break;
                    #endregion



                    #region Island Region
                    case "ISLANDS":
                        Mana.myBlueMana();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(welcometo + " Islands ");
                        Console.WriteLine(thepowerof[0][0] + mycolor[3] + manasent);

                        break;

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
                        
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");


                        mycode = myYesNo();
                        if (mycode == "YES")
                        {
                            //managoal++;
                            managoal  = 2;



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
                            Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                            break;
                        }
# endregion


#region  Adventure Choice Two
                        // Adventure Choice Two
                        Console.Clear();


                        if (managoal == 2)

           if (managoal == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(name + " As you go deeper in the swamp you see a person deeply garbed in ashen robes, with a spindly hand asking for directions.");
                            Console.WriteLine();
                            Console.WriteLine("You know the way out of the swamp do you tell them the way?");
                            mycode = myYesNo();
                            if (mycode == "NO")
                            {
                                
                                managoal++;
                                Console.Write(" You have grown in Dark Power " + " Mana Force: " + managoal);
                               
                            }
                            else
                            {
                                Console.WriteLine(" The Force of Dark Power is still out of your Grasp.");
                                break;
                            }
                        }
#endregion


#region Adventure Choice Three
                        // Adventure Choice Three
                        Console.Clear();


                        if (managoal == 3)
                        {
                            Console.Clear();
                            Console.WriteLine(name + " On the path of this winding road within the swamp you see in the distance a dimly lit cave. ");
                            Console.WriteLine();
                            Console.WriteLine("Do you enter");
                            Console.WriteLine();
                            mycode = myYesNo();
                            if (mycode == "YES")
                            {
                                Console.Clear();


                                    Console.WriteLine(" The old spindly man you met earlier sits at a roll top desk. ");
                                    Console.WriteLine("");
                                    Console.WriteLine(" He looks up at you and laughs.");
                                    Console.WriteLine("");
                                    Console.WriteLine("The cave smells of sulphur are abound and large tombs of arcane lore abound");
                                    Console.WriteLine("Would you like to study with me you want to study with me he asks? ");
                                    
                                    mycode = myYesNo();
                                    if (mycode == "YES") {


                                        Console.Clear();
                                        Console.WriteLine(" You study with the Dark Tutor for a year ");
                                        Console.WriteLine();
                                        Console.WriteLine(" In this time you learn this is not just a man but some sort of spirit");
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" You are ready to continue down the path to the heart of the swamp, as an adept crackling with mana." + " Mana Force: " + managoal);
 
                                        managoal++;
                                    
                                    }  else  {

                                        Console.Clear();
                                    Console.WriteLine(" You leave the cave and the swamp crackling with black mana " + " Mana Force: ");
                                        break;
                                }                          
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(" One Day you may be a master, Adept.");
                            Console.WriteLine(" Your Mana Force is : " + managoal);
                            break;
                        }
# endregion

#region Adventure Choice Four
                        // Adventure Choice Four
                        Console.Clear();
                        
                        if (managoal == 4)
                        {
                            Console.Clear();
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
                                Console.Clear();

                                Console.WriteLine(" You Engage this swamp fiend, and at first your mind is in terror, even as your power has grown");
                                Console.WriteLine();
                                Console.WriteLine(" The mana flows through you and you regain your composure.");
                                Console.WriteLine();
                                Console.WriteLine(" The beast that terrified you now also knows fear.");
                                Console.WriteLine();

                               // Attack Choice
                                Console.WriteLine(" How will you attack please input 1, 2, or 3");
                                Console.WriteLine("Choice 1 is a howl from beyond");
                                Console.WriteLine("Choice 2 Drain Life");
                                Console.WriteLine("Choice 3 Syphon Soul");



                                Int32 attackchoice;
                                string mychoice;
                                // convert string to int
                               mychoice = Console.ReadLine();
                                
                              attackchoice = Convert.ToInt32(mychoice);
                              if (attackchoice <= 3 && attackchoice > 0)
                              {
                                  if (attackchoice == 1)
                                  {
                                      Console.Clear();
                                      
                                          Console.WriteLine("You Howl at the moon");
                                          Console.WriteLine("");
                                          Console.WriteLine("As you howl you become the moon beast");
                                          Console.WriteLine("");
                                      Console.WriteLine("The being has stirred in your heart for quite sometime.");
                                      Console.WriteLine("");
                                      Console.WriteLine("The fiend comes upon you but you smile as you rend and tear in to the fiend");
                                          Console.WriteLine("What is left of the fiend is blood and gristle");
                                          Console.WriteLine("");
                                      Console.WriteLine("You smile your deadly smile as you transform again from wolf to man.");
                                      Console.WriteLine("");
                                  
                                  } else if( attackchoice == 2)
                                  {
                                      Console.Clear();

                                      Console.WriteLine("Killing the bat comes back to you");
                                      Console.WriteLine("");
                                      Console.WriteLine("The spirit of the bat flutters in your mind");
                                      Console.WriteLine("");
                                      Console.WriteLine("The icon and reality of the small spell larger");
                                      Console.WriteLine("");
                                      Console.WriteLine("As you delve into the deep of the minds spell");
                                      Console.WriteLine("");
                                      Console.WriteLine("You feel the swamp fiend crushed underneath your magic");



                                      
                                         
                                  } else if(attackchoice == 3)
                                  {

                                      Console.Clear();


                                      Console.WriteLine("Syphon Soul seemed to do something against this ghastly field");
                                      Console.WriteLine("");
                                          Console.WriteLine("Under the bad moon the fiend simply seemed to get more angry as it grinned");
                                          Console.WriteLine("");
                                          Console.WriteLine("Death comes upon you in this swamps maze");
                                          BlackMana.myBlackManaAnimation();
                                          myexit();
                                   }
                              }
                              else
                              {
                                  Console.Clear();

                                  Console.WriteLine("The swamp fiend has defeated you");
                                  Console.ReadKey();
                                  BlackMana.myBlackManaAnimation();
                                  myexit();
                              }



                                BlackMana.myBlackMana();
                                managoal++;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine(" You will spend all of your years in the swamp, Adept.");
                                Console.WriteLine(" Your Mana Force is : " + managoal);
                                break;
                            }                           
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine(" One Day you may be a master, Adept.");
                            Console.WriteLine(" Your Mana Force is : " + managoal);
                            break;
                        }
#endregion


#region  Adventure Choice Five
                        // Adventure Choice Five
                        Console.Clear();


                        if (managoal == 5)
                        {
                            Console.Clear();

                            BlackMana.myBlackMana();
                            managoal++;
                           


                            Console.Write(" You have grown in Dark Power  ");
                            Console.WriteLine(managoal);

                            Console.ReadKey();

                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("The seed of black mana has been planted in your heart, Adept");
                            Console.WriteLine("Your Mana Force is : " + managoal);
                            break;
                        }

#endregion


#region Adventure Choice Six
                        Console.Clear();
                    
                    // Adventure Choice Six
                        if (managoal == 6)
                        {
                            BlackMana.myBlackMana();
                            managoal++;



                            Console.Write(" You have grown in Dark Power  ");
                            Console.WriteLine(managoal);

                            Console.ReadKey();
                          
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("The seed of black mana has been planted in your heart, Adept");
                            Console.WriteLine("Your Mana Force is : " + managoal);
                            break;   
                        }

#endregion


#region Adventure Choice Seven
                        Console.Clear();
                    
                    // Adventure Choice Seven

                        if (managoal == 7)
                        {
                            Console.Clear();
                            BlackMana.myBlackMana();
                            managoal++;



                            Console.Write(" You have grown in Dark Power  ");
                            Console.WriteLine(managoal);

                            Console.ReadKey();
                           
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The seed of black mana has been planted in your heart, Adept");
                            Console.WriteLine("Your Mana Force is : " + managoal);
                            break;
                        }

#endregion


#region Adventure Choice Eight
                        Console.Clear();
                    
                    // Adventure Choice Eight


                        if (managoal == 8)
                        {
                            BlackMana.myBlackMana();
                            managoal++;



                            Console.Write(" You have grown in Dark Power  ");
                            Console.WriteLine(managoal);

                            Console.ReadKey();
                           
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("The seed of black mana has been planted in your heart, Adept");
                            Console.WriteLine("Your Mana Force is : " + managoal);
                            break;
                        }

#endregion


#region Adventure Choice Nine
                        Console.Clear();
                    
                    // Adventure Choice Nine

                        if (managoal == 9)
                        {
                            BlackMana.myBlackMana();





                           
                            Console.WriteLine();
                            Console.WriteLine("   " + name + " " +"You have found the sacred heart of the swamp the mox jet. ");
                            Console.WriteLine();
                            managoal++;
                            Console.ReadKey();
                           
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("The seed of black mana has been planted in your heart, Adept");
                            Console.WriteLine("Your Mana Force is : " + managoal);
                            break;
                        }
#endregion



#region Adventure Choice Ten
                        Console.Clear();
                    
                    // Adventure Choice Ten
                            if (managoal == 10)
                            {
                                Console.WriteLine("You are now the avatar of Black Mana");
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                
                                Console.WriteLine(" The Force of Dark Power is still out of your Grasp.");
                                break;
                            }
                           default:
                                Console.Clear();
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