using System;

public class StoryElements
{
    public static void Flashlight()
    {
        Console.Clear();
        Console.WriteLine("\nYou click on the flashlight and it illumiates a ray of light in front of you.\n" +
                          "Immediatly you are stricken wtih fear as you are stairing face to face with a rotting skeleton corpse.\n" +
                          "You stumble backwards trying to catch your breath.\n" +
                          "Once you gain your composure back, you take a quick scan of the room you are in.\n" +
                          "There is a door and two staircases.\n" +
                          "One staircase is ascending and you can see a faint light at the top, while the other one is descending into a dark nothingness.\n\n" +
                          "Do you OPEN the door, ASCEND the staircase, or DESCEND into the infinite darkness?\n");
    }

    public static void Matches()
    {
        Console.Clear();
        Console.WriteLine("You strike a match and it illuminates a small area around you.\n" +
                          "The light is quickly fading, and you can barely make anything out.\n" +
                          "Before the light goes out you were able to spot what appeared to be a door and maybe a hallway.\n\n" +
                          "Do you Open the door or FOLLOW the hallway?\n");
    }

    public static void OpenDoor_flashlight()
    {
        Console.Clear();
        Console.WriteLine("You open the door and shine your flashlight in the room.\n" +
                            "You see a large statue in the back of the room holding a chest.\n" +
                            "Suddenly a blade comes flying through the ceiling and barely misses you.\n" +
                            "Looks like the room is booby trapped to protect the chest, lucky for you, you had a flashlight to see all the traps.\n" +
                            "With careful timing and some more luck you manage to make it to the chest and open it.\n" +
                            "Inside is a bunch of gold and a note that reads 'Mark its time to get up, you're going to be late for school.'\n\n" +
                            "You secured the treasure and made it to school on time!!!!");
    }

    public static void OpenDoor_matches()
    {
        Console.Clear();
        Console.WriteLine("You open the door and walk through, you still can't see anything but you hear something moving around.\n" +
                          "You try and make out the sound, it seems to be steel gliding across stone.\n" +
                          "It suddenly stops, but not before creating a spark that breifly illuminated the monster in front of you.\n" +
                          "You could only make out its silhouette, but its big and coming your way.\n" +
                          "You go to reach for the door behind you, but just as your hand touches the doorknob you feel a warm sensation and your life leaves your body.\n\n" +
                          "YOU DIED!!!!");
    }

    public static void Hallway()
    {
        Console.Clear();
        Console.WriteLine("Still unable to see, you use your hands and the walls of the crypt to guide you as you proceed down what appeared to be a hallway.\n" +
                          "You take it slowly to avoid tripping and losing your sense of direction.\n" +
                          "You feel like you've been walking for hours when suddenly theres a gap in the stones and you stop for a moment.\n" +
                          "Not knowing if you have reached another chamber in the crypt you suddenly feel a blade slice through your hands.\n" +
                          "You jolt awake in a hot sweat.\n\n" +
                          "It was all just a nightmare!");
    }

    public static void AscendStairs()
    {
        Console.Clear();
        Console.WriteLine("You ascend up the staircase, you see a faint light ahead of you.\n" +
                          "As you get closer to what you think is the top, you start to smell the fresh scent of flowers and you feel a warm breeze.\n" +
                          "You suddenly find yourself outside, the sun is bright and you are greeted by a group of people who look relieved to see you.\n" +
                          "They guide you to a wagon and a kind lady checks your state to make sure you aren't hurt.\n" +
                          "Turns out you were the lost son of the king and a search party had been looking for you.\n" +
                          "You return home with the search party and you live happily ever after.\n\n" +
                          "You've been saved!");
    }

    public static void DescendStairs()
    {
        Console.Clear();
        Console.WriteLine("You start to descend down the staircase and feel a cold shiver creep down your spine.\n" +
                          "You feel the darkness thicken as you get closer to what you think is the bottom.\n" +
                          "Your flashlight starts to flicker and suddenly it goes out.\n" +
                          "You feel the darkness wrap around you and you sink into dispair.\n\n" +
                          "You have been consumed by the darkness!");
    }

    public static void DisplayStart()
    {
        Console.Clear();
        Console.WriteLine("\nWelcome to The Darkness Adventure Game!\n");
        Console.WriteLine("You awaken in a dark crypt full of webs and bones.\n" +
                          "You don't recall anything, but your head is pounding in pain.\n" +
                          "It's pitch black and after fiddling in your pockets you find a FLASHLIGHT and a box of MATCHES.\n\n" +
                          "Which item do you want to use?\n");
        
    }

    public static void DisplayEnd()
    {
        Console.WriteLine("Thank you for playing\nWould you like to play again? (Y/N)");
    }
}