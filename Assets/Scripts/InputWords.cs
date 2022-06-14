using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class InputWords : MonoBehaviour
{
    public string crewName;
    public string passwort;
    public TextMeshProUGUI member;
    public TextMeshProUGUI passwordInput;
    public AudioSource sound;
    public UnityEvent solved;
    private bool isSolved = false;
    
    // Start is called before the first frame update
    void Start()
    {
        //Set Crewmember Name and Passwort in UI and Convert Password to UpperCase
        member.text = crewName;
        passwordInput.text = "Passwort";
        passwort = passwort.ToUpper();
    }

    //Called, when a Input button is pressed
    public void Input(TextMeshProUGUI letter){
        if(!isSolved)
        {   
            //add the Symbol of the Input Button to the Text in the Password TextMesh
            string symbol = letter.text;
            if(passwordInput.text.Equals("Passwort")){
                passwordInput.text = symbol;
            }
            else{
                passwordInput.text += symbol;
            }
        }

    }

    //Called when the Back button is pressed
    public void Back(){
        if(passwordInput.text.Length>0 && !isSolved){
            //Removes last symbol from Password TextMesh
            passwordInput.text = passwordInput.text.Remove(passwordInput.text.Length-1);
        }
    }

    //Called when the Password "Enter" button is pressed
    public void Send(){
        if(!isSolved){
            //If the text in the Password TextMesh equals the password solved Event is called
            if(passwordInput.text.Equals(passwort)){
                isSolved=true;
                passwordInput.text = "Solved";
                solved.Invoke();
            }
            //Else Screen gets reseted
            else {
                sound.Play();
                passwordInput.text = "Wrong!";
                Invoke("Reset",1);
            }
        }
    }

    //Resets Password TextMesh to Passwort
    private void Reset(){
        passwordInput.text = "Passwort";
    }

    //Default Funktion for Solved Event
    public void IsSolved(){
        Debug.Log("Solved");
    }
}
