using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Vector3 rotationSpeed;
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
