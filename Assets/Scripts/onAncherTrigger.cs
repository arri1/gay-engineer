
using UnityEngine;

public class onAncherTrigger : MonoBehaviour
{    public GameObject Obj;
     public GameObject TpObjTo;
     public bool isActive = false;
void OnTriggerEnter2D (Collider2D other){
    if ((other.gameObject.tag=="Player")&& Input.GetKeyDown(KeyCode.E)){
        print("Activated");
        if(isActive==false){
            isActive=true;
            Obj.transform.position = TpObjTo.transform.position;
            }
        else{
        print("Deactivated");
        isActive = false;
            }
        }
    }
}