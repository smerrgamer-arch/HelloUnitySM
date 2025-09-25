using UnityEngine;

public class RandomTransport: MonoBehaviour
{
    //Test script to randomly move a sprite in 3D space

    private Transform tf; // Reference to the GameObject to be moved
    public float speed = (1 / 144); // Speed of movement or teleportation frequency
    public float strafeRange = 10f; // Range for random strafe movement
    public float forwardRange = 10f; // Range for random forward movement 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = GetComponent<Transform>();
        tf.position = Vector3.zero;
    }


    // Update is called once per frame
    void Update()
    {
        //Random movement upon pressing T key for teleporting the starship, only once per key press
        if (Input.GetKeyUp(KeyCode.T))
        {
            //Implement a conditional using the speed variable to limit the frequency of random teleportation
            tf.position = new Vector3(Random.Range(-1 * strafeRange, strafeRange), Random.Range(-1 * forwardRange, forwardRange), 0f);
            Debug.Log("You have just teleported the entire starship!");
        }

        //Test that nonrandomly moves the sprite up by 1 world space unit every frame, for component testing and scaling purposes
        //tf.position = tf.position + Vector3.up;

        //Test that moves the sprite up by speed units every frame
        //tf.position = tf.position + (myVector * speed * Time.deltaTime);
    }
}
