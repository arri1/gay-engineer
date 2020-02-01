using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField]
    string command;
    // Field to link target element
    [SerializeField]
    ActionMother target;
    [SerializeField]
    Animator animator;
    // bool buttonTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void ButtonTest () {
        // buttonTrigger = true; 
        animator.SetTrigger("buttonTrigger");
        target.Action(command);
        print("hello world");
    }

}
