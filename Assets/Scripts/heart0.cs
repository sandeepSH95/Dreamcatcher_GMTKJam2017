using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart0 : MonoBehaviour {

    SpriteRenderer h_renderer;

    GameObject red_rope;

    // Use this for initialization
    void Start()
    {
        red_rope = GameObject.FindWithTag("red_rope");
        h_renderer = gameObject.GetComponent<SpriteRenderer>();

        h_renderer.color = new Color(0.839f, 0.286f, 0.2f, 0f);

        //StartCoroutine("fadeIn");
    }

    IEnumerator fadeIn()
    {

        yield return new WaitForSeconds(0.5f);
        h_renderer.color = new Color(0.839f, 0.286f, 0.2f, 1f);

    }
    // Update is called once per frame
    void Update()
    {
        if (red_rope.GetComponent<RopeStatus>().rope_cut == true)
        {
            StartCoroutine("fadeIn");
        }
    }
}
