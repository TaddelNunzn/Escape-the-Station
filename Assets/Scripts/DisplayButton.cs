using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DisplayButton : MonoBehaviour
{

    public UnityEvent onPress;
    private bool wait = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!wait){
            onPress.Invoke();
            wait = true;
            Invoke("setwait", 0.5f);
        }
    }

    void setwait(){
        wait = false;
    }
}
