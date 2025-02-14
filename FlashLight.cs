using System;

public class Flashlight
{
    public static void Run()
    {
        StoryElements.Flashlight();
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
            StoryElements.OpenDoor_flashlight();
            return "continue";
        }
        else if(player_choice == "ascend")
        {
            StoryElements.AscendStairs();
            return "continue";
        }
        else if (player_choice == "descend")
        {
            StoryElements.DescendStairs();
            return "continue";
        }
        else
        {
            return "error";
        }
    }
    
}