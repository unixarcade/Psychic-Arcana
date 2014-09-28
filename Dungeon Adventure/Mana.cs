using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//luminosity
// http://luminosity.livejournal.com



    public static class Mana
    {


        public static void consolePaint()
        {

            ConsoleColor printblack = ConsoleColor.Black;
            ConsoleColor printwhite = ConsoleColor.White;
            ConsoleColor printdarkgrey = ConsoleColor.DarkGray;
            ConsoleColor printlightgrey = ConsoleColor.Gray;
            ConsoleColor printdarkblue = ConsoleColor.DarkBlue;
            ConsoleColor printlightblue = ConsoleColor.Blue;

        }


        #region myBlueMana
        public static void myBlueMana()
        {
Console.WriteLine("                 ..:::a:::::..           ");    // line one
Console.WriteLine("            ..:::::::d8::::::::::..      ");        // line two
Console.WriteLine("         .::::::::::d88b:::::::::::::.   ");       // line three
Console.WriteLine("       .:::::::::::d8888:::::::::::::::.  ");     // line four
Console.WriteLine("     .::::::::::::d88888b::::::::::::::::.  ");  // line five
Console.WriteLine("    :::::::::::::d8888888::::::::::::::::::  ");        // line six
Console.WriteLine("   ::::::::::::d888888888b::::::::::::::::::  ");      // line seven
Console.WriteLine("  ::::::::::::d88888888888b::::::::::::::::::  ");    // line eight
Console.WriteLine(" .:::::::::::d88888888888888b::::::::::::::::.  ");  // line nine
Console.WriteLine(" :::::::::::d888888888888888888a::::::::::::::   ");  // line ten
Console.WriteLine(" ::::::::::d888888888888888b:Y88b:::::::::::::  ");  // line eleven
Console.WriteLine(" :::::::::d88888888888888888b:888b::::::::::::   ");  // line twelve
Console.WriteLine(" `::::::::8888888888888888888:Y888b::::::::::'  ");  // line thirteen   
Console.WriteLine("  ::::::::8888888888888888888::Y888::::::::::   ");  // line fourteen
Console.WriteLine("   :::::::Y888888888888888888?:d88P:::::::::   "); // line fifteen
Console.WriteLine("    :::::::Y88888888888888888bd88P:::::::::   "); // line sixteen
Console.WriteLine("     `:::::::Y88888888888888888P:::::::::'   "); // line seventeen
Console.WriteLine("       `::::::Y88888888888888P:::::::::'   ");  // line eighteen
Console.WriteLine("         `::::::Y8888888888P:::::::::'    ");  // line nineteen
Console.WriteLine("            ``::::::Y888P::::::::''      "); // line twenty
Console.WriteLine("                ``:::::::::''           ");  // line twentyone
        }

#endregion

        #region myBlueColorMana
        public static void myBlueColorMana()
        {


            ConsoleColor printblack = ConsoleColor.Black;
            ConsoleColor printwhite = ConsoleColor.White;
            ConsoleColor printdarkgrey = ConsoleColor.DarkGray;
            ConsoleColor printlightgrey = ConsoleColor.Gray;
            ConsoleColor printdarkblue = ConsoleColor.DarkBlue;
            ConsoleColor printlightblue = ConsoleColor.Blue;





            // line one
            Console.ForegroundColor = printblack;
            Console.Write("                 ");
            Console.ForegroundColor = printwhite;
            Console.Write("..:::");
            Console.ForegroundColor = printlightblue;
            Console.Write("a");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::..");
            Console.ForegroundColor = printblack;
            Console.Write("           ");
            Console.WriteLine();

            // end line one


            // line two
            Console.ForegroundColor = printblack;
            Console.Write("            ");
            Console.ForegroundColor = printwhite;
            Console.Write("..:::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("d");
            Console.ForegroundColor = printlightblue;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::..");
            Console.ForegroundColor = printblack;
            Console.Write("      ");
            Console.WriteLine();
            //end line two




            Console.ForegroundColor = printblack;
            Console.Write("         ");
            Console.ForegroundColor = printwhite;
            Console.Write(".::::::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("d");
            Console.ForegroundColor = printlightblue;
            Console.Write("88");
            Console.ForegroundColor = printdarkblue;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::.");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();


            // end line three


            Console.ForegroundColor = printblack;
            Console.Write("       ");
            Console.ForegroundColor = printwhite;
            Console.Write(".:::::::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("d");
            Console.ForegroundColor = printlightblue;
            Console.Write("888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::::.");
            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.WriteLine();


            // end line four

            // line five
            Console.ForegroundColor = printblack;
            Console.Write("     ");
            Console.ForegroundColor = printwhite;
            Console.Write(".::::::::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("d");
            Console.ForegroundColor = printlightblue;
            Console.Write("88888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::::::.");
            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.WriteLine();

            // end line five


            // line six
            Console.Write("    ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("d");
            Console.ForegroundColor = printlightblue;
            Console.Write("8888888");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::::::::");
            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.WriteLine();





            // end line six


            // line seven
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("d");
            Console.ForegroundColor = printlightblue;
            Console.Write("888888888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::::::::");
            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.WriteLine();


            // end line seven


            // line eight
            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("d");
            Console.ForegroundColor = printlightblue;
            Console.Write("88888888888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::::::::");
            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.WriteLine();

            // end line eight


            // line nine
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write(".:::::::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("d");
            Console.ForegroundColor = printlightblue;
            Console.Write("88888888888888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::::::.");
            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.WriteLine();

            // end line nine


            // line ten
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("d");
            Console.ForegroundColor = printlightblue;
            Console.Write("888888888888888888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("a");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::::");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();


            // end line ten


            // line eleven
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("d");
            Console.ForegroundColor = printlightblue;
            Console.Write("888888888888888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printdarkblue;
            Console.Write("Y");
            Console.ForegroundColor = printlightblue;
            Console.Write("88");
            Console.ForegroundColor = printdarkblue;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::");
            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.WriteLine();



            // end line eleven


            // line twelve

            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("d");
            Console.ForegroundColor = printlightblue;
            Console.Write("88888888888888888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printdarkblue;
            Console.Write("8");
            Console.ForegroundColor = printlightblue;
            Console.Write("88");
            Console.ForegroundColor = printdarkblue;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();

            // end line twelve


            // line thirteen 
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write("`::::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("8");
            Console.ForegroundColor = printlightblue;
            Console.Write("88888888888888888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printdarkblue;
            Console.Write("Y");
            Console.ForegroundColor = printlightblue;
            Console.Write("888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::'");
            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.WriteLine();


            // end line thirteen


            // line fourteen
            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("8");
            Console.ForegroundColor = printlightblue;
            Console.Write("888888888888888888");

            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("Y");
            Console.ForegroundColor = printlightblue;
            Console.Write("88");
            Console.ForegroundColor = printdarkblue;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();

            //end line fourteen


            // line fifteen
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("Y");
            Console.ForegroundColor = printlightblue;
            Console.Write("888888888888888888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("?");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printdarkblue;
            Console.Write("d");
            Console.ForegroundColor = printlightblue;
            Console.Write("88");
            Console.ForegroundColor = printdarkblue;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();


            //end line fifteen



            // line sixteen
            Console.ForegroundColor = printblack;
            Console.Write("    ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("Y");
            Console.ForegroundColor = printlightblue;
            Console.Write("88888888888888888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write("d");
            Console.ForegroundColor = printlightblue;
            Console.Write("88");
            Console.ForegroundColor = printdarkblue;
            Console.Write("P");


            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();

            //end line sixteen


            // line seventeen
            Console.ForegroundColor = printblack;
            Console.Write("     ");
            Console.ForegroundColor = printwhite;
            Console.Write("`:::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("Y");
            Console.ForegroundColor = printlightblue;
            Console.Write("88888888888888888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::'");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();

            //end line seventeen


            // line eighteen
            Console.ForegroundColor = printblack;
            Console.Write("       ");
            Console.ForegroundColor = printwhite;
            Console.Write("`::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("Y");
            Console.ForegroundColor = printlightblue;
            Console.Write("88888888888888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::'");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();



            //end line eighteen


            // line nineteen
            Console.ForegroundColor = printblack;
            Console.Write("         ");
            Console.ForegroundColor = printwhite;
            Console.Write("`::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("Y");
            Console.ForegroundColor = printlightblue;
            Console.Write("8888888888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::'");
            Console.ForegroundColor = printblack;
            Console.Write("    ");
            Console.WriteLine();

            //end line nineteen


            // line twenty
            Console.ForegroundColor = printblack;
            Console.Write("            ");
            Console.ForegroundColor = printwhite;
            Console.Write("``::::::");
            Console.ForegroundColor = printdarkblue;
            Console.Write("Y");
            Console.ForegroundColor = printlightblue;
            Console.Write("888");
            Console.ForegroundColor = printdarkblue;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::''");
            Console.ForegroundColor = printblack;
            Console.Write("      ");
            Console.WriteLine();




            //end line twenty


            // line twentyone
            Console.ForegroundColor = printblack;
            Console.Write("                ");
            Console.ForegroundColor = printwhite;
            Console.Write("``:::::::::''");
            Console.ForegroundColor = printblack;
            Console.Write("           ");
            Console.WriteLine();

            // end line twentyone

        }

        #endregion



        #region myWhiteMana
        public static void myWhiteMana()
        {

 Console.WriteLine("               ..::::;::::..       ");
 Console.WriteLine("          ..:::::::::8:::::::::..");
 Console.WriteLine("       .::::::db::::d8b::::::::::::.");
Console.WriteLine("      .::::::::88:::d888b:::::d888::::.");
Console.WriteLine("    .:::::::::d88b::88888:::d888P:::::::.");
Console.WriteLine("   :::::::::::888888P???Y88888P:::d88:::::");
Console.WriteLine("  :::::888ba::888P?::aaa::?Y88::d888P:::::: ");             
Console.WriteLine(" ::::::Y8888888P:aad88888baa:Y8888P::::::::: ");           
Console.WriteLine(".::::::::Y8888P:d88888888888b:Y8P:::aaaadP::. ");         
Console.WriteLine(":::::::::::Y8P:a8888888888888a:Y88888888P::::  ");       
Console.WriteLine("::::aaaaaaad88:888888888888888:888888P:::::::  ");      
Console.WriteLine("::::8888888888:?8888888888888?:d888P:::::::::   ");    
Console.WriteLine("`:::????????Y8b:Y88888888888P:d88:::::::::::'   ");   
Console.WriteLine(" :::::::::::ad8b:??Y88888P??:d8888b:::::::::    ");  
Console.WriteLine("  :::::aa88888888ba;:???:;ad888::Y88b::::::     "); 
 Console.WriteLine("  :::::::::?Y888888baaaad88888::::Y8b::::   ");
Console.WriteLine("    `::::::::::d88P:88888P88888:::::::::' ");
Console.WriteLine("      `:::::::d8P:::8888P:::Y88:::::::'  ");
Console.WriteLine("        `:::::P:::::888P:::::YP:::::'   ");
Console.WriteLine("           ``:::::::Y8P:::::::::''     ");
Console.WriteLine("               ``:::::::::''         ");
        }

#endregion


        #region myWhiteManaColor
        public static void myWhiteManaColor()
        {
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


// line one
 Console.ForegroundColor = printblack;
 Console.Write("               ");
 Console.ForegroundColor = printwhite;
 Console.Write("..::::;::::..");
 Console.ForegroundColor = printblack;
 Console.Write("       ");
 Console.WriteLine();

 // end line one
 
            // line two
            Console.ForegroundColor = printblack;
            Console.Write("          ");
            Console.ForegroundColor = printwhite;
            Console.Write("..:::::::::");
            Console.ForegroundColor = printlightyellow;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::..");
            Console.WriteLine();
 
            // end line two


 // line three
 Console.ForegroundColor = printblack;
 Console.Write("       ");
 Console.ForegroundColor = printwhite;
 Console.Write(".::::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("db");
 Console.ForegroundColor = printwhite;
 Console.Write("::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("d8b");
 Console.ForegroundColor = printwhite;
 Console.Write("::::::::::::.");
 Console.WriteLine();

            // end line three

 // line four
 Console.ForegroundColor = printblack;
 Console.Write("      ");
 Console.ForegroundColor = printwhite;
 Console.Write(".::::::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("88");
 Console.ForegroundColor = printwhite;
 Console.Write(":::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("d88b");
 Console.ForegroundColor = printwhite;
 Console.Write(":::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("d888");
 Console.ForegroundColor = printwhite;
 Console.Write("::::.");
 Console.WriteLine();

 // end line four
 
            
            // line five
 Console.ForegroundColor = printblack;
 Console.Write("    ");
 Console.ForegroundColor = printwhite;
 Console.Write(".:::::::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("d88b");
 Console.ForegroundColor = printwhite;
 Console.Write("::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("88888");
 Console.ForegroundColor = printwhite;
 Console.Write(":::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("d888P");
 Console.ForegroundColor = printwhite;
 Console.Write(":::::::.");
 Console.WriteLine();




 // end line five

// line six
 Console.ForegroundColor = printblack;
 Console.Write("   ");
 Console.ForegroundColor = printwhite;
 Console.Write(":::::::::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("888888P");
 Console.ForegroundColor = printwhite;
 Console.Write("???");
 Console.ForegroundColor = printlightyellow;
 Console.Write("Y88888P");
 
 Console.ForegroundColor = printwhite;
 Console.Write(":::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("d88");
 Console.ForegroundColor = printwhite;
 Console.Write(":::::");
 Console.WriteLine();


 // end line six

// line seven 
 Console.ForegroundColor = printblack;
 Console.Write("  ");
 Console.ForegroundColor = printwhite;
 Console.Write(":::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("888ba");
 Console.ForegroundColor = printwhite;
 Console.Write("::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("888P?");

 Console.ForegroundColor = printwhite;
 Console.Write("::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("aaa");
 Console.ForegroundColor = printwhite;
 Console.Write("::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("?Y88");
 Console.ForegroundColor = printwhite;
 Console.Write("::");
 
 Console.ForegroundColor = printlightyellow;
 Console.Write("d888P");
 Console.ForegroundColor = printwhite;
 Console.Write("::::::");
 Console.ForegroundColor = printblack;
 Console.Write(" ");
 Console.WriteLine();

 // end line seven
 
            // line eight
 Console.ForegroundColor = printblack;
 Console.Write(" ");
 Console.ForegroundColor = printwhite;
 Console.Write("::::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("Y8888888P");
 Console.ForegroundColor = printwhite;
 Console.Write(":");
 Console.ForegroundColor = printlightyellow;
 Console.Write("aad88888baa");

 Console.ForegroundColor = printwhite;
 Console.Write(":");
 Console.ForegroundColor = printlightyellow;
 Console.Write("Y8888P");
 Console.ForegroundColor = printwhite;
 Console.Write(":::::::::");
 

 
 Console.ForegroundColor = printblack;
 Console.Write(" ");
 Console.WriteLine();

 // end line eight
 
            // line nine  
 
 Console.ForegroundColor = printwhite;
 Console.Write(".::::::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("Y8888P");
 Console.ForegroundColor = printwhite;
 Console.Write(":");
 Console.ForegroundColor = printlightyellow;
 Console.Write("d88888888888b");

 Console.ForegroundColor = printwhite;
 Console.Write(":");
 Console.ForegroundColor = printlightyellow;
 Console.Write("Y8P");
 Console.ForegroundColor = printwhite;
 Console.Write(":::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("aaaadP");
 Console.ForegroundColor = printwhite;
 Console.Write("::.");
 Console.ForegroundColor = printblack;
 Console.Write(" ");
 Console.WriteLine();


 // end line nine
  // line ten  
 Console.ForegroundColor = printwhite;
 Console.Write(":::::::::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("Y8P");
 Console.ForegroundColor = printwhite;
 Console.Write(":");
 Console.ForegroundColor = printlightyellow;
 Console.Write("a8888888888888a");

 Console.ForegroundColor = printwhite;
 Console.Write(":");
 Console.ForegroundColor = printlightyellow;
 Console.Write("Y88888888P");
 Console.ForegroundColor = printwhite;
 Console.Write("::::");
 
 Console.ForegroundColor = printblack;
 Console.Write(" ");
 Console.WriteLine();


 // end line ten


 // line eleven
 Console.ForegroundColor = printwhite;
 Console.Write("::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("aaaaaaad88");
 Console.ForegroundColor = printwhite;
 Console.Write(":");
 Console.ForegroundColor = printlightyellow;
 Console.Write("888888888888888");

 Console.ForegroundColor = printwhite;
 Console.Write(":");
 Console.ForegroundColor = printlightyellow;
 Console.Write("888888P");
 Console.ForegroundColor = printwhite;
 Console.Write(":::::::");

 Console.ForegroundColor = printblack;
 Console.Write("  ");
 Console.WriteLine();


 // end line eleven
 
            
            // line twelve  
 Console.ForegroundColor = printwhite;
 Console.Write("::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("8888888888");
 Console.ForegroundColor = printwhite;
 Console.Write(":?");
 Console.ForegroundColor = printlightyellow;
 Console.Write("8888888888888?");

 Console.ForegroundColor = printwhite;
 Console.Write(":");
 Console.ForegroundColor = printlightyellow;
 Console.Write("d888P");
 Console.ForegroundColor = printwhite;
 Console.Write(":::::::::");

 Console.ForegroundColor = printblack;
 Console.Write("   ");
 Console.WriteLine();
 // end line twelve


    // line thirteen
 Console.ForegroundColor = printwhite;
 Console.Write("`:::????????");
 Console.ForegroundColor = printlightyellow;
 Console.Write("Y8b");
 Console.ForegroundColor = printwhite;
 Console.Write(":");
 Console.ForegroundColor = printlightyellow;
 Console.Write("Y88888888888P");

 Console.ForegroundColor = printwhite;
 Console.Write(":");
 Console.ForegroundColor = printlightyellow;
 Console.Write("d88");
 
 Console.ForegroundColor = printwhite;
 Console.Write(":::::::::::'");

 Console.ForegroundColor = printblack;
 Console.Write("   ");
 Console.WriteLine();


 // end line thirteen
 
            // line fourteen
 Console.ForegroundColor = printwhite;
 Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("Y8b");
 Console.ForegroundColor = printwhite;
 Console.Write(":");
 Console.ForegroundColor = printlightyellow;
 Console.Write("Y88888888888P");

 Console.ForegroundColor = printwhite;
 Console.Write(":");
 Console.ForegroundColor = printlightyellow;
 Console.Write("d88");

 Console.ForegroundColor = printwhite;
 Console.Write(":::::::::::'");

 Console.ForegroundColor = printblack;
 Console.Write("   ");
 Console.WriteLine();


 // end line fourteen

            // line fifteen
 Console.ForegroundColor = printwhite;
 Console.Write("  ");
 Console.ForegroundColor = printwhite;
 Console.Write(":::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("aa88888888ba;:");
 Console.ForegroundColor = printwhite;
 Console.Write("???");
 Console.ForegroundColor = printlightyellow;
 Console.Write(":;ad888");

 Console.ForegroundColor = printwhite;
 Console.Write("::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("Y88b");

 Console.ForegroundColor = printwhite;
 Console.Write("::::::");

 Console.ForegroundColor = printblack;
 Console.Write("     ");
 Console.WriteLine();
 // end line fifteen



            // line sixteen
 Console.ForegroundColor = printwhite;
 Console.Write("  ");
 Console.ForegroundColor = printwhite;
 Console.Write(":::::::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("?Y888888baaaad88888");
 Console.ForegroundColor = printwhite;
 Console.Write("::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("Y8b");

 Console.ForegroundColor = printwhite;
 Console.Write("::::");
 
 Console.ForegroundColor = printblack;
 Console.Write("   ");
 Console.WriteLine();
 // end line sixteen

            // line seventeen
 Console.ForegroundColor = printwhite;
 Console.Write("    ");
 Console.ForegroundColor = printwhite;
 Console.Write("`::::::::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("d88P");
 Console.ForegroundColor = printwhite;
 Console.Write(":");
 Console.ForegroundColor = printlightyellow;
 Console.Write("88888P88888");

 Console.ForegroundColor = printwhite;
 Console.Write(":::::::::'");

 Console.ForegroundColor = printblack;
 Console.Write(" ");
 Console.WriteLine();

 // end line seventeen
 
            // line eighteen
 Console.ForegroundColor = printwhite;
 Console.Write("      ");
 Console.ForegroundColor = printwhite;
 Console.Write("`:::::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("d8P");
 Console.ForegroundColor = printwhite;
 Console.Write(":::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("8888P");

 Console.ForegroundColor = printwhite;
 Console.Write(":::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("Y88");
 Console.ForegroundColor = printwhite;
 Console.Write(":::::::'");

 Console.ForegroundColor = printblack;
 Console.Write("  ");
 Console.WriteLine();

 // end line eightteen

            // line nineteen
 Console.ForegroundColor = printwhite;
 Console.Write("        ");
 Console.ForegroundColor = printwhite;
 Console.Write("`:::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("P");
 Console.ForegroundColor = printwhite;
 Console.Write(":::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("888P");

 Console.ForegroundColor = printwhite;
 Console.Write(":::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("YP");
 Console.ForegroundColor = printwhite;
 Console.Write(":::::'");

 Console.ForegroundColor = printblack;
 Console.Write("   ");
 Console.WriteLine();

 // end line nineteen
 
            // line twenty
 Console.ForegroundColor = printwhite;
 Console.Write("           ");
 Console.ForegroundColor = printwhite;
 Console.Write("``:::::::");
 Console.ForegroundColor = printlightyellow;
 Console.Write("Y8P");
 Console.ForegroundColor = printwhite;
 Console.Write(":::::::::''");
 
 

 Console.ForegroundColor = printblack;
 Console.Write("     ");
 Console.WriteLine();



 // end line twenty

  // line twentyone
 Console.ForegroundColor = printblack;
 Console.Write(" ");
            Console.ForegroundColor = printwhite;
 Console.Write("               ");
 Console.ForegroundColor = printwhite;
 Console.Write("``:::::::::''");
 



 Console.ForegroundColor = printblack;
 Console.Write("         ");
 Console.WriteLine();

            // end line twentyone
        }

#endregion

        #region myGreenMana
        public static void myGreenMana()
        {
            Console.WriteLine("                   ..:::;;;:::..         "); // line one
            Console.WriteLine("          ..:::::d88888b::;;:::..     ");// line two
            Console.WriteLine("       .:::d88bad8888888::88888b:::. ");// line three
            Console.WriteLine("      .::d88888888888:?88:888888888b::.  ");// line four
            Console.WriteLine("    .::d8888888888888a:88888888888888b::.");// line five
            Console.WriteLine("   :::d8888888888888888888888888888888b:::  ");   // line six   
            Console.WriteLine("  ::::8888?88888888888888888888888888888b::    ");   // line seven
            Console.WriteLine(" :::ad8??:a888?8888:888888:888888888888888b:     ");// line eight
            Console.WriteLine(".:d8888a888888a:?88:88888?:8888888888888888:.   ");// line nine
            Console.WriteLine("::)8888888888888a88888888:a8888888888888888b:  ");// line ten
            Console.WriteLine("::888888888888:???888888888??:::888888888888: ");// line eleven
            Console.WriteLine("::Y888888888888sss:8888888aaa8888888888888P::");// line twelve
            Console.WriteLine("`::???::::::::::::888888888:::::::::::::::::'");// line thirteen
            Console.WriteLine(" :::::::::::::::::888888888:::::::::::::::::");// line fourteen
            Console.WriteLine("  ::::::::::::::::888888888::::::::::::::::");// line fifteen
            Console.WriteLine("   :::::::::::::::888888888:::::::::::::::");// line sixteen
            Console.WriteLine("    `:::::::::::::888888888:::::::::::::'");// line seventeen
            Console.WriteLine("      `:::::::::::888888888::::aa:::::' ");// line eighteen
            Console.WriteLine("        `::::ad8888888888888888P::::'  ");// line nineteen
            Console.WriteLine("           ``::??Y888888888P??::''    ");// line twenty
            Console.WriteLine("                ``:::::::::''");// line twentyone

        }
        #endregion



        #region myGreenManaColor
        public static void myGreenManaColor()
        {
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



            // line one
            Console.ForegroundColor = printblack;
            Console.Write("                ");
            Console.ForegroundColor = printwhite;
            Console.Write("..:::;;;:::..");
            Console.ForegroundColor = printblack;
            Console.Write("         ");
            Console.WriteLine();




            // end line one

           // line two
            Console.ForegroundColor = printblack;
            Console.Write("          ");
            Console.ForegroundColor = printwhite;
            Console.Write(" ..:::::");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("d");
            Console.ForegroundColor = printlightgreen;
            Console.Write("88888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write("::;;:::..");
            Console.ForegroundColor = printblack;
            Console.Write("     ");
            Console.WriteLine();

            // end line two
            
            
            // line three
            Console.ForegroundColor = printblack;
            Console.Write("       ");
            Console.ForegroundColor = printwhite;
            Console.Write(".:::");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("d");
            Console.ForegroundColor = printlightgreen;
            Console.Write("88ba");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("d");
            Console.ForegroundColor = printlightgreen;
            Console.Write("8888888");
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("8");
            Console.ForegroundColor = printlightgreen;
            Console.Write("8888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write(":::.");
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.WriteLine();




            // end line three
            
            // line four


            Console.ForegroundColor = printblack;
            Console.Write("      ");
            Console.ForegroundColor = printwhite;
            Console.Write(".::");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("d");
            Console.ForegroundColor = printlightgreen;
            Console.Write("d88888888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write(":?");
            Console.ForegroundColor = printlightgreen;
            Console.Write("88");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            
            Console.ForegroundColor = printlightgreen;
            Console.Write("888888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("b");
            Console.ForegroundColor = printblack;
            Console.ForegroundColor = printwhite;
            Console.Write("::.");
            Console.Write("  ");
            Console.WriteLine();

            // end line four


           // line five
            Console.ForegroundColor = printblack;
            Console.Write("    ");
            Console.ForegroundColor = printwhite;
            Console.Write(".::");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("d");
            Console.ForegroundColor = printlightgreen;
            Console.Write("8888888888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("a");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printlightgreen;
            Console.Write("88888888888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write("::.");
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.WriteLine();


            // end line five

             // line six   
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("d");
            Console.ForegroundColor = printlightgreen;
            Console.Write("8888888888888888888888888888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write(":::");
            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.WriteLine();
            // end line six
            
            
            // line seven
            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.ForegroundColor = printwhite;
            Console.Write("::::");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("8");
            Console.ForegroundColor = printlightgreen;
            Console.Write("888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("?");
            Console.ForegroundColor = printlightgreen;
            Console.Write("88888888888888888888888888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.ForegroundColor = printblack;
            Console.Write("    ");
            Console.WriteLine();
            // end line seven
            
            // line eight
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("ad8??");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printlightgreen;
            Console.Write("a888?8888");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printlightgreen;
            Console.Write("888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write(":");
            Console.ForegroundColor = printlightgreen;
            Console.Write("888888888888888");

            Console.ForegroundColor = printdarkgreen;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write(":");

            Console.ForegroundColor = printblack;
            Console.Write("     ");
            Console.WriteLine();

            // end line eight

           // line nine
            Console.ForegroundColor = printwhite;
            Console.Write(".:");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("d");
            Console.ForegroundColor = printlightgreen;
            Console.Write("8888");
            Console.ForegroundColor = printwhite;
            Console.Write("a");
            Console.ForegroundColor = printlightgreen;
            Console.Write("888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("a:?");
            Console.ForegroundColor = printlightgreen;
            Console.Write("88");

            Console.ForegroundColor = printdarkgreen;
            Console.Write(":");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
         
            Console.ForegroundColor = printlightgreen;
            Console.Write("88888888888888888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write(":.");

            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();
            // end line nine
           
            // line ten
            Console.ForegroundColor = printwhite;
            Console.Write("::)");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("8");
            Console.ForegroundColor = printlightgreen;
            Console.Write("888888888888");
            Console.ForegroundColor = printwhite;
            Console.Write("a");
            Console.ForegroundColor = printlightgreen;
            Console.Write("88888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("8");
            Console.ForegroundColor = printlightgreen;
            Console.Write("8888888888888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.WriteLine();


            // end line ten
           
            
            // line eleven
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("8");
            Console.ForegroundColor = printlightgreen;
            Console.Write("88888888888");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("???");
            Console.ForegroundColor = printlightgreen;
            Console.Write("888888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("??");
            Console.ForegroundColor = printwhite;
            Console.Write(":::");
            Console.ForegroundColor = printlightgreen;
            Console.Write("8888888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.WriteLine();

            // end line eleven
           
            
            // line twelve
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("Y");
            Console.ForegroundColor = printlightgreen;
            Console.Write("888888888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("sss");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printlightgreen;
            Console.Write("8888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("aaa");
            Console.ForegroundColor = printlightgreen;
            Console.Write("8888888888888");
            Console.ForegroundColor = printdarkgreen;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.WriteLine();
            // end line twelve
            
            // line thirteen
            Console.ForegroundColor = printblack;
            Console.Write("");
            Console.ForegroundColor = printwhite;
            Console.Write("`::???::::::::::::");

            Console.ForegroundColor = printdarkyellow;
            Console.Write("888");
            Console.ForegroundColor = printblack;
            Console.Write("88");
            Console.ForegroundColor = printdarkyellow;
            Console.Write("8888");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::::::'");
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.WriteLine();



            // end line thirteen
           
            
            // line fourteen
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::::::");

            Console.ForegroundColor = printdarkyellow;
            Console.Write("888");
            Console.ForegroundColor = printblack;
            Console.Write("88");
            Console.ForegroundColor = printdarkyellow;
            Console.Write("8888");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::::::");
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.WriteLine();



            // end line fourteen
           
            
            // line fifteen
            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::::::");

            Console.ForegroundColor = printdarkyellow;
            Console.Write("888888888");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::::::");
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.WriteLine();
            // end line fifteen
            
            // line sixteen
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::::");

            Console.ForegroundColor = printdarkyellow;
            Console.Write("888888888");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::::");
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.WriteLine();
            // end line sixteen
           
            // line seventeen
            Console.ForegroundColor = printblack;
            Console.Write("    ");
            Console.ForegroundColor = printwhite;
            Console.Write("`:::::::::::::");

            Console.ForegroundColor = printdarkyellow;
            Console.Write("888888888");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::'");
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.WriteLine();


            // end line seventeen
           
            // line eighteen
            Console.ForegroundColor = printblack;
            Console.Write("      ");
            Console.ForegroundColor = printwhite;
            Console.Write("`:::::::::::");

            Console.ForegroundColor = printdarkyellow;
            Console.Write("888888888");
            Console.ForegroundColor = printwhite;
            Console.Write("::::aa:::::'");
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.WriteLine();



            // end line eighteen
           
            // line nineteen
            Console.ForegroundColor = printblack;
            Console.Write("        ");
            Console.ForegroundColor = printwhite;
            Console.Write("`::::");

            Console.ForegroundColor = printdarkyellow;
            Console.Write("ad8888888888888888P");
            Console.ForegroundColor = printwhite;
            Console.Write("::::'");
            Console.ForegroundColor = printblack;
            Console.Write("    ");
            Console.WriteLine();


            // end line nineteen
          
            
            // line twenty
            
            Console.ForegroundColor = printblack;
            Console.Write("           ");
            Console.ForegroundColor = printwhite;
            Console.Write("``::??");

            Console.ForegroundColor = printdarkyellow;
            Console.Write("Y888888888P");
            Console.ForegroundColor = printwhite;
            Console.Write("??::''");
            Console.ForegroundColor = printblack;
            Console.Write("    ");
            Console.WriteLine();




            // end line twenty
            
            // line twentyone
            Console.ForegroundColor = printblack;
            Console.Write("                ");
            Console.ForegroundColor = printwhite;
            Console.Write("``");

            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::");
            Console.ForegroundColor = printwhite;
            Console.Write("''");
            Console.ForegroundColor = printblack;
            Console.Write("         ");
            Console.WriteLine();




            // end twenty one
        }
        #endregion





        #region myRedMana
        public static void myRedMana()
        {
            Console.WriteLine("             ...::::::::::::...             ");// line one
            Console.WriteLine("          ..:::::?Y8888888b::::..       ");// line two
            Console.WriteLine("       .:::::d8888P:::Y8888888b::::.   ");// line three
            Console.WriteLine("     .:::::d88888b:::::Y88P::Y888b:::.    ");  // line four
            Console.WriteLine("   .::::::d8P:::::::::::88::::88888b:::.   ");// line five
            Console.WriteLine("   :::::::P:d:::::::::::d??ba:d8888888b::: ");// line six
            Console.WriteLine(" :::::::::?::::::::::::::::::::::Y8888b:Y:  ");// line seven
            Console.WriteLine(" ::::::::::::::::::::::::::::::::::Y8888b:Y: ");// line eight
            Console.WriteLine(".::::::::::::::::::::::::::::::::b::88888:8:.");// line nine
            Console.WriteLine(":::::::::::::::::;;:::::::;;a:::::b::888888::");// line ten
            Console.WriteLine(":::::::::::::::d8888baaaaa88::::::)P:888888::");// line eleven
            Console.WriteLine(":::::::::::::d8888888888888P::::::d:d88888P::");// line twelve
            Console.WriteLine("`:::::::::::d88888888888P::::::::d8888888P::'");// line thirteen
            Console.WriteLine(" ::::::::::d88888888888P::::::d8888888P::;:: ");// line fourteen
            Console.WriteLine("  ::::::::d888888888888::::d88888888P?:dP::   ");// line fifteen
            Console.WriteLine("   :::::::888888888888888888888888888bdP::   ");// line sixteen
            Console.WriteLine("    `:::::888888888888888888888888888P::'   ");// line seventeen
            Console.WriteLine("      `::::Y888888888888888888888P::::'   ");// line eighteen
            Console.WriteLine("        `::::Y8888888888888888P:::::'   ");// line nineteen
            Console.WriteLine("           ``:::::Y8888888baaa;:''    ");// line twenty
            Console.WriteLine("               ``:::::::::''       ");// line twentyone


        }

        #endregion


        #region myRedManaColor
        public static void myRedManaColor()
        {
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


           // consolePaint();

           
            // line one
            Console.ForegroundColor = printblack;
            Console.Write("             ");
            Console.ForegroundColor = printwhite;
            Console.Write("...::::::::::::...");
            Console.ForegroundColor = printblack;
            Console.Write("             ");
            Console.WriteLine();

            // end line one






            // end line one
           
            
            // line two
            Console.ForegroundColor = printblack;
            Console.Write("          ");
            Console.ForegroundColor = printwhite;
            Console.Write("..:::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("?Y");
            Console.ForegroundColor = printlightred;
            Console.Write("8888888");
            Console.ForegroundColor = printdarkred;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write("::::..");
            Console.ForegroundColor = printblack;
            Console.Write("       ");
            Console.WriteLine();
            // end line two

           // line three
            Console.ForegroundColor = printblack;
            Console.Write("       ");
            Console.ForegroundColor = printwhite;
            Console.Write(".:::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("d");
            Console.ForegroundColor = printlightred;
            Console.Write("8888");
            Console.ForegroundColor = printdarkred;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write(":::");
            Console.ForegroundColor = printdarkred;
            Console.Write("Y");
            Console.ForegroundColor = printlightred;
            Console.Write("8888888");
            Console.ForegroundColor = printdarkred;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write("::::.");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();






            // end line three

            // line four
            Console.ForegroundColor = printblack;
            Console.Write("     ");
            Console.ForegroundColor = printwhite;
            Console.Write(".:::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("d");
            Console.ForegroundColor = printlightred;
            Console.Write("8888");
            Console.ForegroundColor = printdarkred;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("Y");
            Console.ForegroundColor = printlightred;
            Console.Write("88");
            Console.ForegroundColor = printdarkred;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.ForegroundColor = printdarkred;
            Console.Write("Y");
            Console.ForegroundColor = printlightred;
            Console.Write("888");
            Console.ForegroundColor = printdarkred;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write(":::.");
            Console.ForegroundColor = printblack;
            Console.Write("    ");
            Console.WriteLine();




            // end line four


            // line five
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.ForegroundColor = printwhite;
            Console.Write(".::::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("d");
            Console.ForegroundColor = printlightred;
            Console.Write("8");
            Console.ForegroundColor = printdarkred;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::");
            Console.ForegroundColor = printlightred;
            Console.Write("88");
            Console.ForegroundColor = printwhite;
            Console.Write("::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("8");
            Console.ForegroundColor = printlightred;
            Console.Write("8888");
            Console.ForegroundColor = printdarkred;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write(":::.");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();




            // end line five

           // line six
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::");
            Console.ForegroundColor = printlightred;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printlightred;
            Console.Write("d");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("d");
            Console.ForegroundColor = printlightred;
            Console.Write("??b");
           
            Console.ForegroundColor = printdarkred;
            Console.Write("a");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printdarkred;
            Console.Write("d");
            Console.ForegroundColor = printlightred;
            Console.Write("8888888");
            Console.ForegroundColor = printdarkred;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write(":::");
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.WriteLine();



            // end line six


           // line seven
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::?::::::::::::::::::::::");
           
            Console.ForegroundColor = printdarkred;
            Console.Write("Y");
            Console.ForegroundColor = printlightred;
            Console.Write("8888b");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printdarkred;
            Console.Write("Y");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            
           
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.WriteLine();


            // end line seven
           
            // line eight
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::::::::::::::::::::::::::");

            Console.ForegroundColor = printdarkred;
            Console.Write("Y");
            Console.ForegroundColor = printlightred;
            Console.Write("8888b");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printdarkred;
            Console.Write("Y");
            Console.ForegroundColor = printwhite;
            Console.Write(":");


            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.WriteLine();


            // end line eight
           
            // line nine
            
            Console.ForegroundColor = printwhite;
            Console.Write(".::::::::::::::::::::::::::::::::");

            Console.ForegroundColor = printdarkred;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.ForegroundColor = printlightred;
            Console.Write("88888");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printdarkred;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write(":.");


            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.WriteLine();



            // end line nine
            
            // line ten
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::::::;;:::::::;;a:::::b::");

            Console.ForegroundColor = printdarkred;
            Console.Write("8");
            Console.ForegroundColor = printlightred;
            Console.Write("8888");
            Console.ForegroundColor = printdarkred;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            
            Console.WriteLine();



            // end line ten
            
            // line eleven
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::::");

            Console.ForegroundColor = printdarkred;
            Console.Write("d");
            Console.ForegroundColor = printlightred;
            Console.Write("8888baaaaa8");
            Console.ForegroundColor = printdarkred;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::");
            Console.ForegroundColor = printlightred;
            Console.Write(")P");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printlightred;
            Console.Write("88888");
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.WriteLine();
            // end line eleven
            
            
            // line twelve
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::");

            Console.ForegroundColor = printdarkred;
            Console.Write("d");
            Console.ForegroundColor = printlightred;
            Console.Write("8888888888888");
            Console.ForegroundColor = printdarkred;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::");
            Console.ForegroundColor = printlightred;
            Console.Write("d");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printdarkred;
            Console.Write("d");
            Console.ForegroundColor = printlightred;
            Console.Write("88888");
            Console.ForegroundColor = printdarkred;
            Console.Write("P");
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.WriteLine();



            // end line twelve


           // line thirteen
            Console.ForegroundColor = printwhite;
            Console.Write("`:::::::::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("d");
            Console.ForegroundColor = printlightred;
            Console.Write("88888888888");
            Console.ForegroundColor = printdarkred;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("d");
            Console.ForegroundColor = printlightred;
            Console.Write("8888888");
            Console.ForegroundColor = printdarkred;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write("::'");
            Console.WriteLine();





            // end line thirteen
           
            
            // line fourteen
            Console.ForegroundColor = printblack;
            Console.Write(" ");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("d");
            Console.ForegroundColor = printlightred;
            Console.Write("88888888888");
            Console.ForegroundColor = printdarkred;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("d");
            Console.ForegroundColor = printlightred;
            Console.Write("8888888");
            Console.ForegroundColor = printdarkred;
            Console.Write("P");         
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.ForegroundColor = printlightred;
            Console.Write(";");
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();






            // end line fourteen
            
            
            // line fifteen
            Console.ForegroundColor = printblack;
            Console.Write("  ");
            Console.ForegroundColor = printwhite;
            Console.Write("::::::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("d");
            Console.ForegroundColor = printlightred;
            Console.Write("88888888888");
            Console.ForegroundColor = printdarkred;
            Console.Write("8");
            Console.ForegroundColor = printwhite;
            Console.Write("::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("d");
            Console.ForegroundColor = printlightred;
            Console.Write("88888888");
            Console.ForegroundColor = printdarkred;
            Console.Write("P?");
            Console.ForegroundColor = printwhite;
            Console.Write(":");
            Console.ForegroundColor = printlightred;
            Console.Write("dP");
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();





            // end line fifteen
          
            // line sixteen
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("8");
            Console.ForegroundColor = printlightred;
            Console.Write("88888888888888888888888888");
            Console.ForegroundColor = printdarkred;
            Console.Write("b");
            Console.ForegroundColor = printlightred;
            Console.Write("d");
            Console.ForegroundColor = printdarkred;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write("::");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();




            // end line sixteen
            
            // line seventeen
            Console.ForegroundColor = printblack;
            Console.Write("    ");
            Console.ForegroundColor = printwhite;
            Console.Write("`:::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("8");
            Console.ForegroundColor = printlightred;
            Console.Write("88888888888888888888888888");
            Console.ForegroundColor = printdarkred;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write("::'");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();




            // end line seventeen


            // line eighteen
            Console.ForegroundColor = printblack;
            Console.Write("      ");
            Console.ForegroundColor = printwhite;
            Console.Write("`::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("Y");
            Console.ForegroundColor = printlightred;
            Console.Write("888888888888888888888");
            Console.ForegroundColor = printdarkred;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write("::::'");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();



            // end line eighteen


            // line nineteen
            Console.ForegroundColor = printblack;
            Console.Write("        ");
            Console.ForegroundColor = printwhite;
            Console.Write("`::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("Y");
            Console.ForegroundColor = printlightred;
            Console.Write("8888888888888888");
            Console.ForegroundColor = printdarkred;
            Console.Write("P");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::'");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();




            // end line nineteen
           
            
            // line twenty
            Console.ForegroundColor = printblack;
            Console.Write("           ");
            Console.ForegroundColor = printwhite;
            Console.Write("``:::::");
            Console.ForegroundColor = printdarkred;
            Console.Write("Y");
            Console.ForegroundColor = printlightred;
            Console.Write("8888888");
            Console.ForegroundColor = printdarkred;
            Console.Write("b");
            Console.ForegroundColor = printlightred;
            Console.Write("aaa");
            Console.ForegroundColor = printdarkred;
            Console.Write(";");
            Console.ForegroundColor = printwhite;
            Console.Write(":''");
            Console.ForegroundColor = printblack;
            Console.Write("    ");
            Console.WriteLine();
            
            
            // end line twenty
            
            
            // line twentyone
            Console.ForegroundColor = printblack;
            Console.Write("               ");
            Console.ForegroundColor = printwhite;
            Console.Write("``:::::::::''");
            Console.ForegroundColor = printblack;
            Console.Write("       ");
            Console.WriteLine();
            // end line twenty one


        }

        #endregion



    }



    

