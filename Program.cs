using System;
class Program
{
    static void Main(string[] args)
    {
        UIHelper.ShowLogo();
        AudioPlayer.PlayGreeting();

        Chatbot bot = new Chatbot();
        bot.Start();
    }
}