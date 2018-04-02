using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectPanel : MonoBehaviour {

    const float maxDestroyDistance = 2f;
    public GameObject door;
    private Door doorScript;

    void Start(){
        doorScript = door.GetComponent<Door>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 scrCenter = new Vector3(Screen.width / 2, Screen.height / 2, 0);
            Ray ray = Camera.main.ScreenPointToRay(scrCenter);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, maxDestroyDistance)){
                if (hit.transform.gameObject.CompareTag("Panel Key"))
                {
                    Destroy(hit.transform.gameObject);
                    Debug.Log("Set to true");
                    doorScript.keyPickedUp = true;

                }
            }
        }
    }

}
