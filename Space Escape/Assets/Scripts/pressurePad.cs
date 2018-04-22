using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePad : MonoBehaviour {

    public GameMgr gamemgr;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball")) {
            gamemgr.padCount++;
        }
    }
}
