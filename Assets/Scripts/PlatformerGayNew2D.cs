using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class PlatformerGayNew2D : PlatformerCharacter2D, IActionPirate
{
    public void Action(string command)
    {
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Button")
        {
            var buttonScript = other.gameObject.GetComponent<ButtonScript>();
            if (buttonScript != null)
            {
                buttonScript.ButtonTest();
            }
        }
    }
}
