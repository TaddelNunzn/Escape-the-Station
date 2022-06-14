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
    private bool rischtisch = false;
    
    // Start is called before the first frame update
    void Start()
    {
        member.text = crewName;
        passwordInput.text = "Passwort";
        passwort = passwort.ToUpper();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Input(TextMeshProUGUI letter){
        if(!rischtisch)
        {   
            string symbol = letter.text;
            if(passwordInput.text.Equals("Passwort")){
                passwordInput.text = symbol;
            }
            else{
                passwordInput.text += symbol;
            }
        }

    }

    public void Back(){
        if(passwordInput.text.Length>0){
            passwordInput.text = passwordInput.text.Remove(passwordInput.text.Length-1);
        }
    }

    public void Send(){
        if(passwordInput.text.Equals(passwort)){
            solved.Invoke();
        }
        else {
            sound.Play();
            passwordInput.text = "Wrong!";
            Invoke("Reset",1);
        }
    }

    private void Reset(){
        passwordInput.text = "Passwort";
    }

    public void rightAnswer(){
        passwordInput.text = "Solved";
        rischtisch = true;
    }
}
