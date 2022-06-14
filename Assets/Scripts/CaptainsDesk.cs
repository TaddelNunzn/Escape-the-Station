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

    public void OpenEscapePod(){
        if(!isOpen){
            button.text = "Escape Pod\nOpened";
            image.color = new Color32(7,193,0,255);
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
