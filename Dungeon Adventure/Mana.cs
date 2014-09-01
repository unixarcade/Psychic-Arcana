using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//luminosity
// http://luminosity.livejournal.com

namespace Dungeon_Adventure
{
    class Mana
    {

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
            Console.ForegroundColor = printlightblue;
            Console.Write("d8");
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
            Console.ForegroundColor = printlightblue;
            Console.Write("d");
            Console.ForegroundColor = printdarkblue;
            Console.Write("88");
            Console.ForegroundColor = printlightblue;
            Console.Write("b");
            Console.ForegroundColor = printwhite;
            Console.Write(":::::::::::::.");
            Console.ForegroundColor = printblack;
            Console.Write("   ");
            Console.WriteLine();


            // end line three

            Console.WriteLine("       .:::::::::::d8888:::::::::::::::.  ");     // line four


            // end line four
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

 Console.WriteLine("               ..::::;::::..       "); // line one
 Console.WriteLine("          ..:::::::::8:::::::::.."); // line two
 Console.WriteLine("       .::::::db::::d8b::::::::::::."); // line three
 Console.WriteLine("      .::::::::88:::d888b:::::d888::::."); // line four
 Console.WriteLine("    .:::::::::d88b::88888:::d888P:::::::."); // line five
 Console.WriteLine("   :::::::::::888888P???Y88888P:::d88:::::"); // line six
 Console.WriteLine("  :::::888ba::888P?::aaa::?Y88::d888P:::::: "); // line seven            
 Console.WriteLine(" ::::::Y8888888P:aad88888baa:Y8888P::::::::: "); // line eight          
 Console.WriteLine(".::::::::Y8888P:d88888888888b:Y8P:::aaaadP::. ");  // line nine       
 Console.WriteLine(":::::::::::Y8P:a8888888888888a:Y88888888P::::  "); // line ten      
 Console.WriteLine("::::aaaaaaad88:888888888888888:888888P:::::::  "); // line eleven     
 Console.WriteLine("::::8888888888:?8888888888888?:d888P:::::::::   ");  // line twelve  
 Console.WriteLine("`:::????????Y8b:Y88888888888P:d88:::::::::::'   ");   // line thirteen
 Console.WriteLine(" :::::::::::ad8b:??Y88888P??:d8888b:::::::::    ");  // line fourteen
 Console.WriteLine("  :::::aa88888888ba;:???:;ad888::Y88b::::::     "); // line fifteen
 Console.WriteLine("  :::::::::?Y888888baaaad88888::::Y8b::::   "); // line sixteen
 Console.WriteLine("    `::::::::::d88P:88888P88888:::::::::' "); // line seventeen
 Console.WriteLine("      `:::::::d8P:::8888P:::Y88:::::::'  "); // line eighteen
 Console.WriteLine("        `:::::P:::::888P:::::YP:::::'   "); // line nineteen
 Console.WriteLine("           ``:::::::Y8P:::::::::''     "); // line twenty
 Console.WriteLine("               ``:::::::::''         "); // line twentyone
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





        #region myRedMana
        public static void myRedMana()
        {
            Console.WriteLine("             ..:::::::::..             ");// line one
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
            Console.WriteLine("                 ``:::::::::''       ");// line twentyone


        }

        #endregion


        #region myRedManaColor
        public static void myRedManaColor()
        {
            Console.WriteLine("             ..:::::::::..             ");// line one
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
            Console.WriteLine("                 ``:::::::::''       ");// line twentyone


        }

        #endregion



    }
}
