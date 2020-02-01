using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemEncounter : MonoBehaviour
{   public GameObject encounter;
     [SerializeField] private List<GameObject> points;
     public float TimePoint;
    // Start is called before the first frame update
    void Start()
    {   
        //hiding objects
        for(var i =0; i<points.Count;i++){
            points[i].SetActive(false);
        }
        
        InvokeRepeating("RandomEncounter", 5f, 30+Random.Range(10.0f,30.0f));  //1s delay, repeat every 1s
        TimePoint =  Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        TimePoint=+30.0f;
        // Debug.Log(TimePoint);
        
    }

    void RandomEncounter(){
        print("im in Rand");
    var point = Random.Range(0,3);
    switch(point){
        case 0: points[0].SetActive(true);break;
         case 1: points[1].SetActive(true);break;
          case 2: points[2].SetActive(true);break;
           case 3: points[3].SetActive(true);break;
           default: print("outofBounds");break;
        
        }
    }  

  

}
