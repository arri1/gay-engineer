using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    // Field to link target element
    [SerializeField]
    ActionMother target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void ButtonTest (string command) {
        target.Action(command);
        print("hello world");
    }

}
