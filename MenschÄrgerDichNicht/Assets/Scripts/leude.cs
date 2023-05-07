using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leude : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            Vector3 pos = transform.position;
            pos.y += 1f;

            transform.position = pos;
        }
    }
}
