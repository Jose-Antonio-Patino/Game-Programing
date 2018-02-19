using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour{

    private void OnTriggerEnter(Collider other){
        GameObject go = other.gameObject;
        if (go.tag == "Player"){
            Debug.Log("The player was hit!");
            Destroy(go);
        }
    }
}
