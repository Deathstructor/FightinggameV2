using System.Threading;

Character player1 = new();
Character player2 = new();


Random rdm = new();

int critDmg;

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
Console.WriteLine();
Console.WriteLine();
Thread.Sleep(2000);
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("3...");
Console.WriteLine();
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("2...");
Console.WriteLine();
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("1...");
Console.WriteLine();
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("FIGHT!");
Console.WriteLine();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.White;


while(player1.health >= 0  && player2.health >= 0)
{
    player1.weapon.accuracy = rdm.Next(0, 9);

    if (player1.weapon.accuracy <= 7)
    {
        player1.weapon.damage *= ;
        Console.WriteLine(player1.weapon.damage);
        Thread.Sleep(3000);
    }
}







Console.ReadLine();