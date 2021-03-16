using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovementBlue : MonoBehaviour
{
    public Rigidbody Rb;
    public Vector3 Destination;
    public float Distance;

    public void Start()
    {
        Destination = new Vector3(Random.Range(-9, 9), 0, Random.Range(-4, 4));
    }
    // Update is called once per frame
    void Update()
    {
        Rb.drag = Rb.velocity.magnitude / 2;
        transform.LookAt(Destination);
        Rb.AddRelativeForce(0, 0, 5);
        if (Vector3.Distance(transform.position, Destination) <= 1)
        {
            Destination = new Vector3(Random.Range(-9, 9), 0, Random.Range(-4, 4));
            Debug.Log(" " + Destination);
        }
    }
}