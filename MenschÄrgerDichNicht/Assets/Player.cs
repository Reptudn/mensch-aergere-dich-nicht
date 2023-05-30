using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{

    public Team teamColor = Team.UNSIGNED;
    public string playerName;
    public Sprite playerLogo;

    public int moveCount = 0;
    public GameObject playingField;
    public bool isAI;

    public Color color;

    public Player(string playerName, Team teamColor, Sprite playerLogo, Color color, bool isAI = false){
        this.teamColor = teamColor;
        this.playerName = playerName;
        this.playerLogo = playerLogo;
        this.isAI = isAI;
        this.color = color;
    }
    
    private bool canMove = false;
    public void Move(GameObject obj, int amount){
        moveCount++;
        canMove = false;
    }

    public void CanMove(){
        canMove = true;
    }

}
