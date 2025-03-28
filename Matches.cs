using System;

public class Matches
{
    public static void Run()
    {
        StoryElements.Matches();
        string player_choice = Adventure_Game.UserInput();
        string path = Choices(player_choice);

        while(path == "error")
        {
            Console.WriteLine("The choice you entered is invalid, please enter a valid choice.");
            player_choice = Adventure_Game.UserInput();
            path = Choices(player_choice);
        }

        Adventure_Game.End();
    }

    static string Choices(string player_choice)
    {
        player_choice = player_choice.ToLower();
        if(player_choice == "open")
        {
            StoryElements.OpenDoor_matches();
            return "continue";
        }
        else if(player_choice == "follow")
        {
            StoryElements.Hallway();
            return "continue";
        }
        else
        {
            return "error";
        }
    }
}