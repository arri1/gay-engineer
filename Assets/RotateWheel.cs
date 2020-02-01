using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : ActionMother
{
    float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(Vector3.forward * speed * Time.deltaTime); 
    }

    void Rotate(){
        speed = speed + 40.0f;
    }
}
