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
Thread.Sleep(1000);


while(player1.health > 0  && player2.health > 0)
{
    player1.weapon.damage = 10;
    player2.weapon.damage = 10;
    player1.weapon.accuracy = rdm.Next(0, 9);
    player1.weapon.critChance = rdm.Next(0, 9);
    critDmg = rdm.Next(player1.weapon.minCrit, player1.weapon.maxCrit);

    if (player1.weapon.accuracy <= 7)
    {
        if (player1.weapon.critChance <= 1)
        {
            critDmg *= player1.weapon.damage;
            critDmg /= 10;
            player1.weapon.damage += critDmg;
        }
        else { player1.weapon.damage = 10; }
    }

    if (player2.weapon.accuracy <= 7)
    {
        if (player2.weapon.critChance <= 1)
        {
            critDmg *= player2.weapon.damage;
            critDmg /= 10;
            player2.weapon.damage += critDmg;
        }
        else { player2.weapon.damage = 10; }
    }



    player1.health -= player2.weapon.damage;
    player2.health -= player1.weapon.damage;

    if (player1.health < 0) { player1.health = 0; }
    if (player2.health < 0) { player2.health = 0; }


    Console.WriteLine($"{player1.name} dealt {player1.weapon.damage} damage to {player2.name}");
    Console.WriteLine($"{player2.name} dealt {player2.weapon.damage} damage to {player1.name}");
    Console.WriteLine();
    Console.WriteLine($"{player1.name}'s HP: {player1.health}");
    Console.WriteLine($"{player2.name}'s HP: {player2.health}");
    Console.WriteLine();
    Console.WriteLine();

    Thread.Sleep(3000);
}

if (player1.health == 0)
{
    Console.WriteLine($"{player2.name} wins!");
}
if (player2.health == 0)
{
    Console.WriteLine($"{player1.name} wins!");
}

Console.ReadLine();