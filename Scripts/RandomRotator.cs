using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public float tumble;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        // Sets the angular velocity to be somewhere inside a sphere
        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
}
