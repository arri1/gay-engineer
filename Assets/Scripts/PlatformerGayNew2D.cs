using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class PlatformerGayNew2D : PlatformerCharacter2D, IActionPirate
{
    /// Grabber 
    public Transform holdpoint;

    public int throwforce = 2;
    RaycastHit2D hit;
    public float distance = 0.01f;
    [SerializeField] private GameObject grabbedObject=null;

    public void Action(string command)
    {
    }

    private void demolished()
    {
        Destroy(grabbedObject);
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        // print("Asd");
        var buttonScript = other.gameObject.GetComponent<ButtonScript>();
        if (buttonScript != null)
        {
            if (buttonScript.gameObject.tag == "ButtonKotel" && grabbedObject != null)
            {
                buttonScript.ButtonTest(true);
                demolished();
            }

            if (buttonScript.gameObject.tag != "ButtonKotel")
                buttonScript.ButtonTest();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (grabbedObject == null)
            {
                hit = Physics2D.CircleCast(holdpoint.position, 0.1f, holdpoint.right * transform.localScale.x,
                    distance);
                if (hit.collider != null)
                {
                    grabbedObject = hit.collider.gameObject;
                }
            }
            else
            {
                if (grabbedObject.GetComponent<Rigidbody2D>() != null)
                {
                    grabbedObject.GetComponent<Rigidbody2D>().velocity =
                        new Vector2(transform.localScale.x, 1) * throwforce;
                }

                grabbedObject = null;
            }
        }

        if (grabbedObject != null)
        {
            grabbedObject.transform.position = holdpoint.position;
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
