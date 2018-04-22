using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private AudioSource sound;
    public Animator animator;
    public bool keyPickedUp = false;
    public string paneltag;

    void Start() {
        sound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
       
        if (keyPickedUp == true)
        {
            sound.Play();
            Debug.Log("Open");
            animator.SetBool("isOpen", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        animator.SetBool("isOpen", false);
        sound.Play();
        keyPickedUp = false;
    }
}
