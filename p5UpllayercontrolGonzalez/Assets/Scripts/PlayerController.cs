using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 20;  
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        //Move the vehicle foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
       transform.position = player.transform.position;
    }
}