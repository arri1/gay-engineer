using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private GenerateTerrain test;
    [Range(0.1f,20.0f)]
    public float heightScale = 5;
    [Range(0.1f,40.0f)]
    public float detailScale = 5.0f;
    [Range(0.1f,40.0f)]
    public float wavesSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        test.heightScale = heightScale;
        test.detailScale = detailScale;
    }
}
