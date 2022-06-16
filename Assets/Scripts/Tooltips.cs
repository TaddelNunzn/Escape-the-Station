using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Tooltips : MonoBehaviour
{

    public UnityEvent onPress;
    int CurrentAudio = 1;

    bool welcomeplayed = false;
    bool playable = true;

    public AudioSource welcome;
    public AudioSource tipp1;
    public AudioSource tipp2;
    public AudioSource tipp3;
    public AudioSource tipp4;
    public AudioSource tipp5;
    public AudioSource tipp6;
    public AudioSource tipp7;


private void OnTriggerEnter(Collider other) {
        onPress.Invoke();

    }

    public void playWelcome(){
     if(!welcomeplayed && playable){
           welcome.Play();
           welcomeplayed = true;
           playable = false;
           Invoke("Playable",10);
     }
    }

    void Playable(){
        playable = true;
    }

    public void playAudio(){
        if(playable){
        switch (CurrentAudio){
            case 1: tipp1.Play();
            playable = false;
            Invoke("Playable",5);
            break;
            case 2: tipp2.Play();
            playable = false;
            Invoke("Playable",6);
            break;
            case 3: tipp3.Play();
            Invoke("Playable",4);
            playable = false;
            break;
            case 4: tipp4.Play();
            Invoke("Playable",6);
            playable = false;
            break;
            case 5: tipp5.Play();
            Invoke("Playable",5);
            playable = false;
            break;
            case 6: tipp6.Play();
            Invoke("Playable",5);
            playable = false;
            break;
            case 7: tipp7.Play();
            Invoke("Playable",5);
            playable = false;
            break;
        }
        }
    }

    public void nextTooltip(){
        CurrentAudio +=1;
        Debug.Log(CurrentAudio);
    }
}
