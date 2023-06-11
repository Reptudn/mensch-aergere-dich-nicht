using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUiHandler : MonoBehaviour
{

    public GameObject youRolled;
    public GameObject rollDiceBtn;
    public GameObject kickOut;
    public GameObject illegalMove;

    // Start is called before the first frame update
    void Start()
    {
        youRolled.SetActive(false);
        illegalMove.SetActive(false);
        kickOut.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRolledAmountText(int number){
        youRolled.GetComponent<Text>().text = "You rolled: " + number;
    }

    public void NextPlayer() => ResetRoll();

    void ResetRoll(){
        youRolled.SetActive(false);
        rollDiceBtn.SetActive(true);
        youRolled.GetComponent<Text>().text = "You rolled: ...";
    }

    public void ShowKickOut(string kicker, string kickedOut){

        youRolled.SetActive(false);

        kickOut.GetComponent<Text>().text = kicker + " kicked out " + kickedOut; 

        kickOut.SetActive(true);
        StartCoroutine(Wait());
        kickOut.SetActive(false);

    }

    public void ShowIllegalMove(){

        youRolled.SetActive(false);

        illegalMove.SetActive(true);
        StartCoroutine(Wait());
        illegalMove.SetActive(false);

        youRolled.SetActive(true);

    }


    IEnumerator Wait(){
        yield return new WaitForSeconds(0.3f);
    }
}
