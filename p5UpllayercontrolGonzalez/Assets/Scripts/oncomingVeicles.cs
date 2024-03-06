using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oncomingVeicles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float speed = 20.0f; 
    private float horizontalInput;
    private float fowardInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * 25);
    }
}
