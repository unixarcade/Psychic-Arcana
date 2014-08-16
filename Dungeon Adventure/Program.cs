using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
// Luminosity
// http://luminosity.livejournal.com


namespace Dungeon_Adventure
{


    class Program
    {

        static void myexit()
        {
            Environment.Exit(0);
        }

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

        //static int mymanagoal(int managoal)
        //{

        //   int  counter = managoal;

        //   return counter;
        //}
        static void Main(string[] args)
        {
            // Form Source Code

            // new myform();
            // This Code Should really be in a Class
            //public static myform
            // {
            // Form f = new Form();

            // f.Text = "  Empty Dungeon Adventure  ";
            // f.Name = "Empty Dungeon Adventure";
            // Label nameLabel = new Label();
            // nameLabel.AutoSize = true;
            // nameLabel.Text = "Empty Dungeon Adventure";
            // nameLabel.Top = 100;
            // nameLabel.Left = 80;
            // f.Controls.Add(nameLabel);
            // f.ShowDialog();

            // }



            // End of Form Code




            string name, adventure;
            int managoal = 0;




            BlackMana.myBlackMana();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.Title = " Mindscape Dungeon Adventure ";
            Console.WriteLine(" Welcome Adventurer ");
            Console.WriteLine(" What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine(" Would you like to go on an adventure " + name);

            string mycode;
            mycode = myYesNo();

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
                    case "FORESTS":
                        // colorint = 0;
                        Mana.myGreenMana();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(welcometo + " Forests ");
                        Console.WriteLine(thepowerof[0][0] + mycolor[0] + manasent);

                        break;

                    case "MOUNTAINS":
                        Mana.myRedMana();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(welcometo + " Mountains");
                        Console.WriteLine(thepowerof[0][0] + mycolor[1] + manasent);


                        break;
                    case "PLAINS":
                        Mana.myWhiteMana();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(welcometo + " Plains ");

                        Console.WriteLine(thepowerof[0][0] + mycolor[2] + manasent);


                        break;
                    case "ISLANDS":
                        Mana.myBlueMana();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(welcometo + " Islands ");
                        Console.WriteLine(thepowerof[0][0] + mycolor[3] + manasent);

                        break;

                    case "SWAMPS":
                        Console.Clear();
                        BlackMana.myBlackMana();
                        Console.WriteLine(" ");
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(welcometo + " Swamps ");
                        Console.WriteLine(thepowerof[0][0] + mycolor[4] + manasent);             
                    
                        // Adventure Choice One
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");


                        mycode = myYesNo();
                        if (mycode == "YES")
                        {
                            //managoal++;
                            managoal  = 2;
                            Console.Write(" You have grown in Dark Power  ");
                            Console.WriteLine(managoal);
                            
                        }
                        else
                        {
                            Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                            break;
                        }

                        // Adventure Choice Two

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

                        // Adventure Choice Three
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
                                    Console.WriteLine(" You leave the cave and the swamp crackling with black mana " + " Mana Force: ");
                                        break;
                                }                          
                            }
                        }
                        else
                        {
                            Console.WriteLine(" One Day you may be a master, Adept.");
                            Console.WriteLine(" Your Mana Force is : " + managoal);
                            break;
                        }

                        // Adventure Choice Four



                            if (managoal == 10)
                            {
                                Console.WriteLine("You are now the avatar of Black Mana");
                                break;
                            }
                            else
                            {
                                Console.WriteLine(" The Force of Dark Power is still out of your Grasp.");
                                break;
                            }
                           default:
                                Console.WriteLine(" I did not hear you correctly. Where did you want to go? ");
                                break;
                        }             
                Console.ReadKey();
                }
            }
        }
    }