using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text counter_text;
    public float milliseconds, seconds, minutes;

    public float startTime, elapsedtime;

	// Use this for initialization
	void Start () {
        counter_text = GetComponent<Text>() as Text;
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        elapsedtime = Time.time - startTime;
        minutes = (int)(elapsedtime / 60f);
        seconds = (int)(elapsedtime % 60f);
        milliseconds = (int)(elapsedtime * 1000 - seconds * 1000);

        counter_text.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00").Substring(0,2);
	}
}
