using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    [Range (0.02f,0.20f)]
    public float parallaxSpeed = 0.02f;
    public RawImage background;
    public RawImage platform;
    public RawImage miniplatform;

    public enum GameStates {Idle, Playing}
    public GameStates gameState = GameStates.Idle;
    public GameObject uiIdle;
    public GameObject player;
    public GameObject birdsGenerator;
    public GameObject canvas;
    public GameObject doggoGenerator;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Detectar si se quiere empezar el juego
        if (gameState == GameStates.Idle && (Input.GetKeyDown("space"))) {
            gameState = GameStates.Playing;
            uiIdle.SetActive(false);
            birdsGenerator.SendMessage("StartGenerator");
            doggoGenerator.SendMessage("StartGenerator");
            
            canvas.SetActive(true);
        }
        else if (gameState == GameStates.Playing) {
            Parallax();
        }
    }

    void Parallax()
    {
        float finalSpeed = parallaxSpeed * Time.deltaTime;
        background.uvRect = new Rect(background.uvRect.x + finalSpeed, 0f, 1f, 1f);
        platform.uvRect = new Rect(platform.uvRect.x + finalSpeed * 4, 0f, 1f, 1f);
    }
}
