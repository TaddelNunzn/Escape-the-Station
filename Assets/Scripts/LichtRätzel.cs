using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class LichtRätzel : MonoBehaviour
{

    bool timeout = false;
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent solved;
    //public UnityEvent onRelease;
    
    //AudioSource sound; // sound wird nicht gebraucht gerade

    bool invoked = false;
    public Material Material1;
    public Material Material2;

    GameObject presser;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;

    
    
    static bool on1 = false;
    static bool on2 = false;
    static bool on3 = false;
    static bool on4 = false;
    static bool on5 = false;
    int tmp = 0;


void Start(){
    solvedCheck();
}

    private void OnTriggerEnter(Collider other) {
      
        if (!timeout){
        
            presser = other.gameObject;
            onPress.Invoke();
            //sound.Play();
            timeout = true;
            Invoke("resetTimeout", 0.5f);
       
            
        }
    }

    private void resetTimeout(){
        timeout = false;
    }



//if anweisungen für die Logic
    public void Lights1u2(){
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

    public void Lights3u5(){
        if(on3){
            light3.GetComponent<MeshRenderer> ().material = Material2;
            on3 = false;
        }else{
            light3.GetComponent<MeshRenderer> ().material = Material1;
            on3 = true;
        }

        if(on5){
            light5.GetComponent<MeshRenderer> ().material = Material2;
            on5 = false;
        }else{
            light5.GetComponent<MeshRenderer> ().material = Material1;
            on5 = true;
        }
    }

    public void Lights2u3(){
        if(on2){
            light2.GetComponent<MeshRenderer> ().material = Material2;
            on2 = false;
        }else{
            light2.GetComponent<MeshRenderer> ().material = Material1;
            on2 = true;
        }

        if(on3){
            light3.GetComponent<MeshRenderer> ().material = Material2;
            on3 = false;
        }else{
            light3.GetComponent<MeshRenderer> ().material = Material1;
            on3 = true;
        }

    }

    public void Lights4u5(){    
        if(on4){
            light4.GetComponent<MeshRenderer> ().material = Material2;
            on4 = false;
        }else{
            light4.GetComponent<MeshRenderer> ().material = Material1;
            on4 = true;
        }

        if(on5){
            light5.GetComponent<MeshRenderer> ().material = Material2;
            on5 = false;
        }else{
            light5.GetComponent<MeshRenderer> ().material = Material1;
            on5 = true;
        }
    }

    public void Lights1u3u5(){
        if(on1){
            light1.GetComponent<MeshRenderer> ().material = Material2;
            on1 = false;
        }else{
            light1.GetComponent<MeshRenderer> ().material = Material1;
            on1 = true;
        }

        if(on3){
            light3.GetComponent<MeshRenderer> ().material = Material2;
            on3 = false;
        }else{
            light3.GetComponent<MeshRenderer> ().material = Material1;
            on3 = true;
        }

        if(on5){
            light5.GetComponent<MeshRenderer> ().material = Material2;
            on5 = false;
        }else{
            light5.GetComponent<MeshRenderer> ().material = Material1;
            on5 = true;
        }
    }


//anwendung von verschiedenen mustern
    public void Logic1(){ 
        if(tmp == 0){
            tmp++;
            Lights1u2();
        }else if(tmp==1){
            tmp--;
            Lights3u5();
        }         
    }

    public void Logic2(){
        if(tmp == 0){
            tmp++;
            Lights2u3();
            
        }else if(tmp==1){
            tmp--;
            Lights4u5();
        }
    }

    public void Logic3(){
        if(tmp == 0){
            tmp++;
            Lights1u3u5();

        }else if(tmp==1){
            tmp--;
            Lights4u5();
        }  
    }

    void solvedCheck(){
        if(on1 && on2 && on3 && on4 && on5 && !invoked){
            solved.Invoke();
            tmp = 4;
            invoked = true;
        }
        else if(!invoked){
            Invoke("solvedCheck",0.1f);
        }
    }

  


    

    
 }


 

    
