using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : ActionMother
{
    float speed = 100.0f;
    double fuel = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (fuel > 0)
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
        // speed = speed + 40.0f;
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
        }
    }

    IEnumerable timer()
    {
        yield return new WaitForSeconds(1);
        fuel -= 1;
    }
}
