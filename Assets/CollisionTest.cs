using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLIDED WITH SOMETHING");

        Debug.Log(collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit Trigger");

        Debug.Log(other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Out of trigger");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Staying in trigger");
    }
}
