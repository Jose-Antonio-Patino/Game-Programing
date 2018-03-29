using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelectedBlock_10 : MonoBehaviour {

    const float maxDestroyDistance = 10f;

	void Update () {
        if(Input.GetMouseButtonDown(0)) {
            Vector3 scrCenter = new Vector3(Screen.width / 2, Screen.height / 2, 0);
            Ray ray = Camera.main.ScreenPointToRay(scrCenter);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, maxDestroyDistance)){
                Destroy(hit.transform.gameObject);
            }
        }
	}
}
