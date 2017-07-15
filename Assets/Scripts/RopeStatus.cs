using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RopeStatus : MonoBehaviour {

    public bool rope_cut = false;
    public bool trigger = false;
    private bool shouted;

	// Use this for initialization
	void Start () {
        shouted = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (shouted == false && rope_cut == true)
        {
            Debug.Log("Rope Cut!");

            if (trigger == true)
            {
                StartCoroutine(Wait_success());
                SceneManager.LoadScene("level2");
            }
            
        }
        
	}

    IEnumerator Wait_success()
    {
        yield return new WaitForSeconds(5);
    }
}
