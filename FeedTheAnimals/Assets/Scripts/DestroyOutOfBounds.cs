using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // The measurements of the bounderies
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If the object exceeds on our bounderies
        if (transform.position.z > topBound)
        {
            // Then, Destroy the object
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound) 
        {
            //If an animal exceed on our bounderies, destroy the object and the game is over 
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
