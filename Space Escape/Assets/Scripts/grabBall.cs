using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabBall : MonoBehaviour {
    public GameObject player;
    public GameObject playerCam;
    bool hasPlayer = false;
    bool beingCarried = false;
    private bool touched = false;

    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.transform.position);
        if (dist <= 2.5f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }
        if (hasPlayer && Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam.transform;
            beingCarried = true;
        }
        if (beingCarried)
        {
            if (touched)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }
            else if (Input.GetMouseButtonDown(1))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
            }
        }
    }

    void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }
}
