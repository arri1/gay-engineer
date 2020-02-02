using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
      public AudioClip buttonSound;
    public AudioClip seaSound;
    public AudioClip fireSound;
    public AudioClip runSound;
  private static GameAssets _i;
    public static GameAssets i{
        get{
            if(_i==null) _i = Instantiate(Resources.Load<GameAssets>("GameAssets"));
            return _i;
        }
    }
  

}
