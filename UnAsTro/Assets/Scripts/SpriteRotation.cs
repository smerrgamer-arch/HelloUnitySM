using UnityEngine;

public class SpriteRotation : MonoBehaviour
{
    private Transform tf;
    public float turnSpeed; // Degrees in one frame

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tf.Rotate(0, turnSpeed * Time.deltaTime, 0); //Rotate on the Y-axis
    }
}
