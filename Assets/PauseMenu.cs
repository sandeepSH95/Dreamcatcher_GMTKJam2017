using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class death_menu : MonoBehaviour {

    public bool isDeath;

    public GameObject DeathMenuCanvas;

    GameObject counters;

	// Use this for initialization
	void Start () {

        counters = GameObject.FindWithTag("counters");

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

        if (counters.GetComponent<Counters_int>().black_ropes_cut >= 4)
        {
            isDeath = !isDeath;
        }

    }

    public void Restart ()
    {
        SceneManager.LoadScene("Main");
    }

    public void Quit ()
    {
        Application.Quit();
    }
}
