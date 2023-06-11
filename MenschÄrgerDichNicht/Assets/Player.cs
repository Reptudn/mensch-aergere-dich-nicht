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

    public int onField = 0;

    public Player(string playerName, Team teamColor, Sprite playerLogo, bool isAI = false){
        this.teamColor = teamColor;
        this.playerName = playerName;
        this.playerLogo = playerLogo;
        this.isAI = isAI;
    }
    
    private bool canMove = false;
    public void Move(GameObject obj, int amount){

        //if(!canMove) return;

        moveCount++;
        canMove = false;
    }

    public void AiMove(int amount, int[] selfFigureIndexes, GameObject[] allFigures){

        if(!canMove) return;

        moveCount++;

    }

    public void CanMove(){
        
        canMove = true;
    }


    private int throwCount = 0;
    public bool isDone(){

        if(moveCount == 0 || onField == 0){

            throwCount++;
            return false;

        }

        return true;
    }

}
