using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColideController : MonoBehaviour {

    private float moveHorizontal, moveVertical;

    //private bool attached;

    // Use this for initialization
    void Start () {

        //attached = false;

	}

    //private void Update()
    //{
    //    if (attached)
    //    {
    //        var pos = GameObject.Find("Player").transform.position;
    //        transform.Translate(pos* (Time.deltaTime)/2);
    //    }

    //}


    void OnTriggerEnter2D(Collider2D other)
    {
        // if collides with anything with the tag "rope_handle"
        if (other.gameObject.CompareTag("Player"))
        {
            
            //Debug.Log("attached!");
            //attached = true;
        }
    }
}
