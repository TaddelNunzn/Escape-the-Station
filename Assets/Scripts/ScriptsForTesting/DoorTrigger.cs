using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
public GameObject Door;
    public bool isOpen;

    void Update () {
        if (isOpen == true) {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 800);
            //if the bool is true open the door
            
        }
        if (Door.transform.position.y > 30f) {
            isOpen = false;
            //if the y of the door is > than 7 we want to stop the door
        }
    }
    void OnMouseDown(){ //THIS FUNCTION WILL DETECT THE MOUSE CLICK ON A COLLIDER,IN OUR CASE WILL DETECT THE CLICK ON THE BUTTON

        isOpen = true;
        //if we click on the button door we must start to open
    }
}
