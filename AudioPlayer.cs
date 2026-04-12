using System;
using System.Media;

public class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.PlaySync(); // waits until audio finishes
        }
        catch (Exception ex)
        {
            Console.WriteLine(" Error playing audio: " + ex.Message);
        }
    }
}
