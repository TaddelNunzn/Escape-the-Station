using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeTexture : MonoBehaviour
{

    bool invoked = false;
    public UnityEvent solved;
    bool wait = false;
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


    GameObject presser;
    public GameObject tochange;

    void Start()
    {
        m_renderer = tochange.GetComponent<Renderer> ();
        solvedCheck();
    }


 void solvedCheck(){
        if(count == 2140 && !invoked){
            invoked = true;
            m_renderer.material.SetTexture("_MainTex", finishtexture);
            finished = true;
            solved.Invoke();
            
        }
        else if(!invoked){
            Invoke("solvedCheck",0.1f);
        }
    }

  

    private void OnTriggerEnter(Collider other) {
        if(!finished && !wait){
        presser = other.gameObject;
        onPress.Invoke();
        wait = true;
        Invoke("setwait", 0.5f);
        //sound.Play();
        }


}

void setwait(){
    wait = false;
}

 public void ChangeT1(int multi){
    if(count != 2140){
    switch(current){
        case 0:
         m_renderer.material.SetTexture("_MainTex", texturePressed);
         current++;
         count +=multi;
         Debug.Log(count);
        break;
        

        case 1:
         m_renderer.material.SetTexture("_MainTex", texturePressed2);
         current++;
         count +=multi;
         Debug.Log(count);
        break;

        case 2:
        m_renderer.material.SetTexture("_MainTex", texturePressed3);
        current++;
        count +=multi;
        Debug.Log(count);
        break;

        case 3:
        m_renderer.material.SetTexture("_MainTex", texturePressed4);
         current++;
         count +=multi;
         Debug.Log(count);
        break;

        case 4:
        m_renderer.material.SetTexture("_MainTex", texturePressed5);
        current = 0;
        count -= (4*multi);
        Debug.Log(count);
        break;
    }
    }
 }

}