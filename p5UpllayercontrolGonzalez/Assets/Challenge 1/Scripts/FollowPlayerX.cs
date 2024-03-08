using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private float speed = 25.0f;
    private float turnSpeed = 60.0f;
    private float VerticalInput;
   
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        VerticalInput = Input.GetAxis("Vertical");
        transform.position = plane.transform.position + offset;

        transform.Translate(Vector3.forward * Time.deltaTime);

        transform.Rotate(Vector3.left*speed * Time.deltaTime);
        
    }
}

