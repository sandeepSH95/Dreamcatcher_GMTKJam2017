using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Font_changes_2 : MonoBehaviour {

    GameObject player;

    Text thrust_text;

    // Use this for initialization
    void Start()
    {
        thrust_text = GameObject.Find("thrust_cut").GetComponent<Text>();
        player = GameObject.FindWithTag("Player");

        StartCoroutine("cutTheRope");
    }

    IEnumerator cutTheRope()
    {
        thrust_text.text = "FREEZE!";
        yield return new WaitForSeconds(1f);
        thrust_text.text = "BLACK";
        yield return new WaitForSeconds(0.5f);
        thrust_text.text = "WIRES";
        yield return new WaitForSeconds(0.5f);
        thrust_text.text = "LOSE";
        yield return new WaitForSeconds(0.5f);
        thrust_text.text = "THRUST/CUT";
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
    }
}
