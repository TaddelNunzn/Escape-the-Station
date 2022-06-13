using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class LichtRätzel : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    //public UnityEvent onRelease;
    
    //AudioSource sound; // sound wird nicht gebraucht gerade
    bool isPressed;

    public Material Material1;
    public Material Material2;

    GameObject presser;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;

    int i;
    
    static bool on1 = false;
    static bool on2 = false;
    static bool on3 = false;
    static bool on4 = false;
    static bool on5 = false;


    void Start()
    {
        isPressed = false; 
    }

    private void OnTriggerEnter(Collider other) {
        button.transform.localPosition = new Vector3(0, -0.005f, 0);
        if (!isPressed ){
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

    public void Logic1(){

    if(on1){
        light1.GetComponent<MeshRenderer> ().material = Material2;
        on1 = false;
    }else{
        light1.GetComponent<MeshRenderer> ().material = Material1;
        on1 = true;
    }

    if(on2){
        light2.GetComponent<MeshRenderer> ().material = Material2;
        on2 = false;
    }else{
        light2.GetComponent<MeshRenderer> ().material = Material1;
        on2 = true;
    }
     
}

    public void Logic2(){
    
    if(on3){
        light3.GetComponent<MeshRenderer> ().material = Material2;
        on3 = false;
    }else{
        light3.GetComponent<MeshRenderer> ().material = Material1;
        on3 = true;
    }

    if(on4){
        light4.GetComponent<MeshRenderer> ().material = Material2;
        on4 = false;
    }else{
        light4.GetComponent<MeshRenderer> ().material = Material1;
        on4 = true;
    }

 
       
    }

    public void Logic3(){
    
        
    if(on5){
        light5.GetComponent<MeshRenderer> ().material = Material2;
        on5 = false;
    }else{
        light5.GetComponent<MeshRenderer> ().material = Material1;
        on5 = true;
    }

    /*if(on3){
        light3.GetComponent<MeshRenderer> ().material = Material2;
        on3 = false;
    }else{
        light3.GetComponent<MeshRenderer> ().material = Material1;
        on3 = true;
    }*/
 
        
    }



    void Update() {

        if(on1 && on2 && on3 && on4 && on5){
            Debug.Log("Magic");
            on1 = false;
        }

        
    }
 }


 

    
