using System;
using System.Diagnostics;

class Adventure_Game
{

    public static string UserInput()
    {
        string player_choice = Console.ReadLine();
        if(player_choice == "")
        {
            Console.WriteLine("Please enter a value.");
            return UserInput();
        }
        else
        {
            return player_choice;
        }
    }
    
    static string Choices(string player_choice)
    {
        player_choice = player_choice.ToLower();
        if (player_choice == "flashlight")
        {
            Flashlight.Run();
            return "continue";
        }
        else if (player_choice == "matches")
        {
            Matches.Run();
            return "continue";
        }
        else
        {
            return "error";
        }
    }

    public static void End()
    {
        Console.WriteLine("\nThank you for playing!\nWould you like to play again? (Y/N)");
        string playAgain = Console.ReadLine();
        playAgain = playAgain.ToLower();
        while(playAgain != "yes" && playAgain != "y" && playAgain != "no" && playAgain != "n")
        {
            Console.WriteLine("Please enter a valid option (Yes/No)");
            playAgain = Console.ReadLine();
            playAgain = playAgain.ToLower();
        }

        if(playAgain == "yes" || playAgain == "y")
        {
            Main();
        }
        else
        {
            Console.WriteLine("\nHave a great day!!\n");
        }
    }

    static void Main()
    {
        StoryElements.DisplayStart();
        string player_choice = UserInput();
        string path = Choices(player_choice);

        while(path == "error")
        {
            Console.WriteLine("The choice you entered is invalid, please enter a valid choice.");
            player_choice = UserInput();
            path = Choices(player_choice);
        }
    }
}