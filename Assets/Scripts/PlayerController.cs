using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerController : MonoBehaviour
{
    public SteamVR_Action_Vector2 input;
    public SteamVR_Action_Boolean stop;
    public HandPhysics handPhysics;
    [SerializeField] private float speed = 1;
    public GameObject vrCamera;
    public Rigidbody rigidbody;
    public CapsuleCollider capsule;
    public CapsuleCollider bodyCollider;
    public SteamVR_Action_Boolean turnRight;
    public SteamVR_Action_Boolean turnLeft;
    public GameObject player;
    public GameObject steamVrObjects;
    
    

    private Transform startTransform;
    private void Start(){     
    }

    // Update is called once per frame
    void Update()
    {           
    }

    void FixedUpdate(){
        MovePlayer();
        RotatePlayer();
        HeightController();
        PositionController();
        

        
    }


    



    //move Player with left stick and stop with buttons
    private void MovePlayer(){   
        if(stop.state) rigidbody.AddForce(-rigidbody.velocity*10);
        else if(input.axis.magnitude > 0.1f){
            Vector3 direction = handPhysics.handCollider.transform.TransformDirection(input.axis.x,0,input.axis.y);
            rigidbody.AddForce(direction);
            
            
        }       
    }

    

    //rotate Player with right Stick
    private void RotatePlayer(){
        if(turnRight.stateDown){
            ResetPosition();
            rigidbody.transform.localRotation = rigidbody.transform.localRotation * Quaternion.Euler(0,30,0);
            
        }
        else if(turnLeft.stateDown){
            ResetPosition();
            rigidbody.transform.localRotation = rigidbody.transform.localRotation * Quaternion.Euler(0,-30,0);
            
            //rigidbody.freezeRotation=false;
            
            //rigidbody.MoveRotation(rigidbody.rotation * Quaternion.Euler(0,45,0));
        }
        else{
            rigidbody.freezeRotation = true;
        }
    }

  
    
    //Sets height of Collision capsule to height of capsule that follows HMD
    private void HeightController(){
        
        capsule.height = bodyCollider.height+0.25f;
    }

    private void PositionController(){
        float diff = new Vector3(capsule.center.x - bodyCollider.transform.localPosition.x,0,capsule.center.z-bodyCollider.transform.localPosition.z).magnitude;
        if(diff > 0.7) ResetPosition();
    }

    //resets collision Capsule to Position of capsule that follows the HMD
    private void ResetPosition()
    {

        capsule.center = bodyCollider.transform.localPosition+ new Vector3(0,0.25f,0);
        capsule.height = bodyCollider.height+0.25f;

        //capsule.radius = bodyCollider.radius;        
    }
}
