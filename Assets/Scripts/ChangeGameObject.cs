using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGameObject : MonoBehaviour
{
   
   
     public GameObject[] prefabold;
     public GameObject[] prefabnew;

   private void Start(){    
      //Neue prefabs auf inactive setzen
      for(int i=0; i<prefabnew.Length; i++){
          prefabnew[i].gameObject.SetActive(false);
        }

    }

     void Update()
     {



     if(Input.GetKeyDown(KeyCode.E))
     {
        ChangePrefabs();
     }

     
     void ChangePrefabs(){
        //Alte prefabs auf inactive setzen
        for(int i=0; i<prefabold.Length; i++){
          prefabold[i].gameObject.SetActive(false);
          Debug.Log(i);
        }
    
         //Neue prefabs auf active setzen
           for(int i=0; i<prefabnew.Length; i++){
          prefabnew[i].gameObject.SetActive(true);
        }

     }
     }

     
}
