using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrent : MonoBehaviour {

    public GameObject rotatable;
    public GameObject spawnPt;
    public GameObject cannonball;
    public int shootSpeed;

    private void Start(){
        StartCoroutine(shootCannonball());
    }
	
	void Update () {
        float a = 100 * Time.time;
        rotatable.transform.localRotation = Quaternion.Euler(0, a, 0);
	}

    IEnumerator shootCannonball() {
        while(true) {
            //
            GameObject go = Instantiate((cannonball));
            go.transform.localPosition = spawnPt.transform.position;
            go.transform.localRotation = spawnPt.transform.rotation;
            go.GetComponent<Rigidbody>().velocity = shootSpeed * spawnPt.transform.forward;
            Destroy(go, 5f);
            //
            yield return new WaitForSeconds(3f);
        }
    }
}
