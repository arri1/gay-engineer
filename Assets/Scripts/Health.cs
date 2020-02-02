using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class Health : MonoBehaviour
{

    private Transform bar;
    float health;
    float damageMultiply = 0;
    void Start()
    {
        bar = transform.Find("Bar");
        health = 1.0f;
    }

    void Update()
    {
        if (health > 0)
        {
            health = health - damageMultiply;
            SetSize(health);
        }
    }

    public void decrementHealth()
    {
        damageMultiply += 0.0005f;
    }

    public void stopHealth()
    {
        damageMultiply -= 0.0005f;
    }

    public void SetSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }


}