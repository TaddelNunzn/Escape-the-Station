using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class PlayAudio : MonoBehaviour
{
   
   bool playable = true;
    public UnityEvent onPress;
    public AudioSource audioo;

   private void OnTriggerEnter(Collider other) {
        onPress.Invoke();

    }

    void restartPlayable() {
        playable = true;
    }
   

    public void playAudio(){
        if(playable){
        audioo.Play();
        playable = false;
        Invoke("restartPlayable", 25);
        }
    }
}
