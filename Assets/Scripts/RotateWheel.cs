using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : ActionMother
{
    [SerializeField]
    private FuelBar fuelBar;
    [SerializeField]
    private FuelBar barometr;

    [SerializeField]
    private Sail sail;
    float speed = 100.0f;
    double fuel = 5.0;
    float pressure = 0.6f;
    float fuelFloat = 1.0f;
    [SerializeField]
    WaveController waveController;
    [SerializeField]
    ParScript parScript;

    [SerializeField]

    void Start()
    {
        waveController.Speed = 0;
        // barometr.SetSize(0);
    }

    void Update()
    {

        waveController.Speed = Mathf.Lerp(waveController.Speed, speed, Time.deltaTime * 0.1f);
        if (pressure > 0)
        {
            pressure -= 0.0006f;
            if (pressure > 0.9f)
            {
                speed = speed / 2;
            }
        }

        if (fuel > 0)
        {
            fuel -= 0.01;
        }
        fuelBar.SetSize((float)fuel / 6);
        barometr.SetSize((float)pressure / 1.1f);

        if (fuel < 0)
        {
            if (speed > 0)
            {
                speed -= Time.deltaTime * 10;
            }
        }
        transform.Rotate(Vector3.back * speed * Time.deltaTime);
    }

    void rotate()
    {
        speed = 100.0f;
        fuel = 5;
        pressure += 0.5f;
    }

    void pullSteam()
    {
        pressure = 0;
        parScript.Poparim();
    }

    public override void Action(string command)
    {
        print(command);
        StopAllCoroutines();
        switch (command)
        {
            case "speedUp":
                rotate();
                break;
            case "down":
                break;
            case "pullSteam":
                pullSteam();
                break;
        }
    }

}
