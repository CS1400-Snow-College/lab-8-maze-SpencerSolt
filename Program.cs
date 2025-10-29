// Spencer Solt, 10/28/25, Lab:8 Maze
Console.WriteLine("The goal is to move from the top left of the displayed maze to the goal '*' using the arrow keys.");

//Loads the contents of the file to be saved on a variable to be printed
string[] mapRows = File.ReadAllLines("C:/Users/spenc/Desktop/Labs/lab-8-maze-SpencerSolt/map.txt");

//Keeps the description of the program until the user is done reading
Console.Write("Press any key to continue ");
Console.ReadKey(true);

//Clears the screen then displays the maze
Console.Clear();
for (int i = 0; i < mapRows.Count(); i++)
    Console.WriteLine(mapRows[i]);

//Movement control method, the parameter stops the user from typing text
ConsoleKey TryMove(ConsoleKey button, int mazeHeight, int mazeLength)
{
    //Compares the user input to move the cursor in the correct direction
    if (button is ConsoleKey.DownArrow && Console.CursorTop < Console.BufferHeight && Console.CursorTop < mazeHeight)
        Console.CursorTop++;
    else if (button is ConsoleKey.UpArrow && Console.CursorTop > 0)
        Console.CursorTop--;
    else if (button is ConsoleKey.LeftArrow && Console.CursorLeft > 0)
        Console.CursorLeft--;
    else if (button is ConsoleKey.RightArrow && Console.CursorLeft < Console.BufferWidth && Console.CursorLeft < mazeLength)
        Console.CursorLeft++;
    //Returns the user input so the 'do-while' loop can check it
    return button;
}

//Puts the cursor in the correct starting position
Console.SetCursorPosition(0, 0);

//Enumerable so the while loop can check the user input for ConsoleKey.Escape
ConsoleKey key;

//Variables for maze height and width
int mazeBottom = mapRows.Count() - 1;
int mazeRight = mapRows[Console.CursorTop].Length - 1;

//Variable for the win to exit the loop
bool win = false;

//Loop to keep the program running until the escape key is pressed
do
{
    //Checks to see if the current cell contains '*' and changes the win condition to true if true
    if (mapRows[Console.CursorTop].Substring(Console.CursorLeft, 1).Contains("*"))
    {
        win = true;
        break;
    }
    key = TryMove(Console.ReadKey(true).Key, mazeBottom, mazeRight);
}
while (key != ConsoleKey.Escape || win == true);
//Clears the console when the loop ends and adds a congratulatory message if the win condition is true
Console.Clear();
if (win == true)
    Console.WriteLine("Congratulations on completing the maze!");