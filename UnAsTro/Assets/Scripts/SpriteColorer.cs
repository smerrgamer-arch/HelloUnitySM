using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteColorer : MonoBehaviour
{
    private Transform tf; // Create a variable for our transform component
    public float maxScale; // Create a variable for the max we can scale in one frame draw

    // Use this for initialization
    void Start()
    {
        // Load our transform component into our variable
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    { 
    
    }
}