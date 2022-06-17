using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameEvents : MonoBehaviour
{
    
    public void StartGame()
    {
       SceneManager.LoadScene("Main Scene"); 
       Debug.Log("StartGame");
    }

     public void ExitGame()
    {
        Application.Quit(); 
        Debug.Log("Bye !");
    }
   
}
