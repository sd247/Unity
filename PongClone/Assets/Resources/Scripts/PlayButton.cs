using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
     
    public void playGame(){
        Debug.Log("Playgame was pressed!!");

        // Moves to the game scene
        SceneManager.LoadScene("Game");
    }
}
