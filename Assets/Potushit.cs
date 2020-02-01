using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potushit : ActionMother
{
    public override void Action(string command)
    {
        PotushitFire();
    }
    void PotushitFire()
    {
        gameObject.SetActive(false);
        print("hello world from Potushit");
    }
}
