//not //using System.Collections;
//not //using System.Collections.Generic;
using UnityEngine;

public class GameQuitter : MonoBehaviour {

    // Update is called once per frame
    void Update() {

        // Check for Escape key press to quit the game
        if (Input.GetKey(KeyCode.Escape)) { 
            Debug.Log("You quit the game!");
            Application.Quit();
        } 
    }
}
