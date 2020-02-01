using UnityEngine;

public class ActionMother : MonoBehaviour,  IActionPirate
{
    public virtual void Action(string command)
    {
            Obj.transform.position = TpObjTo.transform.position;
            print("called from scrpit");
    }
}