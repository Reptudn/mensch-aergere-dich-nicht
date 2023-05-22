using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpielerAuswahlHandler : MonoBehaviour
{

   public Dropdown dropdown;

   void Start()
   {
      dropdown.onValueChanged.AddListener((dropdown.value) =>
      {
         Debug.Log("Index: " + index);
         switch (index)
         {
            case 0:
            case 1:
            case 2:
            case 3:
               break;
         }
      });
   }
   
}
