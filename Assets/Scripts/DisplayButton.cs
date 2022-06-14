using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DisplayButton : MonoBehaviour
{

    public UnityEvent onPress;
    private bool wait = false;

    //Called when hand touches Trigger
    private void OnTriggerEnter(Collider other)
    {
        if(!wait){
            //Onpress event is Called
            onPress.Invoke();
            wait = true;
            //Wait for .5 seconds to prevent button Spam
            Invoke("setwait", 0.5f);
        }
    }

    void setwait(){
        wait = false;
    }
}
