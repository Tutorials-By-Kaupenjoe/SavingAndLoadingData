using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public string name;
    public float health;
    public float mana;
    public int level;

    public PlayerData(string name, float health, float mana, int level)
    {
        this.name = name;
        this.health = health;
        this.mana = mana;
        this.level = level;
    }

    public override string ToString()
    {
        return $"{name} is at {health} HP with {mana} Mana. They have reached level {level}";
    }
}
