using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BlinkingLight : MonoBehaviour
{
   
    bool active = true;

     public GameObject licht1;
     public GameObject licht2;

   private void Start(){    
      //Neue prefabs auf inactive setzen

          licht2.gameObject.SetActive(false);


    }


      public void ChangePrefabs1(){
        if(active){

        licht1.gameObject.SetActive(false);

        licht2.gameObject.SetActive(true);
      
        }
        Invoke("ChangePrefabs2", 1);
        
    }

     public void ChangePrefabs2(){
       if(active){

        licht1.gameObject.SetActive(true);

        licht2.gameObject.SetActive(false);
      
       }
       Invoke("ChangePrefabs1", 1);
    }
    
    public void StopChange(){
      active=false;
    }

     
}
