using System;

public class Character
{
    public string? Name { get; set; }
    int hp = 100;

    public Weapons weapon = new();

    public int Health
    {
        get
        {
            return hp;
        }
        set
        {
            hp = Math.Max(value, 0);
        }
    }
}