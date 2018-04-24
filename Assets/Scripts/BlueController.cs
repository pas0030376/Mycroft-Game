using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueController : MonoBehaviour {

    public float velocity = 2f;
    private Rigidbody2D rb2d;
    // Use this for initialization
    void Start(){
        GetComponent<Rigidbody2D>().AddForce(new Vector3(2f, 0, 0));
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.left * velocity;
        transform.position = new Vector3(transform.position.x, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
