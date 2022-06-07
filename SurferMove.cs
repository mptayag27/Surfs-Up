using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurferMove : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    GameObject surf;
    public float maxSpeed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        surf = this.gameObject;
        rb = surf.GetComponent<Rigidbody2D>();
        //Vector3 maxSpeed = (0f, 10f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(0f, 0f);
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //rb.velocity = new Vector2(-4f, -10f);
            rb.AddForce(transform.up * -19);
            anim.SetInteger("move", 1);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            //rb.velocity = new Vector2(4f, 10f);
            rb.AddForce(transform.up * 19);
            anim.SetInteger("move", 2);
        }
        else if (!(Input.GetKey(KeyCode.RightArrow)) && !(Input.GetKey(KeyCode.D)) && !(Input.GetKey(KeyCode.LeftArrow)) && !(Input.GetKey(KeyCode.A)))
        {
            anim.SetInteger("move", 0);
        }
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
    }
}
