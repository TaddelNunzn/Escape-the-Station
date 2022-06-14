using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeGameObject : MonoBehaviour
{
   
   bool changed = false;

     public GameObject[] prefabold;
     public GameObject[] prefabnew;

   private void Start(){    
      //Neue prefabs auf inactive setzen
      for(int i=0; i<prefabnew.Length; i++){
          prefabnew[i].gameObject.SetActive(false);
        }

    }


      public void ChangePrefabs(){
      if(!changed){
      //Alte prefabs auf inactive setzen
      for(int i=0; i<prefabold.Length; i++){
        prefabold[i].gameObject.SetActive(false);
      }
  
        //Neue prefabs auf active setzen
        for(int i=0; i<prefabnew.Length; i++){
        prefabnew[i].gameObject.SetActive(true);
        changed = true;
      }
        }
    }

     
}
