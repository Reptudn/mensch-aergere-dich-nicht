using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpielerAuswahlHandler : MonoBehaviour
{

public GameObject prefab; //des ist des ding mit dem name und so
   public TMP_Dropdown dropdown;

   public Game game;

   void Start()
   {
      dropdown.onValueChanged.AddListener(delegate
      {
         int index = dropdown.value;
         Debug.Log("Index: " + index);
         FarbAuswahl(index);
      });
   }



public GameObject[] playerThingies;
public void FarbAuswahl(int index)
{
  foreach(GameObject o in playerThingies) o.SetActive(false);
   for(int i = 0; i <= index; i++) playerThingies[i].SetActive(true);
  
}  
}
