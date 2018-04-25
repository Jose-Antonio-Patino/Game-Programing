using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePad : MonoBehaviour {

    public GameMgr gamemgr;
    public GameObject flair;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball")) {
            gamemgr.padCount++;
            Debug.Log("Pad Count = " + gamemgr.padCount);
            flair.SetActive(true);
            Debug.Log("Flair");
        }
    }
}
