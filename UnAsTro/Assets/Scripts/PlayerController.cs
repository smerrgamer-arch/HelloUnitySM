//not //using System.Collections;
//not //using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller 
{
    private Transform tf;
    public float speed = (1 / 144);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Controller[] playerControllers = FindObjectsOfType<PlayerController>();

        tf = GetComponent<Transform>();
        tf.position = Vector3.zero;

        //If tf can not be assigned a vector value even after above attempt
        if (tf == null) Debug.Log("Transform is null! Somehow...");

    }

    void Update()
    {
        /* // Tentative line of code below to have space key do something 
        if (Input.GetKeyDown(KeyCode.Space)
        */

        // Move the starship with WASD keys
        // These lines were moved to StarshipPawn.cs and modified to QESD keys

        /* Invalid code below
         * Working on A and D keys to turn the starship left and right
        if (Input.GetKey(KeyCode.A))
        {
            tf.position += (GetComponent<Transform>().TransformDirection(new Vector3(-1,1,0)) * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            tf.position += (GetComponent<Transform>().TransformDirection(new Vector3(1,1,0)) * speed);
        } 

        //transform.Translate(new Vector3(horizontal * Time.deltaTime, vertical * Time.deltaTime, 0));
        */
    }
}
