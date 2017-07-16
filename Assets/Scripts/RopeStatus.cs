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

            //if (trigger == true)
            //{
            //    StartCoroutine("wait_success()");
                
            //}
            
        }
        
	}

    //IEnumerator wait_success()
    //{
        //thrust_text.text = "CHICKEN DINNER";
        //yield return new WaitForSeconds(0.7f);
        //thrust_text.text = "GET";
        //yield return new WaitForSeconds(0.5f);
        //thrust_text.text = "READY";
        //yield return new WaitForSeconds(0.5f);
        //thrust_text.text = "3...";
        //yield return new WaitForSeconds(1f);
        //thrust_text.text = "2...";
        //yield return new WaitForSeconds(1f);
        //thrust_text.text = "1...T";
    //    yield return new WaitForSeconds(5f);
    //    SceneManager.LoadScene("level2");
    //}
}
