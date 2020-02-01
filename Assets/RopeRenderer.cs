using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RopeRenderer : MonoBehaviour
{
    public GameObject ropeHingeAnchor;
public DistanceJoint2D ropeJoint;
public Transform crosshair;
public SpriteRenderer crosshairSprite;
private bool ropeAttached;
private Vector2 playerPosition;
private Rigidbody2D ropeHingeAnchorRb;
private SpriteRenderer ropeHingeAnchorSprite;

public LineRenderer ropeRenderer;

private bool distanceSet;
private List<Vector2> ropePositions = new List<Vector2>();
    private void UpdateRopePositions()
{
    
    // 1
    if (!ropeAttached)
    {
        return;
    }

    // 2
    ropeRenderer.positionCount = ropePositions.Count + 1;

    // 3
    for (var i = ropeRenderer.positionCount - 1; i >= 0; i--)
    {
        if (i != ropeRenderer.positionCount - 1) // if not the Last point of line renderer
        {
            ropeRenderer.SetPosition(i, ropePositions[i]);
                
            // 4
            if (i == ropePositions.Count - 1 || ropePositions.Count == 1)
            {
                var ropePosition = ropePositions[ropePositions.Count - 1];
                if (ropePositions.Count == 1)
                {
                    ropeHingeAnchorRb.transform.position = ropePosition;
                    if (!distanceSet)
                    {
                        ropeJoint.distance = Vector2.Distance(transform.position, ropePosition);
                        distanceSet = true;
                    }
                }
                else
                {
                    ropeHingeAnchorRb.transform.position = ropePosition;
                    if (!distanceSet)
                    {
                        ropeJoint.distance = Vector2.Distance(transform.position, ropePosition);
                        distanceSet = true;
                    }
                }
            }
            // 5
            else if (i - 1 == ropePositions.IndexOf(ropePositions.Last()))
            {
                var ropePosition = ropePositions.Last();
                ropeHingeAnchorRb.transform.position = ropePosition;
                if (!distanceSet)
                {
                    ropeJoint.distance = Vector2.Distance(transform.position, ropePosition);
                    distanceSet = true;
                }
            }
        }
        else
        {
            // 6
            ropeRenderer.SetPosition(i, transform.position);
        }
    }
}
}
