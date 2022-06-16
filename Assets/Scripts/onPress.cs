using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class onPress : MonoBehaviour
{

    public UnityEvent whenPresses;


private void OnTriggerEnter(Collider other) {
        whenPresses.Invoke();
    }
}
