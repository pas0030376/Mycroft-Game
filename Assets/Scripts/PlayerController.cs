using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Animator animator;
   //public GameObject platform;
    public GameObject blueBird;
    public GameObject owl;
    public GameObject eagle;
    public GameObject chicken;
    public GameObject yellowbird;
    public Text counter;

    public int count = 0;
   


    //Varibles de movimiento
    public float velX = 0.1f;
    public float moveX;
    public float inputX;
    
    
    //Variables de salto
    public float velJump = 350f;

    public static double positive = 0.152;
    float plusOut = Convert.ToSingle(positive);


    // Use this for initialization
    void Start () {
     animator = GetComponent<Animator>();
     count = 0;
     updateCounter();
    }

    void FixedUpdate () {
        inputX = Input.GetAxis("Horizontal");
        //UpdateState("CatRunning");
        if (Input.GetKey(KeyCode.RightArrow) ) {
            UpdateState("CatRunning");
            moveX = transform.position.x + (inputX * velX);
            transform.position = new Vector3(moveX, transform.position.y, 0);
            transform.localScale = new Vector3(plusOut, plusOut, 1);
        } 
    
        if (Input.GetKey(KeyCode.LeftArrow)){
            UpdateState("CatRunning");
            moveX = transform.position.x + (inputX * velX);
            transform.position = new Vector3(moveX, transform.position.y, 0);
            transform.localScale = new Vector3(-plusOut,plusOut, 1);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)){
            GetComponent <Rigidbody2D>().AddForce (new Vector2 (0, velJump));
            UpdateState("CatJumping");
        }
    }

    void OnTriggerEnter2D(Collider2D OtherAnimal)
    {
        if (OtherAnimal.gameObject.tag == "Birds")
        {
            if (OtherAnimal.gameObject.name.Contains( "Blue Bird")) {
                count++;
                updateCounter();
            }
            else if (OtherAnimal.gameObject.name.Contains("Yellow Bird")) {
                count = count + 5;
                updateCounter();
            }
            else if (OtherAnimal.gameObject.name.Contains("Chicken")) {
                count = count + 10;
                updateCounter();
            }
            else if (OtherAnimal.gameObject.name.Contains("Eagle")){
                count = count + 15;
                updateCounter();
            }
            else if (OtherAnimal.gameObject.name.Contains("Owl")){
                count = count + 20;
                updateCounter();
            }
            //count++;
            //updateCounter();
            Destroy(OtherAnimal.gameObject);
        }
        else if (OtherAnimal.tag == "Dog"){
            UpdateState("CatHurt");
        }
    }

     void updateCounter()
    {
        counter.text = "" + count;

    }

    public void UpdateState(string state = null)
    {
        if (state != null)
        {
            animator.Play(state);
        }
    }
}
