using System;
public class Chatbot
{
    private string userName = "";

    public void Start()
    {
        AskName();
        ChatLoop();
    }

    private void AskName()
    {
        Console.Write("Enter your name: ");
        userName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userName))
        {
            userName = "User";
        }

        Console.WriteLine($"\nWelcome, {userName}! ");
    }

    private void ChatLoop()
    {
        while (true)
        {
            Console.Write("\nAsk me something: ");
            string input = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(" Please enter something.");
                continue;
            }

            if (input.Contains("how are you"))
            {
                Console.WriteLine("I'm just a bot, but I'm here to help!");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("I help you stay safe online.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Use strong passwords with letters, numbers, and symbols.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Avoid clicking suspicious links or emails.");
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Only visit secure websites (https).");
            }
            else if (input.Contains("exit"))
            {
                Console.WriteLine("Goodbye! Stay safe online ");
                break;
            }
            else
            {
                Console.WriteLine("I didn’t understand that. Try asking about cybersecurity.");
            }
        }
    }
}
