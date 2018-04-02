using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public Animator animator;
    public bool keyPickedUp = false;

    void OnTriggerEnter(Collider other) {
        if (keyPickedUp == true) {
            Debug.Log("Open");
            animator.SetBool("isOpen", true);
        }
    }

    void OnTriggerExit(Collider other) {
        animator.SetBool("isOpen", false);
    }
}
