using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Tastenfeld : MonoBehaviour
{
    
    public TextMeshProUGUI textField;
     
     [SerializeField] private string solution;

    public UnityEvent solved;

    public AudioSource wrong;
    // Start is called before the first frame update
    void Start()
    {
        //text = gameObject.GetComponent<TMPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string prev = "";
    private int stelle = 0;

    public void press(TextMeshProUGUI input){
        string number = input.text;
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
                if(prev.Equals(""+solution)){
                    solved.Invoke();
                }else{
                    wrong.Play();
                    Invoke("resetScreen",1f);
                }
                break;
            default:
                
                break;
        Debug.Log(textField.text);
        }
    }

    public void rightAnswer(){
        textField.text = "Solved!";
    }

    private void resetScreen(){
        
        prev = "";
        textField.text="****";
        stelle = 0;
    }


    public void TestAktion(){
        Debug.Log("Taste Gedrückt");    
    }
}
