using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class PlayAudio : MonoBehaviour
{
   
   bool playable = true;
    public UnityEvent onPress;
    public AudioSource audio;

   private void OnTriggerEnter(Collider other) {
        onPress.Invoke();

    }

    void restartPlayable() {
        playable = true;
    }
   

    public void playAudio(){
        if(playable){
        audio.Play();
        playable = false;
        Invoke("restartPlayable", 25);
        }
    }
}
