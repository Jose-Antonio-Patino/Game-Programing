using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour {

    public int score;
    public Text textScore;
    public Text winText;
    public int padCount = 0;
    public GameObject panel;

    public void Update()
    {
        textScore.text = "" + score;

        if(padCount >= 4){
            panel.SetActive(true);
        }

    }


}
