using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraTable : MonoBehaviour
{

    //Textures that Mimic Cameras in scene
    public RenderTexture[] renderTextures;
    //Middle Screen
    public RawImage screen;

    //what camera is active at the moment
    private int tmp = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Set Middlescreen to first Camera
        screen.texture = renderTextures[tmp];
    }

    //Called when specific button is Pressed
    public void ChangeScreen(int direction){
        //set active camera +1 or -1;
        tmp = (tmp + direction)%renderTextures.Length;
        if(tmp < 0) tmp += renderTextures.Length;
        //change Middlescreen to active Camera
        screen.texture = renderTextures[tmp];
    }

}
