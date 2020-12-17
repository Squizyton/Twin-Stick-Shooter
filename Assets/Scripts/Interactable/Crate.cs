using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour, IPickupable
{
    private Rigidbody rb;
    public void PickUp()
    {
        rb = this.transform.GetComponent<Rigidbody>();
        transform.position = GameObject.FindWithTag("Hand").transform.position;
        transform.SetParent(GameObject.FindWithTag("Hand").transform);
        rb.isKinematic = true;
    }

    public void OnThrow()
    {
        transform.SetParent(null);
        rb.isKinematic = false;
        rb.AddForce(Vector3.forward * Random.Range(650,950));
    }

    public void Interact()
    {
        return;
    }
}
