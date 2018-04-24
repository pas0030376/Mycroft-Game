using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdsController : MonoBehaviour {

    public GameObject blueBird;
    public GameObject owl;
    public GameObject eagle;
    public GameObject chicken;
    public GameObject yellowbird;

    public float bluebirdTimer = 3f;
    public float yellowbirdtimer = 6f;
    public float chickentimer = 15f;
    public float eagletimer = 25f;
    public float owltimer = 50f;


	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void CreateBlueBird() {
        GameObject bb =  Instantiate(blueBird, transform.position, Quaternion.identity);
        //Set the same scale as the parent when the birds appear
        bb.transform.SetParent(this.transform, false);
       
    }
    void CreateChicken(){
        GameObject cb = Instantiate(chicken, transform.position, Quaternion.identity);
        cb.transform.SetParent(this.transform, false);
    }

    void CreateYellowBird(){
        GameObject yb = Instantiate(yellowbird, transform.position, Quaternion.identity);
        yb.transform.SetParent(this.transform, false);
    }

    void CreateEagle(){
        GameObject eb = Instantiate(eagle, transform.position, Quaternion.identity);
        eb.transform.SetParent(this.transform, false);
    }

    void CreateOwl(){
        GameObject ob = Instantiate(owl, transform.position, Quaternion.identity);
        ob.transform.SetParent(this.transform, false);
    }

    public void StartGenerator(){
        InvokeRepeating("CreateBlueBird", 5f, bluebirdTimer);
        InvokeRepeating("CreateYellowBird", 10f, yellowbirdtimer);
        InvokeRepeating("CreateChicken", 15f, chickentimer);
        InvokeRepeating("CreateEagle", 20f, eagletimer);
        InvokeRepeating("CreateOwl", 25f, owltimer);
    }
    public void StopGenerator(){
        CancelInvoke("CreateBlueBird");
        CancelInvoke("CreateYellowBird");
        CancelInvoke("CreateChicken");
        CancelInvoke("CreateEagle");
        CancelInvoke("CreateOwl");
    }
}
