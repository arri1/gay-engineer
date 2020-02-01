using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    [SerializeField] private GenerateTerrain generateTerrain;
    [SerializeField] [Range(1, 3f)] float heightScale = 3;
    [SerializeField] [Range(0.1f, 40.0f)] float detailScale = 5.0f;




    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        generateTerrain.heightScale = heightScale;
        generateTerrain.detailScale = detailScale;
    }

    public void ChangeSpeed(int needSpeed)
    {
    }
}