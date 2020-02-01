using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class PlatformerGayNew2D : PlatformerCharacter2D, IActionPirate
{
    public void Action(string command)
    {
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        print("Asd");
        var buttonScript = other.gameObject.GetComponent<ButtonScript>();
        if (buttonScript != null)
        {
            if (buttonScript.gameObject.tag == "ButtonKotel")
            {
                buttonScript.ButtonTest(isGrabbed);
                // hit.collider.gameObject.
                Destroy(hit.collider.gameObject);
                isGrabbed = false;
            }
            else
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
