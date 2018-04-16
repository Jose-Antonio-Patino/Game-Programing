using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour {

    public int score;
    public Text textScore;

    public void Update()
    {
        textScore.text = "" + score;
    }


}
