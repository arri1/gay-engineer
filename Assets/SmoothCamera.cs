using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    [SerializeField] private Transform target;

    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = -target.position.y+transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        var newCoord = new Vector3(transform.position.x,distance + target.position.y,transform.position.z) ;
        transform.position = Vector3.Slerp(transform.position, newCoord, 0.1f);
    }
}