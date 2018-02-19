using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    public Text p1ScoreText;
    public Text p2ScoreText;
    public GameObject soccerBall;
    public GameObject spawnPt;


    private int p1Score = 0;
    private int p2Score = 0;

	// Use this for initialization
	void Start () {
        SetCountText();
	}


    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Trigger 1")) {
            other.gameObject.SetActive(false);
            p1Score++;
            SetCountText();
            soccerBall.transform.position = spawnPt.transform.position;


        } else if (other.gameObject.CompareTag("Trigger 2")) {
            p2Score++;
            SetCountText();
            soccerBall.transform.position = spawnPt.transform.position;
        }
    }



    void SetCountText() {
        p1ScoreText.text = "P1 Score: " + p1Score.ToString();
        p2ScoreText.text = "P2 Score: " + p2Score.ToString();

    }
}
