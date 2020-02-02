using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorScript : ActionMother
{
    [SerializeField] private List<Transform> points;
    [SerializeField] private Transform cabine;
    [SerializeField] WaveController waveController;
    private int current = 1;

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
            waveController.Speed =0;
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