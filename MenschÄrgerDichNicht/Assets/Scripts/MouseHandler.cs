using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHandler : MonoBehaviour
{

    public bool inMenu = false;

    void Update()
    {

        if(!inMenu) InGame();

    }

    GameObject lastHit = null;
    GameObject lastHoverExit = null;
    private void InGame(){

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit hit, 100f)){

            //if(lastHit != null && hit.transform.gameObject != lastHit) Debug.Log("Ray hit: " + lastHit.name);

            lastHit = hit.transform.gameObject;

            if(Input.GetMouseButton(0)) hit.transform.gameObject.BroadcastMessage("OnLeftClick"); //left mouse btn
            else if(Input.GetMouseButton(1)) hit.transform.gameObject.SendMessage("OnRightClick"); //right mouse btn
            else try { hit.transform.gameObject.SendMessage("OnHoverEnter"); } catch { return; } //mouse hover

        } else {

            if(lastHit != null){ 
                try {
                    if(lastHoverExit != null && lastHoverExit != lastHit) lastHit.SendMessage("OnHoverExit");
                    lastHoverExit = lastHit;
                } catch {
                    return;
                }
            }
        }

    }


}
