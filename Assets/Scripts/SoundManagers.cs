using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundManagers   
{  
    public static void PlaySound(){
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.i.buttonSound);
    }

    public static void PlayFireSound(){ 
       
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.i.fireSound);

    }
    public static void PlayRunSound(){ 
       
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.i.runSound);

    }
}
