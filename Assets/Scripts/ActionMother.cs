using UnityEngine;

public class ActionMother : MonoBehaviour,  IActionPirate
{
    public virtual void Action(string command)
    {
            
            print("called from scrpit");
    }
}