using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.attachedRigidbody.gameObject.CompareTag("Fire"))
        {
            other.attachedRigidbody.gameObject.GetComponent<IActionPirate>().Action();
            demolish();
        }
    }

    void demolish()
    {
        Destroy(gameObject);
    }
}
