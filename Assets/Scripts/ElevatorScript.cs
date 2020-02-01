using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : ActionMother
{
    [SerializeField] private List<Transform> points;
    [SerializeField] private Transform cabine;
    private int current = 0;

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
    {  print(points.Count);
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
            cabine.position = Vector2.Lerp(cabine.position, endPoint.position, 0.1f);
            yield return new WaitForEndOfFrame();
        }
    }
}