using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeTexture2 : MonoBehaviour
{
    Renderer m_renderer;
	public Texture changeto;
    public GameObject tochange;

    void Start()
    {
        m_renderer = tochange.GetComponent<Renderer> ();
    }

   

public void ChangeTexture() {
       
    m_renderer.material.SetTexture("_MainTex", changeto);

    }
}