using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkCollideController : MonoBehaviour {

    public bool joined;

    // Use this for initialization
    void Start () {
        joined = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // if collides with anything with the tag "rope_handle"
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject player = GameObject.FindWithTag("Player");

            if (player.GetComponent<PlayerController>().cutting == true)
            {
                //Debug.Log("link collided!");
                var joint = gameObject.GetComponent<HingeJoint2D>();
                Destroy(joint);
                //Debug.Log("cut!");

                joined = false;

                this.transform.parent.GetComponent<RopeStatus>().rope_cut = true;
            }


            //var myParent = transform.parent.GetComponent<RopeStatus>();
            //if (myParent.rope_cut == false)
            //{
            //    Debug.Log("*****");
            //}
        }
    }
}
