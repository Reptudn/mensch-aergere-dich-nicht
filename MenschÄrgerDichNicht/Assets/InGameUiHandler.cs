using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUiHandler : MonoBehaviour
{

    public GameObject youRolled;

    // Start is called before the first frame update
    void Start()
    {
        youRolled.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRolledAmountText(int number){
        youRolled.GetComponent<Text>().text = "You rolled: " + number;
    }
}
