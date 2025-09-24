using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarshipPawn : Pawn
{
    private Transform tf;

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
        float horizontal = 0f;
        if (Input.GetKey(KeyCode.Q))
        {
            horizontal -= 1f;
            Debug.Log("Left strafe key pressed");
        }

        if (Input.GetKey(KeyCode.E))
        {
            horizontal += 1f;
            Debug.Log("Right strafe key pressed");
        }

        float vertical = 0f;
        if (Input.GetKey(KeyCode.S))
        {
            vertical -= 1f;
            Debug.Log("S key pressed");
        }

        if (Input.GetKey(KeyCode.W))
        {
            vertical += 1f;
            Debug.Log("W key pressed");
        }

        transform.Translate(new Vector3(horizontal * Time.deltaTime, vertical * Time.deltaTime, 0));

        if (horizontal != 0f || vertical != 0f)
        {
            Debug.Log("Starship moved");
            Debug.Log("Player position: " + tf.position);
        }
    }
}
