using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathMenu : MonoBehaviour {

    public bool isDeath;
    private bool opened;
    public GameObject DeathMenuCanvas;

    GameObject counters;

    GameObject timer;

	// Use this for initialization
	void Start () {

        counters = GameObject.FindWithTag("counters");

        timer = GameObject.FindWithTag("timer");
    }

    // Update is called once per frame
    void Update () {

        if (isDeath)
        {
            DeathMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            DeathMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (counters.GetComponent<Counters_int>().black_ropes_cut >= 4 && opened != true)
        {
            isDeath = !isDeath;
            opened = true;
        }

    }

    public void Restart ()
    {
        timer.GetComponent<Timer>().startTime = Time.time;
        SceneManager.LoadScene("Main");
    }

    public void Quit ()
    {
        Application.Quit();
    }
}
