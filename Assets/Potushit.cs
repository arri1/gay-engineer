using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potushit : ActionMother
{
    [SerializeField] private GameObject bax;
    [SerializeField]
    private float minRandom = 5;
    [SerializeField]
    private float maxRandom = 15;

    [SerializeField] private GameObject suriken;
    [SerializeField] private Health health;

    void Start()
    {
        getRandomTimer();
    }

    void getRandomTimer()
    {
        float r = Random.Range(minRandom, maxRandom);
        StopAllCoroutines();
        StartCoroutine(startTimer(r));
    }

    IEnumerator startTimer(float t)
    {
        yield return new WaitForSeconds(t);
        babax();
    }

    void babax()
    {
        bax.SetActive(true);
        health.decrementHealth();
        print("Boom!");
    }


    public override void Action(string command)
    {
        potushitFire();
    }

    void potushitFire()
    {
        Instantiate(suriken, transform);
        bax.SetActive(false);
        getRandomTimer();
        health.stopHealth();
    }
}