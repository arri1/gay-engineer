using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class PlatformerGayNew2D : PlatformerCharacter2D, IActionPirate
{
    bool isBlocked = false;
    public GameObject Obj;
    public GameObject TpObjTo;
    public void Action(string command)
    {
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (!isBlocked)
        {
            if (other.gameObject.tag == "Button")
            {
                var buttonScript = other.gameObject.GetComponent<ButtonScript>();
                if (buttonScript != null)
                {
                    buttonScript.ButtonTest("up");
                    isBlocked = true;
                    StopAllCoroutines();
                    StartCoroutine(timer());
                }
            }
        }
        if(other.gameObject.tag=="AncherButton"){
            print("Hello from guy");
            var tempPos = Obj.transform.position;
            while(tempPos.x>-1.285){
            tempPos.x +=1f;
            Obj.transform.position = tempPos;
            }
        }
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(3);
        isBlocked = false;
    }
}
