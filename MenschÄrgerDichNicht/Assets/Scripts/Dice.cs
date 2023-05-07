using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DiceType {

    Normal = 6,
    MOREIDK = 8

}

public class Dice : MonoBehaviour, IInteractable
{

    public DiceType type = DiceType.Normal;

    public GameObject normal; //six sides
    public GameObject moreidk;

    // Start is called before the first frame update
    void Start()
    {
        if(type == DiceType.Normal) normal.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int Throw(){
        //for now just a random number from 1 to side count of dice
        return Random.Range(1, (int)type); 
    }

    public void OnHoverEnter(){
        transform.localPosition += Vector3.up;
    }

    public void OnHoverExit(){
        transform.localPosition += Vector3.down;
    }

    public void OnLeftClick(){
        int number = Throw();
    }

    public void OnRightClick(){

    }


}
