using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishMenu : MonoBehaviour {

    public bool isDeath;
    private bool opened;
    private bool done;
    public GameObject finishMenuCanvas;

    GameObject counters;

    GameObject timer;

    // Use this for initialization
    void Start()
    {

        counters = GameObject.FindWithTag("thrust_text");

        //timer = GameObject.FindWithTag("timer");
    }

    // Update is called once per frame
    void Update()
    {

        if (isDeath)
        {
            finishMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            finishMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (counters.GetComponent<font_changes_4>().finished == true && done != true)
        {
            done = true;
            isDeath = !isDeath;
            opened = true;
        }

    }

    public void Restart()
    {
        //timer.GetComponent<Timer>().startTime = Time.time;
        SceneManager.LoadScene("Main");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
