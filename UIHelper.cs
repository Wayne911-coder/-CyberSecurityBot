using System;
public class UIHelper
{
    public static void ShowLogo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine(@"
  _____       _                _____         _   
 / ____|     | |              |  __ \      | |  
| |     _    | |__   ___ _ __ | |__) | __ _| |_ 
| |    | | | | '_ \ / _ \ '__||  __ / | _  | __|
| |____| |_| | |_) |  __/ |   | |_ ) \||_| | |_ 
 \_____|\__, |_.__/ \___|_|   |__ _ _/|__ _|\__|
         __/ |                                          
        |___/                                           
");
        Console.ResetColor();
    }
}
