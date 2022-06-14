using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class DebugLog : MonoBehaviour
{
   
    public UnityEvent onPress;

   private void OnTriggerEnter(Collider other) {
        onPress.Invoke();

    }
   

    public void debuglog(){
        Debug.Log("I've been pressed");
    }
}
