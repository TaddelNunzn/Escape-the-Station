using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ButtonLogic : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    //public UnityEvent onRelease;
    
    //AudioSource sound; // sound wird nicht gebraucht gerade
    bool isPressed;
    bool open;

    GameObject presser;
    public GameObject doorP1;
    public GameObject doorP2;
    int i;

    void Start()
    {
        open = false;
        isPressed = false;  
    }

    private void OnTriggerEnter(Collider other) {
        button.transform.localPosition = new Vector3(0, -0.005f, 0);
        if (!isPressed && i == 0 ){
            presser = other.gameObject;
            onPress.Invoke();
            //sound.Play();
            isPressed = true;
            i++;  // damit es nur einmal geht
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject == presser){
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            isPressed = false;
        }
    }

    public void OpenDoor(){
        
        open = true;
        
    }

    void Update() {


        if(open){
            doorP1.transform.Translate(Vector3.up * Time.deltaTime * 1); //verschiebt die tür
            doorP2.transform.Translate(Vector3.down * Time.deltaTime * 1);
        }

        if(doorP1.transform.position.y > 8f){
            open = false;
        }


        
    }

    
}