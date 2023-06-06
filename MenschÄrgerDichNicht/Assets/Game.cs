using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public Player[] players = new Player[4];
    
    [Range(1,4)]
    int playerCount = 1;
    int currentPlayerIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        players = new Player[playerCount];
        for(int i = 0; i < playerCount; i++){
            players[i] = new Player("test", (Team)i, null, Color.red, false);
        }
        for(int i = 0; i < players.Length; i++){
            if(players[i] == null) players[i] = new Player("test", (Team)i, null, Color.blue, true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NextPlayer(){
        currentPlayerIndex++;
        if(currentPlayerIndex > players.Length) playerCount = 0;
        players[currentPlayerIndex].CanMove();
    }
}
