using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    [SerializeField] private GenerateTerrain generateTerrain;
    [Range(0, 100)] public int Speed = 3;
    [SerializeField] [Range(0.1f, 40.0f)] float detailScale = 5.0f;
    [SerializeField] private float maxWaveSpeed = 3f;
    [SerializeField] private FreeParallax _parallax;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        generateTerrain.heightScale = Mathf.Max(Speed / 100f * maxWaveSpeed, 1f);
        print(Mathf.Max(Speed / 100f * maxWaveSpeed, 1f));
        generateTerrain.detailScale = detailScale;
        _parallax.Speed = Speed / 5f;
    }

    public void ChangeSpeed(int needSpeed)
    {
    }
}