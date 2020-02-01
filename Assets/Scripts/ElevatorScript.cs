using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : ActionMother
{
    [SerializeField] private List<Transform> points;
    [SerializeField] private Transform cabine;
    private int _current = 0;
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

    private void up()
    {
        if (_current < points.Count - 1)
        {
            _current++;
            StartCoroutine(move(points[_current]));
        }
    }

    private void down()
    {
        if (_current > 0)
        {
            _current--;
            StartCoroutine(move(points[_current]));
        }
    }

    private IEnumerator move(Transform endPoint)
    {
        while (true)
        {
            cabine.position = Vector2.Lerp(cabine.position, endPoint.position, speed);
            yield return new WaitForEndOfFrame();
        }
    }

    /*private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.parent = cabine.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.parent = null;
        }
    }*/

  
}