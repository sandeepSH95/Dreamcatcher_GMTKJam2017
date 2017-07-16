using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart_life : MonoBehaviour {

    public int heart_num;

    private SpriteRenderer h_renderer;


    private GameObject counters;

	// Use this for initialization
	void Start () {
        counters = GameObject.FindWithTag("counters");

        h_renderer = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update () {
		if (counters.GetComponent<Counters_int>().black_ropes_cut >= heart_num)
        {
            h_renderer.color = new Color(0.729f, 0.75686f, 0.72156f, 0.5f);
        }
	}
}
