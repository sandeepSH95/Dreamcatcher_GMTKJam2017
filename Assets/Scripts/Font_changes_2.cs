using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Font_changes_2 : MonoBehaviour {

    GameObject player;
    GameObject red_rope;

    Text thrust_text;

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
            thrust_text.text = "FREEZE!";
        }
        yield return new WaitForSeconds(1f);
        if (red_rope.GetComponent<RopeStatus>().rope_cut != true)
        {
            thrust_text.text = "BLACK";
        }
        yield return new WaitForSeconds(0.5f);
        if (red_rope.GetComponent<RopeStatus>().rope_cut != true)
        {
            thrust_text.text = "WIRES";
        }
        yield return new WaitForSeconds(0.5f);
        if (red_rope.GetComponent<RopeStatus>().rope_cut != true)
        {
            thrust_text.text = "BREAK";
        }
        yield return new WaitForSeconds(0.5f);
        if (red_rope.GetComponent<RopeStatus>().rope_cut != true)
        {
            thrust_text.text = "YOUR <3";
        }
        yield return new WaitForSeconds(1f);
        if (red_rope.GetComponent<RopeStatus>().rope_cut != true)
        {
            thrust_text.text = "THRUST/CUT";
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
        thrust_text.text = "ROTISSERIE";
        yield return new WaitForSeconds(1f);
        //thrust_text.text = "GET";
        //yield return new WaitForSeconds(0.5f);
        thrust_text.text = "READY?";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("level3");
    }
}
