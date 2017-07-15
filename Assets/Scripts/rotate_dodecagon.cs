using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_dodecagon : MonoBehaviour {

    public float rotation_speed;
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, rotation_speed) * Time.deltaTime);
	}
}
