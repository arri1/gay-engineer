using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class PlatformerGayNew2D : PlatformerCharacter2D 
{
    void OnTriggerExit2D(Collider2D other)
    {
        var buttonScript = other.gameObject.GetComponent<ButtonScript>();     
        if (buttonScript != null) {
            buttonScript.ButtonTest();
        }
    }
}
