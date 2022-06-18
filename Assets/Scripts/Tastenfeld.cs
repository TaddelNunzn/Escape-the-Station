using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Tastenfeld : MonoBehaviour
{
    
    public TextMeshProUGUI textField;

    bool timeout = false;
     
     [SerializeField] private string solution;

    public UnityEvent solved;

    public AudioSource wrong;

    private string prev = "";
    private int stelle = 0;

    //Called when Screen button is pressed
    public void press(TextMeshProUGUI input){
        if(!timeout){
        //gets input from TextMesh of button
        string number = input.text;
        //Overwrites **** with symbol from Button. Digit is important
        switch(stelle){
            case 0:
                textField.text = ""+number+"***";
                prev += number;
                stelle ++;
                break;
            case 1:
                textField.text = prev+number+"**";
                prev += number;
                stelle ++;
                break;
            case 2:
                textField.text=prev+number+"*";
                prev +=number;
                stelle ++;
                break;
            case 3:
                
                textField.text=prev+number;
                prev += number;
                stelle ++;

                //if input equals Solution Solved event is called
                if(prev.Equals(""+solution)){
                    textField.text = "Solved!";
                    solved.Invoke();
                }else{
                    //else screen is reset
                    wrong.Play();
                    Invoke("resetScreen",1f);
                }
                break;
            default:
                break;
        }
        timeout = true;
        Invoke("resetTimeout",0.3f);

        }
    }


    void resetTimeout(){
        timeout = false;
    }
    //default for solved Event
    public void IsSolved(){
        Debug.Log("Solved");
    }

    private void resetScreen(){
        //screen gets reset
        prev = "";
        textField.text="****";
        stelle = 0;
    }
}
