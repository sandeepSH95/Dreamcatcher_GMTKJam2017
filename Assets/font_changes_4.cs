using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class font_changes_4 : MonoBehaviour {

    GameObject player;
    GameObject red_rope;

    private Text thrust_text;

    public bool finished;

    // Use this for initialization
    void Start()
    {
        red_rope = GameObject.FindWithTag("red_rope");
        thrust_text = GameObject.Find("thrust_cut").GetComponent<Text>();
        player = GameObject.FindWithTag("Player");

        StartCoroutine("cutTheRope");
    }

    IEnumerator cutTheRope()
    {
        if (red_rope.GetComponent<RopeStatus>().rope_cut != true)
        {
            thrust_text.text = "GOTTA";
        }
        yield return new WaitForSeconds(0.5f);
        if (red_rope.GetComponent<RopeStatus>().rope_cut != true)
        {
            thrust_text.text = "GO";
        }
        yield return new WaitForSeconds(0.5f);
        if (red_rope.GetComponent<RopeStatus>().rope_cut != true)
        {
            thrust_text.text = "FAST";
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerController>().cutting == true)
        {
            thrust_text.color = new Color(0.839f, 0.286f, 0.2f);
            //thrust_text.text = "testing1";
        }
        else
        {
            thrust_text.color = new Color(0.698f, 0.788f, 0.67058f);

            //thrust_text.text = "testing";
        }
        if (red_rope.GetComponent<RopeStatus>().rope_cut == true)
        {
            StartCoroutine("chicken_dinner");
        }
    }
    IEnumerator chicken_dinner()
    {
        thrust_text.text = "POULET";
        yield return new WaitForSeconds(1f);
        //thrust_text.text = "GET";
        //yield return new WaitForSeconds(0.5f);
        thrust_text.text = "YOU ARE COMPLETE";
        yield return new WaitForSeconds(2f);
        //SceneManager.LoadScene("level4");

        finished = true;
    }
}

