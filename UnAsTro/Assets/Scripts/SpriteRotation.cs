using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  * Script to rotate a sprite clockwise or counterclockwise when the left or right arrow keys are pressed
 *  * Detached from StarshipPawn.cs to alter rotation as its own component
*/

public class SpriteRotation : MonoBehaviour
{
    private Transform tf;
    public float turnSpeed = 1f; // Modifiable turn rate in one frame

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Handles simultaneous forward movement and turning left/right when A key is pressed, separate from strafe movement in world space 
        // Local unit forward & diagonal rotation movement bound to turn speed, and local translation forward movement bound to current sprite angle

        if (Input.GetKeyDown("a"))
        {
            tf.position = tf.position + (tf.up * turnSpeed * Time.deltaTime);
            tf.position = tf.position + (GetComponent<Transform>().TransformDirection(new Vector3(-1, 1, 0)));
            tf.Translate(Vector3.up * (-1 * turnSpeed), Space.Self);
        }
        else if (Input.GetKeyDown("d"))
        {
            tf.position = tf.position + (tf.up * turnSpeed * Time.deltaTime);
            tf.position = tf.position + (GetComponent<Transform>().TransformDirection(new Vector3(1, 1, 0)));
            tf.Translate(Vector3.up * turnSpeed, Space.Self);
        }
    }
}