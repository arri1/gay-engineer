using UnityEngine;

public class ActionMother : MonoBehaviour,  IActionPirate
{public GameObject Obj;
     public GameObject TpObjTo;
    public void Action(string command)
    {
            Obj.transform.position = TpObjTo.transform.position;
            print("called from scrpit");
    }
}