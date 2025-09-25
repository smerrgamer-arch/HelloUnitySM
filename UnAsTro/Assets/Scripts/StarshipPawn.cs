using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarshipPawn : Pawn
{
    private Transform tf;
    public float speed = 1f; // Modifiable movement and turn speed factor
    public float skipWarp = 2f; // Distance to skip when warp key is pressed

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = GetComponent<Transform>();
        tf.position = Vector3.zero;

        //If tf can not be assigned a vector value even after above attempt
        if (tf == null) Debug.Log("Transform is null! Somehow...");
    }

    // Update is called once per frame
    void Update()
    {
        // Check WASD keys for movement
        float horizontal = 0f;
        float vertical = 0f;

        //Horizontal/vertical variable update for strafe movement along world space X & Y axes
        if (Input.GetKey("q"))
        {
            horizontal -= 1f;
            //Debug log to confirm key press is detected, can be removed later
            //Placed for in case camera moves unnecessarily, we see the starship moves even if the camera is not over the starship
            Debug.Log("Left strafe key pressed");
        }
        else if (Input.GetKey("e"))
        {
            horizontal += 1f;
            //Right strafe key pressed
            //Debug log to confirm key press is detected
            Debug.Log("Right strafe key pressed");
        }

        if (Input.GetKey("s"))
        {
            //tf.Translate(Vector3.down * Time.deltaTime, Space.Self); 
            vertical -= 1f;
            //Move backwards (down in world space)
            Debug.Log("Backwards key pressed");
        }
        else if (Input.GetKey("w"))
        {
            //tf.Translate(Vector3.up * Time.deltaTime, Space.Self); 
            vertical += 1f;
            //Move forwards (up in world space)
            Debug.Log("Forwards key pressed");
        }

        if (Input.GetKey("a"))
        {
            tf.Rotate(0, 0, 36 * speed * Time.deltaTime);
            //tf.position = tf.position + (GetComponent<Transform>().TransformDirection(new Vector3(-1, 1, 0)) * speed);
            Debug.Log("Turned counterclockwise");
        }
        else if (Input.GetKey("d"))
        {
            tf.Rotate(0, 0, -36 * speed * Time.deltaTime);
            //tf.position = tf.position + (GetComponent<Transform>().TransformDirection(new Vector3(1, 1, 0)) * speed);
            Debug.Log("Turned clockwise");
        }


        //Floor the vector values when the random range value is too close to zero
        if (Input.GetKeyDown("left"))
        { 
            Vector3 myVector = new Vector3(Random.Range(-1 * skipWarp, 0), 0, 0);
            myVector = myVector.normalized;
            transform.Translate(myVector); 
        }
        else if (Input.GetKeyDown("right"))
        {
            Vector3 myVector = new Vector3(Random.Range(0, skipWarp), 0, 0);
            myVector = myVector.normalized;
            transform.Translate(myVector);
        }

        if (Input.GetKeyDown("up"))
        {
            Vector3 myVector = new Vector3(0, Random.Range(0, skipWarp), 0);
            myVector = myVector.normalized;
            transform.Translate(myVector);
        }
        else if (Input.GetKeyDown("down"))
        { 
            Vector3 myVector = new Vector3(0, Random.Range(-1 * skipWarp, 0), 0);
            myVector = myVector.normalized;
            transform.Translate(myVector);
        }


        //Translation with or without boost when a shift key is held down
        if (Input.GetKey("right shift") || Input.GetKey("left shift"))
        {
            //Time.deltaTime is used to make movement frame rate independent
            transform.Translate(new Vector3(horizontal * Time.deltaTime * speed, vertical * Time.deltaTime * speed, 0));
        }
        //Translation movement along the world space X & Y axes at a limited speed)
        else
        {
            transform.Translate(new Vector3(horizontal * Time.deltaTime, vertical * Time.deltaTime, 0));
        }
    }
}
