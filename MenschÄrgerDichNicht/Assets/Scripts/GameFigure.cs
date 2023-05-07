using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFigure : MonoBehaviour, IInteractable
{

    [SerializeField] Team team = Team.UNSIGNED;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnHoverEnter(){
        transform.localPosition += Vector3.up;
    }

    public void OnHoverExit(){
        transform.localPosition += Vector3.down;
    }

    public void OnLeftClick(){

    }

    public void OnRightClick(){

    }

    public void SetTeam(Team teamColor){ //called when object is instantiated
        team = teamColor;
        string name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(teamColor.ToString().ToLower());
        transform.gameObject.tag = name;

    } 
}
