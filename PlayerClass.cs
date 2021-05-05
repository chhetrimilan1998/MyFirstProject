using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass{
    public float health = 100f;
    public string name = "wizard";

    // constructor
    public PlayerClass()
    {

    }
    public PlayerClass(float health, string name)
    {
        this.name = name;
        this.health = health;
    }
    public void Playerinfo()
    {
        Debug.Log("player health is " + health + " and player name is " + name);
    }
    
}
