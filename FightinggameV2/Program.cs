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
player1.Name = Console.ReadLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Player 2, choose your name:");
player2.Name = Console.ReadLine();
Console.Clear();

Console.WriteLine($"{player1.Name} VS {player2.Name}");
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
Thread.Sleep(1000);


while (player1.Health > 0 && player2.Health > 0)
{
    player1.weapon.damage = 10;
    player2.weapon.damage = 10;
    player1.weapon.accuracy = rdm.Next(0, 9);
    player2.weapon.accuracy = rdm.Next(0, 9);
    player1.weapon.critChance = rdm.Next(0, 9);
    player2.weapon.critChance = rdm.Next(0, 9);
    critDmg = rdm.Next(player1.weapon.minCrit, player1.weapon.maxCrit);

    if (player1.weapon.accuracy <= 7)
    {
        if (player1.weapon.critChance <= 4)
        {
            critDmg *= player1.weapon.damage;
            critDmg /= 10;
            player1.weapon.damage += critDmg;
        }
        else { player1.weapon.damage = 10; }

        Console.WriteLine($"{player1.Name} dealt {player1.weapon.damage} damage to {player2.Name}");
    }
    else
    {
        player1.weapon.damage = 0;
        Console.WriteLine($"{player1.Name} missed!");
    }

    if (player2.weapon.accuracy <= 7)
    {
        if (player2.weapon.critChance <= 4)
        {
            critDmg *= player2.weapon.damage;
            critDmg /= 10;
            player2.weapon.damage += critDmg;
        }
        else { player2.weapon.damage = 10; }

        Console.WriteLine($"{player2.Name} dealt {player2.weapon.damage} damage to {player1.Name}");
    }
    else
    {
        player2.weapon.damage = 0;
        Console.WriteLine($"{player2.Name} missed!");
    }

    player1.Health -= player2.weapon.damage;
    player2.Health -= player1.weapon.damage;

    Console.WriteLine();
    Console.WriteLine($"{player1.Name}'s HP: {player1.Health}");
    Console.WriteLine($"{player2.Name}'s HP: {player2.Health}");
    Console.WriteLine();
    Console.WriteLine();

    Thread.Sleep(3000);
}

if (player1.Health == 0 && player2.Health > 0)
{
    Console.WriteLine($"{player2.Name} wins!");
}
else if (player2.Health == 0 && player1.Health > 0)
{
    Console.WriteLine($"{player1.Name} wins!");
}
else
{
    Console.WriteLine("It's a draw!");
}


Console.ReadLine();