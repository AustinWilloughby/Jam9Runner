using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScoreScript : MonoBehaviour {
    public Canvas canvas;
    public Text timer;
    public Text score;
    float TimeT;
    public int timei;
    // Use this for initialization
    void Start () {
        TimeT = 0;
        timei = 0;
    }
	
	// Update is called once per frame
	void Update () {
        TimeT += Time.deltaTime;
        timei = (int)TimeT;
        timer.GetComponent<Text>().text = "time: " + timei.ToString();
        timei = (int)(TimeT* 100);
        score.GetComponent<Text>().text = "score: " + timei.ToString();
    }
}


