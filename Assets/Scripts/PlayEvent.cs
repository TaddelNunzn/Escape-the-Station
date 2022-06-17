using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class PlayEvent : MonoBehaviour
{

    public AudioSource sound;

   

    public void playSound(){

        sound.Play();

        
    }
}
