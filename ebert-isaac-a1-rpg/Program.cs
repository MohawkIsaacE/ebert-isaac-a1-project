﻿// Game Development Foundations
// Assignment 1: Interactive Terminal Project
// Isaac Ebert

// Variables
bool willDoFavour = false;
bool hasSword = false;
int amountOfGems = 0;
bool isWizardHappy = true;

// Title screen and controls display
Console.WriteLine("  _____   _____    _____ ");
Console.WriteLine(" |  __ \\ |  __ \\  / ____|");
Console.WriteLine(" | |__) || |__) || |  __ ");
Console.WriteLine(" |  _  / |  ___/ | | |_ |");
Console.WriteLine(" | | \\ \\ | |     | |__| |");
Console.WriteLine(" |_|  \\_\\|_|      \\_____|\n");
Console.WriteLine("Controls: Type the number of the option you want to choose, then press enter.");
Console.WriteLine("1. Play\n2. Quit");

// Ask if the user wants to play the game
int initialOption = int.Parse(Console.ReadLine());
if (initialOption == 2)
{
    Console.WriteLine("You decide not to play.");
}
else
{
    // Opening dialogue
    Console.WriteLine("You awake to an unfamiliar voice,");
    Console.WriteLine("Wizard: Hey you, you're finally awake. You were trying to find the 6 gems, right?");
    Console.WriteLine("Wizard: I can give you a hint for your adventure, but you'll have to do me a favour.");
    Console.WriteLine("1. Accept hint\n2. Refuse hint");
    if (int.Parse(Console.ReadLine()) == 1)
    {
        Console.WriteLine("Wizard: Excellent. There's a gem hidden atop the tallest tree in the forest.\nWizard: All I ask for is that you don't harm anything in the forest.");
    }
    else
    {
        Console.WriteLine("You refuse the wizard's hint.\nWizard:''Alright then, you're on your own.''");
    }

    // Choice 1
    Console.WriteLine("You leave the wizard and begin your adventure into the forest. You stumble upon a berry bush.");
    Console.WriteLine("1. Eat some berries\n2. Dig up the plant\n3. Continue walking");
    int choice1 = int.Parse(Console.ReadLine());
    if (choice1 == 1)
    {
        Console.WriteLine("You begin picking berries. An oddly shaped berry shines bright in the light. It's a gem! You pick it up.");
        amountOfGems++;
        Console.WriteLine($"You now have {amountOfGems} gem(s).");
    }
    else if (choice1 == 2)
    {
        Console.WriteLine("You choose to dig up the plant. You hear a disappointed sigh in the distance.");
        isWizardHappy = false;
    }
    else
    {
        Console.WriteLine("You choose to continue walking.");
    }

    // Choice 2

    // Choice 3

    // Choice 4

    // Choice 5
    Console.WriteLine("You come across a lake. There is a large stone with a sword hilt poking out.");
    Console.WriteLine("1. Go for a swim\n2. Pull the sword out of the stone\n3. Continue walking");
    int choice5 = int.Parse(Console.ReadLine());
    if (choice5 == 1)
    {
        Console.WriteLine("You decide to go for a short swim.\nYou feel refreshed and continue your journey.");
    }
    else if (choice5 == 2)
    {
        // The wizard will help you pull the sword out if you've followed his request (kept him happy)
        Console.WriteLine("You attempt to pull the sword out of the stone, but it's too deep to pull out.");
        Console.WriteLine("Suddenly, the wizard appears.");
        if (isWizardHappy)
        {
            Console.WriteLine("Wizard: I see you have completed my favour. For that, I will help you get the sword.");
            hasSword = true;
            Console.WriteLine("The wizard helps you get the sword.\nThere's a gem in the sword!");
            Console.WriteLine($"You now have {amountOfGems} gem(s).");
            Console.WriteLine("You thank the wizard and continue on.");
        }
        else
        {
            Console.WriteLine("Wizard: You did not adhear to my request, thus I will not help you free the sword.");
            Console.WriteLine("You leave in defeat.");
        }
    }
    else
    {
        Console.WriteLine("You choose to continue walking.");
    }

    // Choice 6

    // Ending based on how many gems were collected
    if (amountOfGems == 0)
    {
        Console.WriteLine("You went for a leisurely stroll.\nYou did not manage to collect any gems...\n(Bad ending)");
    }
    else if (amountOfGems < 6)
    {
        Console.WriteLine("Your adventure comes to an end.\nYou collected a gem or two. Nice job.\n(Decent ending)");
    }
    else
    {
        Console.WriteLine("Your thrilling adventure went perfectly!\nYou collected all 6 of the gems! Congratulations!\n(Best ending)");
    }

    Console.WriteLine("  _______ _            ______           _ ");
    Console.WriteLine(" |__   __| |          |  ____|         | |");
    Console.WriteLine("    | |  | |__   ___  | |__   _ __   __| |");
    Console.WriteLine("    | |  | '_ \\ / _ \\ |  __| | '_ \\ / _` |");
    Console.WriteLine("    | |  | | | |  __/ | |____| | | | (_| |");
    Console.WriteLine("    |_|  |_| |_|\\___| |______|_| |_|\\__,_|");
}