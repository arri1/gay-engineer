using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    [SerializeField] private GenerateTerrain generateTerrain;
    [SerializeField] [Range(0.1f, 20.0f)] float heightScale = 5;
    [SerializeField] [Range(0.1f, 40.0f)] float detailScale = 5.0f;

    [SerializeField] [Range(0.1f, 40.0f)] float wavesSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        generateTerrain.heightScale = heightScale;
        generateTerrain.detailScale = detailScale;
        generateTerrain.wavesSpeed = wavesSpeed;
    }
}