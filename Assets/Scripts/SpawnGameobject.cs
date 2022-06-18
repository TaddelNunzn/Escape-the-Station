using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGameobject : MonoBehaviour
{
    public Transform Spawnpoint;
    public Object spawnObject;

    bool spawned = false;

    public void SpawnObject(){
        Instantiate(spawnObject, Spawnpoint.position, Spawnpoint.rotation);
    }

    public void SpawnObjectOnce(){
        if(!spawned){
        Instantiate(spawnObject, Spawnpoint.position, Spawnpoint.rotation);
        spawned = true;        
        }
    }
}
