// Game Development Foundations
// Assignment 1: Interactive Terminal Project
// Isaac Ebert

// Variables
bool willDoFavour = false;
bool hasSword = false;
bool hasRedGem = false;
bool hasOrangeGem = false;
bool hasYelloGem = false;
bool hasGreenGem = false;
bool hasBlueGem = false;
bool hasPurpleGem = false;
int currency = 0;

// Title screen and controls display
Console.WriteLine("  _____   _____    _____ ");
Console.WriteLine(" |  __ \\ |  __ \\  / ____|");
Console.WriteLine(" | |__) || |__) || |  __ ");
Console.WriteLine(" |  _  / |  ___/ | | |_ |");
Console.WriteLine(" | | \\ \\ | |     | |__| |");
Console.WriteLine(" |_|  \\_\\|_|      \\_____|\n");
Console.WriteLine("Controls: Type the number of the option you want to choose, then press enter.");
Console.WriteLine("1. Play\n2. Quit");

// Determine if the user wants to play the game
int initialOption = int.Parse(Console.ReadLine());
if (initialOption == 2)
{
    Console.WriteLine("You decide not to play.");
}
else
{
    Console.WriteLine("You awake to an unfamiliar voice,");
    Console.WriteLine("Wizard: Hey you, you're finally awake. You were trying to find the 6 gems, right?");
    Console.WriteLine("Wizard: I can give you a hint for your adventure, but you'll have to do me a favour.");
    Console.WriteLine("1. Accept hint\n2. Refuse hint");
    if (Console.ReadLine() == 1) 
    { 
        willDoFavour = true;
        Console.WriteLine("Wizard: Excellent. There's a gem hidden atop the tallest tree in the forest.\nWizard: All I ask for is that you don't harm anything in the forest.");
    }
    else
    {
        Console.WriteLine("You refuse the wizard's hint.\nWizard:''Alright then, you're on your own.''");
    }

    // Ask where the player wants to go
}