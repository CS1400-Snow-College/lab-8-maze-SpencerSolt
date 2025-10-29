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