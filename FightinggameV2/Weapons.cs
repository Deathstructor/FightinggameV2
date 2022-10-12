using System;

public class Weapons
{
    public string name { get; private set; }
    public int damage { get; set; }
    public int accuracy { get; set; }
    public int critChance { get; set; }
    public int minCrit { get; private set; }
    public int maxCrit { get; private set; }

    public Weapons()
    {
        name = "Sword";
        damage = 10;
        minCrit = 1;
        maxCrit = 10;
    }
}