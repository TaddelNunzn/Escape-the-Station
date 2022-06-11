using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeTexture : MonoBehaviour
{
    public UnityEvent onPress;
    Renderer m_renderer;
	public Texture texturePressed;

    //public Material Material1;

    bool isPressed;
    GameObject presser;
    public GameObject tochange;
      int i;
    // Start is called before the first frame update
    void Start()
    {
        m_renderer = tochange.GetComponent<Renderer> ();
    }


    private void OnTriggerEnter(Collider other) {
    if (!isPressed && i == 0 ){
        presser = other.gameObject;
        onPress.Invoke();
        //sound.Play();
        isPressed = true;
        i++;  // damit es nur einmal geht
        Debug.Log("ich wurde gedrückt");
    }
}

 public void ChangeT(){
    //tochange.GetComponent<MeshRenderer> ().material = Material1;
        m_renderer.material.SetTexture("_MainTex", texturePressed);
        Debug.Log("textur geändert");
    }

}
