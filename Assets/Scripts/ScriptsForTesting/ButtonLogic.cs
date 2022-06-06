using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ButtonLogic : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    //AudioSource sound;  sound wird nicht gebraucht gerade
    bool isPressed;

    Animator doorAni;


    void Start()
    {
        //sound = GetComponent<AudioSource>();
        isPressed = false;
        doorAni = this.transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other) {
        if (!isPressed){
            button.transform.localPosition = new Vector3(0, -0.005f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            //sound.Play();
            isPressed = true;  
            

        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject == presser){
            button.transform.localPosition = new Vector3(0, 0.0064f, 0);
            onRelease.Invoke();
            isPressed = false;
            
        }
    }

    public void Something(){
        
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        sphere.transform.localPosition = new Vector3(0,1,2);
        sphere.AddComponent<Rigidbody>(); 

    }

    public void Door(){
        doorAni.SetBool("isOpen", true); 

    }

    
}
