using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEvilmessages : MonoBehaviour
{
     public AudioSource evil1;
      public AudioSource evil2;
       public AudioSource evil3;
    void Start()
    {
       timeout(); 
    }

    void timeout(){
        Invoke("playEvil1",3);
    }
    void playEvil1(){
       evil1.Play();
        Invoke("playEvil2", 8);
    }
    void playEvil2(){
       evil2.Play();
        Invoke("playEvil3", 13);
    }

void playEvil3(){
       evil3.Play();
    }


}
