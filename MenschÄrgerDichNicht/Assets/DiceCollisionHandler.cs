using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class DiceCollisionHandler : MonoBehaviour
{

    [SerializeField] private int number = -1;
    

    // Start is called before the first frame update
    void Start()
    {
        number = -1;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(rb.velocity == Vector3.zero) {
            Debug.Log("New Number: " + number);
            GameObject.Find("Dice Handler").SendMessage("SetDice6Number", number);
            //send message to dice handler to then make the move
        }
        */
    }

    void OnCollisionEnter(Collision collision){

        string name = collision.gameObject.name;
        //Debug.Log("Colliding: " + name);

        switch(name){

            case "1":
                number = 1;
                break;

            case "2":
                number = 2;
                break;

            case "3":
                number = 3;
                break;

            case "4":
                number = 4;
                break;

            case "5":
                number = 5;
                break;

            case "6":
                number = 6;
                break;

            default:
                //Debug.Log("Invalid Collision!");
                break;

        }

        Debug.Log("Number set");

    }

}
