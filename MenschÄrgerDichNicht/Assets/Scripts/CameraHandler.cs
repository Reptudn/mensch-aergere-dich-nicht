using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{

    public Transform[] cameraPositions;
    public Camera cam;

    // Start is called before the first frame update
    void Start() 
    {
        cam.transform.position = cameraPositions[0].position;
        cam.transform.rotation = cameraPositions[0].rotation;
    }

    public void NextPlayer(int playerIndex){
        cam.transform.position = cameraPositions[playerIndex].position;
        cam.transform.rotation = cameraPositions[playerIndex].rotation;
    }
    
    void LerpCam(){
        //test
    }
}
