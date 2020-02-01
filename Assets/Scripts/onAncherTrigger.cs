
using UnityEngine;

public class onAncherTrigger : MonoBehaviour
{    public GameObject Ancher;
     public GameObject AncherPosition;
     public bool isActive = false;
void OnTriggerEnter2D (Collider2D other){
    if ((other.gameObject.tag=="Player")){
    print("Activated");
    if(isActive==false){
        isActive=true;
    Ancher.transform.position = AncherPosition.transform.position;
    }
    else{
        print("Deactivated");
        isActive = false;
            }
        }
    }
}