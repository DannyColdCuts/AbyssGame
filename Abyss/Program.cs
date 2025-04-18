// Abyss. A game made in C# Bless This Mess
//'using System;' - Directive that tells the program to use the .NET system namespace
// System namespace contains fundamental classes that you will use like, console, string, etc.
// Without this you wouldnt be able to access basic things like Console.WriteLine()
using System;
using System.ComponentModel.Design;

namespace Abyss     //'namespace Abyss' - Declares a container for your code, known as a namespace
{                   // A namespace helps to organize your code and avoid naming conflicts between different parts
                    // Its like putting your classes into folders, making it easier to find and maintain them.
    class Program   //'class Program' - This defines a class called 'Program'
                    // A class is a blueprint for creating objects (in this case, your entire program).
    {               // The class contains methods and properties that define the behavior of the object

        //'static void Main(string[] args)' - Entry point of the program (the first method that runs when you start).
        // - 'static' means that this method belongs to the class itself, not an instance of the class.
        // So you dont need to create an object of 'Program' to run the main method, its called directly
        // - 'void' means that this method doesn't return any value. It's just performing actions, like displaying text or running logic.
        // - 'Main' is the name of the method that the program will start executing from.
        // - 'string[] args' is an array of arguments that the program can recieve from the command line when it is launched
        static void Main(string[] args) // Main method body will go here. This is where your game logic begins.
        {
            bool gameRunning = true; // This flag controls whether the game keeps running

            Console.WriteLine("Welcome to the Abyss... Please state your name...");
            string username = Console.ReadLine()!;
            
            while (gameRunning) //Main Menu Loop
            {
                Console.Clear(); //Clears the screen every loop iteration for a fresh look. Less text all over the screen when levels change
                //Game Introduction
                Console.WriteLine("Welcome to the Abyss");
                Console.WriteLine();
                Console.WriteLine("What kind of a world were you used to?");
                Console.WriteLine("Brimming with life and splendor? Or a world that only knows torment and surrender?");
                Console.WriteLine();
                Console.WriteLine("Your new abyss knows nothing of kindness.");
                Console.WriteLine("Your very bone, muscle, and sinew will ache, and pull between now and forever.");
                Console.WriteLine("Your mind will boil in agony as you attempt to rest.");
                Console.WriteLine("Your soul will seep through the cracks of this realm. Do not attempt to leave.");
                Console.WriteLine();
                Console.WriteLine("What can you see traveller?");
                //All the text your console window is going to display whenever the game is running through the welcome options
                Console.WriteLine("1. Nothing...");
                Console.WriteLine("2. Stars...");
                Console.WriteLine("3. Leave Abyss...");
                Console.WriteLine();
                Console.WriteLine("Choose!");
                //Listed are your options to choose with the number keys and enter

                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1": //If the player chooses PitchBlack

                        Console.Clear();
                        PitchBlack(); // Calls the Pitch Black method (new "level")
                        break;
                                            
                    case "2": // If the player chooses path 2 EyeSparkles

                        Console.Clear();
                        EyeSparkles(); // Calls the EyeSparkles method (new "level")
                        break;
                                            
                    case "3": //If the player chooses to quit the game

                        Console.Clear();
                        gameRunning = false; //End game loop
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You are leaving the dream world from the real world. They are still being tormented. Return to attempt to help");
                        Console.ReadKey(); // Wait for user to acknowledge exit
                        break;

                    default: //If the player enters a non-valid input
                        Console.WriteLine("Invalid choice! Please choose 1, 2, or 3");
                        Console.ReadKey();
                        break;

                }
            }
        }

        static void PitchBlack() // Method for the Pitch Black Level
        {
            bool inPitchBlack = true; //PitchBlack gameloop start - if false none of the level conditions apply (i.e. - return to other level and let that loop take over)

            while (inPitchBlack) // While inside pitchblack level statment
            {
                Console.WriteLine("Your eyes cannot fathom how much light is absent from your surroundings."); // Story intro
                Console.WriteLine(); // Blank line for spacing
                Console.WriteLine("As your eyes attempt to adjust, you start to see faint objects.");
                Console.WriteLine("Almost against your will, you sprint.");
                Console.WriteLine("A gold coin sits upon a marble pillar. Light spills above you in a beam.");
                Console.WriteLine("You hear a deafening blast behind you. The light flashes upon the landscape like a strobe. You see your abyss.");
                Console.WriteLine("You turn back to face the coin. There are 2 now...");
                Console.WriteLine();
                Console.WriteLine("'Choose' A harrowing voice bellows through the abyss");
                Console.WriteLine();
                Console.WriteLine("1. The Left Coin...");
                Console.WriteLine("2. The Right Coin...");
                Console.WriteLine("3. Go back to the void...");
                Console.Write("> "); // Console keeps cursor on the same line as this statement
                string pitchChoice = Console.ReadLine()!; // String (word) declared as (pitchChoice) it wants to be equal to console.ReadLine while inside of the level
                                                          // Any user input from switch will count as permissable
                switch (pitchChoice) //start of the level options (Declares pitchChoice string as the starting point for input recieving)
                {
                    case "1": // cleaner if/else statement (if the user presses #1 then send that data to console.ReadLine() as permissable data entry
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("It glimmers. Holding the left coin makes you feel as though you deserve to be in the abyss.");
                        Console.WriteLine("You stare and stare. Almost unable to give your attention to any of your absent surroundings.");
                        Console.WriteLine("You must break free...");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;

                    case "2": // cleaner if/else statement (if the user presses #2 then send that data to console.ReadLine() as permissable data entry
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("The right coin pulses. A soft melody plays in your head, but it is dissonant and wrong.");
                        Console.WriteLine("You drop the coin, but it clings to your skin like tar.");
                        Console.WriteLine("Something... sees you now.");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;

                    case "3": // cleaner if/else statement (if the user presses #3 then send that data to console.ReadLine() as permissable data entry
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You back away slowly, the abyss swallows the coins once more...");
                        inPitchBlack = false; // Exit this level
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That choice does not exist in this realm. Try again.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.ResetColor();
                        break;
                }
            }
        }
                
        static void EyeSparkles() //Method for the Seeing Stars Level
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You saw light just a second ago. You're brain eagerly is trying to put the image back. You only see dizzy stars."); // Story element for EyeSparkles
            Console.WriteLine("Any key = Go back");
            Console.ReadKey(); // Wait for a user to press a key before returning
            Console.ResetColor();



        }

        static void OilLake() //Method for the Lake Of Oil
        {



        }

    


    }
}

        