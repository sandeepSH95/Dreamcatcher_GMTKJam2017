using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public bool isPaused;

    public GameObject PauseMenuCanvas;
	
	// Update is called once per frame
	void Update () {
		if (isPaused)
        {
            PauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;

        } else
        {
            PauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
	}

    public void Resume ()
    {
        isPaused = false;
    }

    public void Quit ()
    {
        Application.Quit();
    }
}
