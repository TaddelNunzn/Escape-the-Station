using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class CaptainsDesk : MonoBehaviour
{
    public RenderTexture[] renderTextures;
    public TextMeshProUGUI button;
    public Image image;
    public RawImage leftScreen,rightScreen;
    bool isOpen = false;

    bool wait = true;

    public UnityEvent solved;
    // Start is called before the first frame update
    void Start()
    {
        ChangeScreens();
    }

    void ChangeScreens(){
        if(!isOpen){
            leftScreen.texture = renderTextures[Random.Range(0,renderTextures.Length-2)];
            rightScreen.texture = renderTextures[Random.Range(0,renderTextures.Length-2)];
            Invoke("ChangeScreens",10);
        }
    }

    public void stopwait(){
        Invoke("changewait",3);
    }


    void changewait(){
        wait = false;
    }

    public void OpenEscapePod(){
        if(!isOpen && !wait){
            button.text = "Escape Pod\nOpened";
            image.color = new Color32(59,236,97,255);
            isOpen = true;
            leftScreen.texture = renderTextures[4];
            rightScreen.texture = renderTextures[4];
            solved.Invoke();
        }
    }

    public void IsSolved(){
        Debug.Log("OPEN");
    }
}
