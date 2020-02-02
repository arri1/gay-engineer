using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBar : MonoBehaviour
{
    private Transform bar;
    float roadAllWay;
    float passedWay;
    void Start()
    {
        bar = transform.Find("Bar");
        roadAllWay = 1.0f;
    }

    void Update()
    {
        roadAllWay = roadAllWay - passedWay/5000;
        SetSize(roadAllWay);
    }

    public void decreaseWay(float speed)
    {
        if (roadAllWay > 0) 
        passedWay = speed * Time.deltaTime;
    }

    public void SetSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }

}
