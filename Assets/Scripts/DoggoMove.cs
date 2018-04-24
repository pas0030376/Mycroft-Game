using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoggoMove : MonoBehaviour {

    public float velocity = 2f;
    private Rigidbody2D rb2d;
   
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
  
     }
     void Update() {
        rb2d.velocity = Vector2.left * velocity;
    }

    void OnCollisionEnter2D(Collider2D OtherAnimal)
    {
        if (OtherAnimal.gameObject.tag == "Birds") {
            Physics2D.IgnoreCollision(OtherAnimal.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else if (OtherAnimal.tag == "Cat")
        {
         
        }
    }
}
