using UnityEngine;

public class CamMove : MonoBehaviour
{   public GameObject player;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x,player.transform.position.y,-10f);
    }
}
