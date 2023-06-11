using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingField : MonoBehaviour
{

    [Header("Game Settings")]
    public int specialFields = 0;

    [Header("SetUp")]
    public static GameObject[] field; //40 felder: feld 0 ist  release-feld bei grün
    public GameObject[] _field;
    public static GameObject[] greenSpawn;
    public static GameObject[] blueSpawn;
    public static GameObject[] redSpawn;
    public static GameObject[] yellowSpawn;

    public GameObject[] _greenSpawn;
    public GameObject[] _blueSpawn;
    public GameObject[] _redSpawn;
    public GameObject[] _yellowSpawn;

    public GameObject figurePrefab;

    // Start is called before the first frame update
    void Start()
    {
        greenSpawn = _greenSpawn;
        blueSpawn = _blueSpawn;
        redSpawn = _redSpawn;
        yellowSpawn = _yellowSpawn;
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

            Instantiate(figurePrefab, new Vector3(_greenSpawn[i].transform.position.x, _greenSpawn[i].transform.position.y, _greenSpawn[i].transform.position.z), _greenSpawn[i].transform.rotation).SendMessage("SetTeam", Team.GREEN);
            Instantiate(figurePrefab, new Vector3(_blueSpawn[i].transform.position.x, _blueSpawn[i].transform.position.y, _blueSpawn[i].transform.position.z), _blueSpawn[i].transform.rotation).SendMessage("SetTeam", Team.BLUE);
            Instantiate(figurePrefab, new Vector3(_redSpawn[i].transform.position.x, _redSpawn[i].transform.position.y, _redSpawn[i].transform.position.z), _redSpawn[i].transform.rotation).SendMessage("SetTeam", Team.RED);
            Instantiate(figurePrefab, new Vector3(_yellowSpawn[i].transform.position.x, _yellowSpawn[i].transform.position.y, _yellowSpawn[i].transform.position.z), _yellowSpawn[i].transform.rotation).SendMessage("SetTeam", Team.YELLOW);

        }

        GenerateFields();

    }

    void GenerateFields(){

        //int i = 0;

        /*
        while(i < specialFields){

            Field o = _field[Random.Range(0, field.Length - 1)].GetComponent<Field>();
            if(o.type == FieldType.NORMAL && o.canBeSpecialField){
                
                //nochmal random wenn mehr als ein special Field
                o.type = FieldType.SAFE;
                Debug.Log("Field assigned to: " + i);
                i++;

            }

        }
        */

        field = _field;

    }

}
