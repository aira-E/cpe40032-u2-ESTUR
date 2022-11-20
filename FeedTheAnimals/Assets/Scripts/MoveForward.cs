using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // The speed of the animals moving forward
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // the proper coding for moving our objects forward with respect to our picked time.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
