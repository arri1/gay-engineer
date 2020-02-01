using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potushit : ActionMother
{
    [SerializeField]
    string command;
    // Field to link target element
    [SerializeField]
    ActionMother target;
    
    [SerializeField]
    float duration=1;
    bool isBlocked = false;
    public GameObject encounter;
    
  
    // Start is called before the first frame update
    public override void Action(string command){
        switch(command){
            case "fire":
            PotushitFire();
            break;
            default : print("def");break;
        }
    }
        void PotushitFire() {
        //  if (!isBlocked)
        // {
            encounter.SetActive(false);
            // target.Action(command);
            print("hello world from Potushit");
            // StopAllCoroutines();
            // StartCoroutine(timer());
            // isBlocked = true;
          
        // }
        
      }
       IEnumerator timer()
    {
        yield return new WaitForSeconds(duration);
        isBlocked = false;
    }
    }
