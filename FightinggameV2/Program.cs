using System.Security.AccessControl;
using System.Threading;

Character player1 = new();
Character player2 = new();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Welcome to Fighting Game 2.0!");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Player 1, choose your name:");
player1.name = Console.ReadLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Player 2, choose your name:");
player2.name = Console.ReadLine();
Console.Clear();

Console.WriteLine($"{player1.name} VS {player2.name}");
