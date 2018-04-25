using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectPanel : MonoBehaviour {

    const float maxDestroyDistance = 2f;
    public GameObject door1;
    private Door doorScript1;
    public GameObject door2;
    private Door doorScript2;
    public GameObject door3;
    private Door doorScript3;
    public GameObject door4;
    private Door doorScript4;

    public GameMgr gameMgr;

    void Start(){
        doorScript1 = door1.GetComponent<Door>();
        doorScript2 = door2.GetComponent<Door>();
        doorScript3 = door3.GetComponent<Door>();
        doorScript4 = door4.GetComponent<Door>();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 scrCenter = new Vector3(Screen.width / 2, Screen.height / 2, 0);
            Ray ray = Camera.main.ScreenPointToRay(scrCenter);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, maxDestroyDistance)){
                if (hit.transform.gameObject.CompareTag(doorScript1.paneltag))
                {
                    Destroy(hit.transform.gameObject);
                    doorScript1.keyPickedUp = true;
                    Debug.Log("Set 1 to true");
                    gameMgr.score++;

                } else if (hit.transform.gameObject.CompareTag(doorScript2.paneltag)) {
                    Destroy(hit.transform.gameObject);
                    doorScript2.keyPickedUp = true;
                    Debug.Log("Set 2 to true");
                    gameMgr.score++;
                }
                else if (hit.transform.gameObject.CompareTag(doorScript3.paneltag))
                {
                    Destroy(hit.transform.gameObject);
                    doorScript3.keyPickedUp = true;
                    Debug.Log("Set 3 to true");
                    gameMgr.score++;
                }
                else if (hit.transform.gameObject.CompareTag(doorScript4.paneltag))
                {
                    hit.transform.gameObject.SetActive(false);
                    doorScript4.keyPickedUp = true;
                    Debug.Log("Set 4 to true");
                    gameMgr.score++;
                }
            }
        }
    }

}
