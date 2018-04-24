using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoggoController : MonoBehaviour {
    public GameObject dog;
    public float DoggoTimer = 2f;
   
    void Start () {
		
	}
	
	void Update () {
		
	}

    void CreateDoggo() {
       GameObject dogie =  Instantiate(dog, transform.position, Quaternion.identity);
       dogie.transform.SetParent(this.transform, false);
    }

    public void StartGenerator()
    {
        InvokeRepeating("CreateDoggo", 20f,DoggoTimer );
    }
    public void StopGenerator()
    {
        CancelInvoke("CreateDoggo");
    }
}
