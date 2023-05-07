using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingField : MonoBehaviour
{

    public GameObject[] field; //40 felder: feld 0 ist  release-feld bei grün
    public GameObject[] greenSpawn;
    public GameObject[] blueSpawn;
    public GameObject[] redSpawn;
    public GameObject[] yellowSpawn;

    public GameObject figurePrefab;

    // Start is called before the first frame update
    void Start()
    {
        GamefieldSetup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GamefieldSetup(){

        int teamCount = typeof(Team).GetFields().Length;

        for(int i = 0; i < 4; i++){

            //for(int t = 0; t < teamCount; t++){}; //für später falls mehr als 4 teams

            Instantiate(figurePrefab, new Vector3(greenSpawn[i].transform.position.x, greenSpawn[i].transform.position.y, greenSpawn[i].transform.position.z), greenSpawn[i].transform.rotation).SendMessage("SetTeam", Team.GREEN);
            Instantiate(figurePrefab, new Vector3(blueSpawn[i].transform.position.x, blueSpawn[i].transform.position.y, blueSpawn[i].transform.position.z), blueSpawn[i].transform.rotation).SendMessage("SetTeam", Team.BLUE);
            Instantiate(figurePrefab, new Vector3(redSpawn[i].transform.position.x, redSpawn[i].transform.position.y, redSpawn[i].transform.position.z), redSpawn[i].transform.rotation).SendMessage("SetTeam", Team.RED);
            Instantiate(figurePrefab, new Vector3(yellowSpawn[i].transform.position.x, yellowSpawn[i].transform.position.y, yellowSpawn[i].transform.position.z), yellowSpawn[i].transform.rotation).SendMessage("SetTeam", Team.YELLOW);

        }

    }

}
