using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public Player[] players = new Player[4];
    private CameraHandler cameraScript;

    public GameObject ui;
    
    [Range(1,4)]
    int playerCount = 1;
    public static int currentPlayerIndex = 1;

    // Start is called before the first frame update
    void Start()
    {

        cameraScript = GetComponent<CameraHandler>();

        Debug.Log("Player len: " + players.Length);

        players = new Player[playerCount];
        for(int i = 0; i < playerCount; i++){
            players[i] = new Player("test", (Team)i, null, false);
        }
        for(int i = 0; i < players.Length; i++){
            if(players[i] == null) players[i] = new Player("test", (Team)i, null, true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.LeftArrow)) NextPlayer();
    }

    public void NextPlayer(){

        currentPlayerIndex++;
        if(currentPlayerIndex > 4) currentPlayerIndex = 1;
        cameraScript.NextPlayer((Team)currentPlayerIndex);
        ui.SendMessage("NextPlayer");
        //players[currentPlayerIndex].CanMove();

    }
}
