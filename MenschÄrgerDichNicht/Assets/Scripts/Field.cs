using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FieldType {

    NORMAL = 0, //safe
    TELEPORT = 1,
    ROLL_AGAIN = 2, 
    INSTA_DEAD = 3,
    SLOTS = 4,
    X_FIELDS_BACK = 5,
    SAFE = 6

}

public class Field : MonoBehaviour
{

    public FieldType type = FieldType.NORMAL;
    public GameObject figure = null;
    public bool canBeSpecialField = true;


}
