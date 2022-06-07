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
    private CharacterController characterController;
    public GameObject vrCamera;
    Vector3 direction = Vector3.zero;

    private Rigidbody rigidbody;
    


    private void Start(){
        characterController = GetComponent<CharacterController>();
        rigidbody = GetComponent<Rigidbody>();
        

        Valve.VR.OpenVR.Chaperone.ResetZeroPose(ETrackingUniverseOrigin.TrackingUniverseStanding);
        PositionController();
        
    }

    // Update is called once per frame
    void Update()
    {   
        

        
        
        
    }

    void FixedUpdate(){
        //PositionController();
        MovePlayer();
        /*if(input.axis.magnitude > 0.1f){
            Vector3 direction = handPhysics.handCollider.transform.TransformDirection(input.axis.x,0,input.axis.y);
            characterController.Move(speed * Time.fixedDeltaTime * direction); 
        }*/
    }


    Vector3 currentSpeed;
    float change = 0.25f;

    bool pressed = false;

    private void MovePlayer(){   
        if(stop.state) rigidbody.AddForce(-rigidbody.velocity*10);
        else if(input.axis.magnitude > 0.1f){
            Vector3 direction = handPhysics.handCollider.transform.TransformDirection(input.axis.x,0,input.axis.y);
            rigidbody.AddForce(direction);
            
        }
        
        characterController.Move(currentSpeed*Time.fixedDeltaTime*speed);        
    }

     //moves capsule with vr camera
    private void PositionController()
    {
        Vector3 hmd = vrCamera.transform.position;
        Vector3 rig = rigidbody.transform.position;
        Vector3 diff = hmd - rig;
        rigidbody.AddForce(diff.x,0,diff.y);
    }
    
}
