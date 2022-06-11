using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeTexture : MonoBehaviour
{

    static bool doupdates = true;
    static bool finished = false;
    static int count = 0;
    int current = 0;
    public UnityEvent onPress;
    Renderer m_renderer;
	public Texture texturePressed;
    public Texture texturePressed2;
    public Texture texturePressed3;
    public Texture texturePressed4;
    public Texture texturePressed5;
     public Texture finishtexture;

    //public Material Material1;

    GameObject presser;
    public GameObject tochange;

    // Start is called before the first frame update
    void Start()
    {
        m_renderer = tochange.GetComponent<Renderer> ();
    }

    void Update(){
    if(count == 2140 && doupdates){
    m_renderer.material.SetTexture("_MainTex", finishtexture);
    finished = true;
    Debug.Log("i update");
    Invoke("stopupdates", 0.1f);
    }
    }

    private void OnTriggerEnter(Collider other) {
        if(!finished){
        presser = other.gameObject;
        onPress.Invoke();
        //sound.Play();
        }


}

void stopupdates(){
    doupdates = false;
    Debug.Log("i stopped");
}
 public void ChangeT1(){
    if(count != 2140){
    switch(current){
        case 0:
         m_renderer.material.SetTexture("_MainTex", texturePressed);
         current++;
         count +=10;
         Debug.Log(count);
        break;
        

        case 1:
         m_renderer.material.SetTexture("_MainTex", texturePressed2);
         current++;
         count +=10;
         Debug.Log(count);
        break;

        case 2:
        m_renderer.material.SetTexture("_MainTex", texturePressed3);
        current++;
        count +=10;
        Debug.Log(count);
        break;

        case 3:
        m_renderer.material.SetTexture("_MainTex", texturePressed4);
         current++;
         count +=10;
         Debug.Log(count);
        break;

        case 4:
        m_renderer.material.SetTexture("_MainTex", texturePressed5);
        current = 0;
        count -=40;
        Debug.Log(count);
        break;
    }
    }
 }


 public void ChangeT2(){
    if(count != 2140){
    switch(current){
        case 0:
         m_renderer.material.SetTexture("_MainTex", texturePressed);
         current++;
         count +=100;
         Debug.Log(count);
        break;

        case 1:
         m_renderer.material.SetTexture("_MainTex", texturePressed2);
         current++;
         count +=100;
         Debug.Log(count);
        break;

        case 2:
        m_renderer.material.SetTexture("_MainTex", texturePressed3);
        current++;
        count +=100;
        Debug.Log(count);
        break;

        case 3:
        m_renderer.material.SetTexture("_MainTex", texturePressed4);
         current++;
         count +=100;
         Debug.Log(count);
        break;

        case 4:
        m_renderer.material.SetTexture("_MainTex", texturePressed5);
        current = 0;
        count -=400;
        Debug.Log(count);
        break;
    }
    }
 }


 public void ChangeT3(){
    if(count != 2140){
    switch(current){
        case 0:
         m_renderer.material.SetTexture("_MainTex", texturePressed);
         current++;
         count +=1000;
         Debug.Log(count);
        break;

        case 1:
         m_renderer.material.SetTexture("_MainTex", texturePressed2);
         current++;
         count +=1000;
         Debug.Log(count);
        break;

        case 2:
        m_renderer.material.SetTexture("_MainTex", texturePressed3);
        current++;
        count +=1000;
        Debug.Log(count);
        break;

        case 3:
        m_renderer.material.SetTexture("_MainTex", texturePressed4);
         current++;
         count +=1000;
         Debug.Log(count);
        break;

        case 4:
        m_renderer.material.SetTexture("_MainTex", texturePressed5);
        current = 0;
        count -=4000;
        Debug.Log(count);
        break;
    }
    }
 }
}