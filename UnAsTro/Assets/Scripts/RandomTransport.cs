using UnityEngine;

public class RandomTransport: MonoBehaviour
{
    //Test script to randomly move a sprite in 3D space

    private Transform tf; // Reference to the GameObject to be moved
    public float speed = (1 / 144);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = GetComponent<Transform>();
        tf.position = Vector3.zero;

    }


    // Update is called once per frame
    void Update()
    {
        //Example of generating a random unit vector
        //Test for validating the script is properly linked to the sprite object
        //Can and should be added to a Update() input conditional to move the sprite randomly to limit movement
        //tf.position = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));

        Vector3 myVector = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        myVector = myVector.normalized;

        //Test that moves the sprite up by 1 world space unit every frame
        //tf.position = tf.position + Vector3.up;

        //Test that moves the sprite up by speed units every frame
        tf.position = tf.position + (myVector * speed * Time.deltaTime);
    }
}
