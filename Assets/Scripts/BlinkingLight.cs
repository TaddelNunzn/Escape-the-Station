using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BlinkingLight : MonoBehaviour
{
   
    bool active = true;
    public Material green;
    public Material red;
    public Light lightsauce;
    
    public GameObject light1;

  void restartActive(){
    active = true;
    }

  public void changeGreen(){
  if(active){
  lightsauce.color = (Color.green);
  light1.GetComponent<MeshRenderer> ().material = green;
  Invoke("changeRed", 1);
  }
  }

  void changeRed(){
  if (active){
  lightsauce.color = (Color.red);
  light1.GetComponent<MeshRenderer> ().material = red;
  Invoke("changeGreen", 1);
  }
  }
     
    public void StopChange(){
      lightsauce.color = (Color.green);
      light1.GetComponent<MeshRenderer> ().material = green;
      active=false;
      Invoke("restartActive",25);
      Invoke("changeRed",25);
    }

     
}
