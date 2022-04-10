using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Player
{
    public string playername;
    public int offense;
    public int defense;
    public int location;
    

    public Player(string _playername, int _offense, int _defense,int _location)
    {
        System.Random randomsayi = new System.Random();
        playername = _playername;
        offense = _offense;
        defense = _defense;
        location = _location;
     
    }

    public void Attack(Player defenseplayer)
    {
        if (offense >= defenseplayer.defense)
        {
            Debug.Log(playername + " çalýmlýyor...");
            
        }
        else
        {
            Debug.Log(defenseplayer.playername + " topu çaldý...");
        }
    }
}

public class deneme : MonoBehaviour
{

    

    public static void Mac()
    {
        var randomsayi = new System.Random();
        List<Player> redteam = new List<Player>();
        List<Player> blueteam = new List<Player>();
        Player melih = new Player("melih", randomsayi.Next(1, 20), randomsayi.Next(1, 20), randomsayi.Next(1, 10));
        Player yusuf = new Player("yusuf", randomsayi.Next(1, 20), randomsayi.Next(1, 20), randomsayi.Next(1, 10));
        redteam.Add(melih);
        blueteam.Add(yusuf);
     
        int gamelegth = 0;
        bool attacking = true;
        while (gamelegth <10)
        {
            if (attacking)
            {
                Debug.Log("Redteam saldýrýyor");
                redteam[0].Attack(blueteam[0]);
                attacking = false;

            }
            else if(!attacking)
            {
                Debug.Log("blueteam saldýrýyor");
                blueteam[0].Attack(redteam[0]);
                attacking = true;
            }

        }

        
    }

    void Start()
    {
        
        
    }

 
    void FixedUpdate()
    {
        Mac();
    }
}
