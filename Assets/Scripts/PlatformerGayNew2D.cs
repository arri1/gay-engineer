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
        // print("Asd");
        var buttonScript = other.gameObject.GetComponent<ButtonScript>();
        if (buttonScript != null)
        {
            if (buttonScript.gameObject.tag == "ButtonKotel" && isGrabbed )
            {
                buttonScript.ButtonTest(isGrabbed);
                // hit.collider.gameObject.
                Destroy(hit.collider.gameObject);
                isGrabbed = false;
            }
            
            if (buttonScript.gameObject.tag != "ButtonKotel")
                buttonScript.ButtonTest();
        }

    }


    /// Grabber 
    public bool isGrabbed;
    public Transform holdpoint;
    public int throwforce = 2;
    RaycastHit2D hit;
    public float distance = 0.01f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&&inFire&&isGrabbed){
            // print("e pressed");
            
            print("hello world from Platf");
            StopAllCoroutines();
            StartCoroutine(timer());
            isBlocked = true;
            currentAction.Action("fire");
            Destroy(hit.collider.gameObject);
            isGrabbed=false;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            print("B pressed");
            if (!isGrabbed)
            {
                hit = Physics2D.CircleCast(holdpoint.position, 0.1f, holdpoint.right * transform.localScale.x, distance);
                if (hit.collider != null)
                {
                    print(hit.collider.gameObject.tag);
                    isGrabbed = true;
                }
            }
            else
            {
                isGrabbed = false;
                if (hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
                {
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 1) * throwforce;
                }
            }
        }

        if (isGrabbed)
        {
            hit.collider.gameObject.transform.position = holdpoint.position;
        }

    }
    void OnTriggerEnter2D(Collider2D col){
     print("im here");
         if ((col.gameObject.tag=="Respawn"))
        {
           inFire = true;
           currentAction = col.gameObject.GetComponent<IActionPirate>();
           
        }


    }
    void OnTriggerExit2D(Collider2D col){
     print("im here");
         if ((col.gameObject.tag=="Respawn"))
        {
           inFire = false;
           currentAction = null;
        }

    }
     IEnumerator timer()
    {
        yield return new WaitForSeconds(duration);
        isBlocked = false;
    }

    void OnDrawGizmos()
    {
        int sign = 1;
        if (transform.localScale.x < 0)
        {
            sign = -1;
        }
        Gizmos.color = Color.red;
        Gizmos.DrawLine(holdpoint.position, holdpoint.position + holdpoint.right * distance * sign);
        Gizmos.DrawLine(holdpoint.position, holdpoint.position + holdpoint.up * 0.1f);

    }
}
