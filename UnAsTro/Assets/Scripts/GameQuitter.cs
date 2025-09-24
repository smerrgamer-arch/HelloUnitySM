//not //using System.Collections;
//not //using System.Collections.Generic;
using UnityEngine;

public class GameQuitter : MonoBehaviour {

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.Escape)) { 
            Debug.Log("You quit the game!");
            Application.Quit();
        } 
    }
}
