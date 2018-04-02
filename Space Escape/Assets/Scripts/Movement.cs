using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    Vector3 velocity = new Vector3(0.0f, .001f, 0.0f);
    float floorHeight = 0.35f;
    float sleepThreshold = 0.05f;
    float gravity = -.1f;

    public float xLocation;
    public float zLocation;

    void FixedUpdate()
    {
        if (velocity.magnitude > sleepThreshold || transform.position.y > floorHeight)
        {
            velocity += new Vector3(0.0f, gravity * Time.fixedDeltaTime, 0.0f);
        }

        transform.position += velocity * Time.fixedDeltaTime;
        if (transform.position.y <= floorHeight)
        {
            transform.position = new Vector3(xLocation, floorHeight, zLocation);
            velocity.y = -velocity.y;
        }
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 60) * Time.deltaTime);

    }


}
