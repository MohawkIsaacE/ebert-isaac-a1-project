// Game Development Foundations
// Assignment 1: Interactive Terminal Project
// Isaac Ebert

// Variables
bool hasSword = false;
bool hasRedGem = false;
bool hasOrangeGem = false;
bool hasYelloGem = false;
bool hasGreenGem = false;
bool hasBlueGem = false;
bool hasPurpleGem = false;
int currency = 0;

// Title screen and controls display
Console.WriteLine("Controls: Type the number of the option you want to choose, then press enter.");
Console.WriteLine("1. Play\n2. Quit");

int initialOption = int.Parse(Console.ReadLine());
if (initialOption == 2)
{
    Console.WriteLine("You decide not to play.");
}
else
{
    Console.WriteLine("Ooption1");
}