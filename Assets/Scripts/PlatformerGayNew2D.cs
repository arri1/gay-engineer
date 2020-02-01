using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class PlatformerGayNew2D : PlatformerCharacter2D, IActionPirate
{    
     bool isBlocked = false;
     float duration=1;
    bool inFire = false;
    public GameObject encounter;
    private IActionPirate currentAction;
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
        // var problemScript = other.gameObject.GetComponent<Potushit>();
        // if((problemScript!=null)&& Input.GetKeyDown("e") )
        // {
        //     problemScript.Action("fire");
        // }

       
    }
    void Update(){
    

        if (Input.GetKeyDown(KeyCode.E)&&inFire){
            // print("e pressed");
            
            print("hello world from Platf");
            StopAllCoroutines();
            StartCoroutine(timer());
            isBlocked = true;
            currentAction.Action("fire");
        }
    }
    void OnTriggerEnter2D(Collider2D col){
     print("im here");
         if ((col.gameObject.tag=="Respawn"))
        {
            // target.Action(command);
           inFire = true;
           currentAction = col.gameObject.GetComponent<IActionPirate>();
           
        }


    }
    void OnTriggerExit2D(Collider2D col){
     print("im here");
         if ((col.gameObject.tag=="Respawn"))
        {
            // target.Action(command);
           inFire = false;
           currentAction = null;
        }

    }
     IEnumerator timer()
    {
        yield return new WaitForSeconds(duration);
        isBlocked = false;
    }

}
