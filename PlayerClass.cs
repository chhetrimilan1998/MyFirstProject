using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass{
    public float health = 100f;
    public string name = "wizaed";
    public void Playerinfo()
    {
        Debug.Log("player health is " + health + " and player name is" + name);
    }
    
}
