using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sail : MonoBehaviour
{
    private Transform sail;
    void Start()
    {
       sail = transform.Find("Sail"); 
    }

    public void SetSize(float sizeNormalized) {
        sail.localScale = new Vector3(sizeNormalized, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
