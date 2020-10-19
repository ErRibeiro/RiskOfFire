using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyCharacterController : MonoBehaviour
{
    [SerializeField]
    private float accelerationForce = 10;
    [SerializeField]
    private float maxSpeed = 5;

   
    
    [SerializeField]
    private GameObject Player;
    [SerializeField]
    private Transform Cam;
    [SerializeField]
    private PhysicMaterial stoppingPhysicsMaterial, movingPhysicsMaterial;


    private new Rigidbody rigidbody;
    private Vector2 input;
    
    private new Collider collider;
    
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        collider = GetComponent<Collider>();
    }
    private void FixedUpdate()
    {
        var inputDirection = new Vector3(input.x, 0, input.y);

        Vector3 cameraFlattenedForward = Camera.main.transform.forward;
        cameraFlattenedForward.y = 0;
        var cameraRotation = Quaternion.LookRotation(cameraFlattenedForward);
        Vector3 cameraRelativeInputDirection = cameraRotation * inputDirection;

        //if (inputDirection.magnitude > 0)
        //{
        //    collider.material = movingPhysicsMaterial;
        //}
        //else
        //{
        //    collider.material = stoppingPhysicsMaterial;
        //}

        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            rigidbody.AddForce(cameraRelativeInputDirection * accelerationForce, ForceMode.Acceleration);
        } 
        
    }
    private void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");

        input.y = Input.GetAxisRaw("Vertical");
        transform.localRotation = Cam.transform.localRotation;
    }
}
