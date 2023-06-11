using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFigure : MonoBehaviour, IInteractable
{

    [SerializeField] Team team = Team.UNSIGNED;
    public int selfIndex = -1;

    private Game game;
    private InGameUiHandler ui;

    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("Game").GetComponent<Game>();
        ui   = GameObject.Find("UI").GetComponent<InGameUiHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnHoverEnter(){
        //transform.localPosition += Vector3.up;
    }

    public void OnHoverExit(){
        //transform.localPosition += Vector3.down;
    }


    bool run = false;
    public void OnLeftClick(){

        if(run) return;
        run = true;

        int amount = Dice.number;
        //Debug.Log("old index " + selfIndex);

        //Debug.Log("current team " + (Team)Game.currentPlayerIndex);
        if(this.team != (Team)Game.currentPlayerIndex || amount == -1) return;
        //Debug.Log("Move");

        if(selfIndex == -1){

            switch(team){

                case Team.RED:
                    selfIndex = 10;
                    CheckMove(selfIndex);
                    PlayingField.field[selfIndex].GetComponent<Field>().figure = transform.gameObject;
                    transform.position = PlayingField.field[selfIndex].transform.position;
                    break;

                case Team.GREEN:
                    selfIndex = 0;
                    CheckMove(selfIndex);
                    PlayingField.field[selfIndex].GetComponent<Field>().figure = transform.gameObject;
                    transform.position = PlayingField.field[selfIndex].transform.position;
                    break;

                case Team.YELLOW:
                    selfIndex = 20;
                    CheckMove(selfIndex);
                    PlayingField.field[selfIndex].GetComponent<Field>().figure = transform.gameObject;
                    transform.position = PlayingField.field[selfIndex].transform.position;
                    break;

                case Team.BLUE:
                    selfIndex = 30;
                    CheckMove(selfIndex);
                    Debug.Log(PlayingField.field[selfIndex].GetComponent<Field>().figure);
                    PlayingField.field[selfIndex].GetComponent<Field>().figure = transform.gameObject;
                    transform.position = PlayingField.field[selfIndex].transform.position;
                    break;

            }

        } else {
 
            int newIndex = selfIndex + amount;
            if(newIndex > 40) newIndex -= 40;

            CheckMove(newIndex);

            PlayingField.field[selfIndex].GetComponent<Field>().figure = null;
            PlayingField.field[newIndex].GetComponent<Field>().figure = transform.gameObject;
            transform.position = PlayingField.field[newIndex].transform.position;

            selfIndex = newIndex;

        }

        Debug.Log("New Index " + selfIndex);
        StartCoroutine(Wait());

    }

    public void OnRightClick(){

    }

    public void SetTeam(Team teamColor){ //called when object is instantiated
        team = teamColor;
        string name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(teamColor.ToString().ToLower());
        transform.gameObject.tag = name;

        var c = GetComponent<Renderer>().material;

        switch(name){

            case "Red":
                c.color = Color.red;
                break;

            case "Blue":
                c.color = Color.blue;
                break;

            case "Green":
                c.color = Color.green;
                break;

            case "Yellow":
                c.color = Color.yellow;
                break;

        }
    } 

    IEnumerator Wait(){
        yield return new WaitForSeconds(1f);
        game.NextPlayer();
        run = false;
    }

    public void KickOut(){

        GameObject[] spawn = PlayingField.greenSpawn;

        switch(team){

            case Team.RED:
                spawn = PlayingField.redSpawn;
                break;

            case Team.BLUE:
                spawn = PlayingField.blueSpawn;
                break;

            case Team.YELLOW:
                spawn = PlayingField.yellowSpawn;
                break;

            case Team.GREEN:
                spawn = PlayingField.greenSpawn;
                break;

        }

        foreach(var a in spawn){
            if(a.transform.childCount == 0){
                transform.position = a.transform.position;
                break;
            }
        }

    }

    void CheckMove(int newIndex){

        var newField = PlayingField.field[newIndex].GetComponent<Field>();

        if(newField.figure == null) return; //field empty

        if(newField.figure.GetComponent<GameFigure>().team == team){

            //same team
            //show cannot move
            ui.ShowIllegalMove();

        } else {

            //other team
            //kick out other figure
            var otherFigure = newField.figure.GetComponent<GameFigure>();
            otherFigure.KickOut();

            ui.ShowKickOut(team.ToString(), otherFigure.team.ToString());
            
        }

    }
}
