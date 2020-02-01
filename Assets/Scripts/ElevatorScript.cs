using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : ActionMother
{
    [SerializeField] private List<Transform> points;
    [SerializeField] private Transform cabine;
    private int current = 0;
    [SerializeField] private float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public override void Action(string command)
    {
        print(command);
        StopAllCoroutines();
        switch (command)
        {
            case "up":
                up();
                break;
            case "down":
                down();
                break;
        }
    }

    void up()
    {
        if (current < points.Count-1)
        {
            current++;
            StartCoroutine(move(points[current ]));
            
        }
    }

    void down()
    {
        if (current > 0)
        {
            current--;
            StartCoroutine(move(points[current ]));
        }
    }

    IEnumerator move(Transform endPoint)
    {
        while (true)
        {
            cabine.position = Vector2.Lerp(cabine.position, endPoint.position, speed);
            yield return new WaitForEndOfFrame();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.parent = cabine.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.parent = null;
        }
    }
}