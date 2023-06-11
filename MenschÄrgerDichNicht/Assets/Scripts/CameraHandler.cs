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

    public void NextPlayer(Team team){

        int index = -1;

        switch(team){

            case Team.RED:
                index = 2;
                break;
            case Team.GREEN:
                index = 1;
                break;
            case Team.YELLOW:
                index = 3;
                break;
            case Team.BLUE:
                index = 0;
                break;

        }

        cam.transform.position = cameraPositions[index].position;
        cam.transform.rotation = cameraPositions[index].rotation;
    }
    
    void LerpCam(){
        //test
    }
}
