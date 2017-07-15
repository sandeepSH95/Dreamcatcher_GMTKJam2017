using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float turn_speed;
    private Rigidbody2D rb2d;

    public bool cutting;

    private float moveHorizontal, moveVertical;

    private bool holding_rope;

    GameObject UI_canvas = GameObject.FindWithTag("UI_canvas");

    // Use this for initialization
    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        //Debug.Log("Hello!");

        holding_rope = false;
        cutting = false;

	}
	

    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            //Component thrust_text = UI_canvas.GetComponent<thrust_cut>();
            cutting = true;
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
            renderer.color = new Color(0f, 0f, 0f, 1f);

            moveHorizontal = Input.GetAxis("Horizontal");
            moveVertical = Input.GetAxis("Vertical");
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb2d.AddForce(movement * speed);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            cutting = false;
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
            renderer.color = new Color(206, 255, 26);
        }

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        //    renderer.color = new Color(0f, 0f, 0f, 1f);

        //    if (Input.GetKey(KeyCode.UpArrow))
        //    {
        //        Vector2 - 
        //        rb2d.AddForce(0,0 * speed);
        //    }
        //}

        //if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow))
        //{
        //    ;
        //}
        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    rb2d.MoveRotation(rb2d.rotation - turn_speed * Time.fixedDeltaTime);
        //}
        //else if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    rb2d.MoveRotation(rb2d.rotation + turn_speed * Time.fixedDeltaTime);
        //}

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        //    renderer.color = new Color(0f, 0f, 0f, 1f);


        //    rb2d.AddForce(rb2d.transform * speed);
        //}
        //else
        //{
        //    SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        //    renderer.color = new Color(206, 255, 26);
        //}


    }


    void OnTriggerEnter2D(Collider2D other)
    {
        // if collides with anything with the tag "rope_handle"
        if (other.gameObject.CompareTag("rope_handle")) {
            Debug.Log("hit!");
            
        }
    }

    //void oncollisionenter(collision collision)
    //{
    //    if (collision.collider.tag == "chain_contact") {
    //        debug.log("hit!");
    //    }
    //}
}
