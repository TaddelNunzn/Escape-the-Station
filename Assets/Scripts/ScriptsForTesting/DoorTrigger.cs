using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{

    Animator _doorAni;

    private void OnTriggerEnter(Collider other) {
        _doorAni.SetBool("Open", true);
    }

    private void OnTriggerExit(Collider other) {
        _doorAni.SetBool("Open", false);
    }

    // Start is called before the first frame update
    void Start()
    {
        _doorAni = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
