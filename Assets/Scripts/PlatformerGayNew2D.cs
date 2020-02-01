using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class PlatformerGayNew2D : PlatformerCharacter2D, IActionPirate
{
    bool isBlocked = false;

    public void Action(string command)
    {
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (!isBlocked)
        {
                var buttonScript = other.gameObject.GetComponent<ButtonScript>();
                if (buttonScript != null)
                {
                    buttonScript.ButtonTest();
                    isBlocked = true;
                    StopAllCoroutines();
                    StartCoroutine(timer());
                }
        }
        if(other.gameObject.tag=="AncherButton"){
            print("Hello from guy");
            
            
        }
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(3);
        isBlocked = false;
    }
}
