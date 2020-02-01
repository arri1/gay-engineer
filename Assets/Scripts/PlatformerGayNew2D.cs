using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class PlatformerGayNew2D : PlatformerCharacter2D, IActionPirate
{
    public void Action(string command)
    {
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        print("Asd");
        var buttonScript = other.gameObject.GetComponent<ButtonScript>();
        if (buttonScript != null)
        {
            buttonScript.ButtonTest();
        }
    }

}
