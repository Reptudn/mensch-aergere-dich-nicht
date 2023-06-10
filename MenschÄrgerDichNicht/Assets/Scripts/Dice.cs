using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DiceType {

    Normal = 6,

}

[RequireComponent(typeof(BoxCollider))]
public class Dice : MonoBehaviour, IInteractable
{

    [Header("This script needs to be either attachted to the playing field or")]
    [Header("have it's box collider as the ground plane")]
    [Header("(or same height with ground plane)")]

    [Space]
    [Space]
    [Space]

    public GameObject ui;
    public DiceType type = DiceType.Normal;

    public GameObject normal; //six sides
  
    private bool canBeThrown = true;

    [SerializeField] int number = -1;

    Rigidbody rb;
    GameObject dice;

    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<BoxCollider>().isTrigger = true;

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("Number: " + number);

        if(!canBeThrown) return;

        if(Input.GetKeyDown(KeyCode.Space)){
            Throw();
            canBeThrown = false;
        }

    }

    public void SetDice6Number(int number) => this.number = number;

    public void Throw(){

        Vector3 dicePos = new Vector3(0f, 10f, 0f);
        GameObject _dice = Instantiate(normal) as GameObject;
        dice = _dice;
        _dice.transform.position = dicePos;
        _dice.transform.rotation = new Quaternion(Random.Range(0,359), Random.Range(0,359), Random.Range(0,359), Random.Range(0,359));
        
        rb = _dice.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0f, Random.Range(5f, 10f), 0f), ForceMode.Impulse);
        rb.AddTorque(transform.up * 10);
        rb.AddTorque(transform.forward * 7);

    }


    public void OnHoverEnter(){
        
    }

    public void OnHoverExit(){
        
    }

    public void OnLeftClick(){
        
    }

    public void OnRightClick(){

    }

    void OnTriggerStay(Collider collider){

        if(rb.velocity != Vector3.zero) return;

        switch(collider.gameObject.name){

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
                Debug.Log("Invalid Collision!");
                break;

        }

        ui.GetComponent<InGameUiHandler>().SetRolledAmountText(number);
        RemoveDice();

    }

    IEnumerator RemoveDice(){
        yield return new WaitForSecondsRealtime(0.3f);

        rb = null;
        Destroy(dice);
    }

}
