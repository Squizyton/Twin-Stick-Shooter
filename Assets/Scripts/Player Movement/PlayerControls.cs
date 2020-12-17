using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.InputSystem;


public class PlayerControls : MonoBehaviour
{
    //Keeps track if an object is picked up
    [Header("Picked Up Object"), Tooltip("This will tell Game if an object is currently being held")]
    public IPickupable pickupedObject;

    [Header("Raycast Settings"), Tooltip("The settings for the raycast")]
    public float raycastLength = 0;

    public Transform raycastPoint;


    private GameControls _controls;

    void Start()
    {
        _controls = new GameControls();
        _controls.Enable();
        _controls.Keyboard.Interact.performed += context => { Interact(); };
        _controls.Keyboard.Throw.performed += context => { PickupThrow(); };
    }

    void Update()
    {
    }

    void Interact()
    {
        RaycastHit hit;
        Debug.Log("Ray");

        if (Physics.Raycast(raycastPoint.position, transform.TransformDirection(Vector3.forward), out hit,
            raycastLength))
        {
            Debug.Log(hit.transform.name);
        }

        Debug.DrawRay(raycastPoint.position, transform.TransformDirection(Vector3.forward) * hit.distance,
            Color.yellow);
    }

    void PickupThrow()
    {
        if (pickupedObject != null)
        {
            pickupedObject.OnThrow();
            pickupedObject = null;
        }
        else
        {
            Debug.Log("uh");
            RaycastHit hit;
            if (Physics.Raycast(raycastPoint.position, transform.TransformDirection(Vector3.forward), out hit, raycastLength))
            {
                Debug.Log(hit.transform.name);
                
                pickupedObject = hit.transform.GetComponent<IPickupable>();
                
                if (pickupedObject != null)
                {
                    Debug.Log("Pickup");
                    hit.transform.GetComponent<IPickupable>().PickUp();
                }
            }

            Debug.DrawRay(raycastPoint.transform.position, transform.TransformDirection(Vector3.forward) * hit.distance,
                Color.yellow);
        }
    }
}