using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {
        Invoke("DestroySelf", 2.0f);
    }

    void DestroySelf()
    {
        Destroy(this.gameObject);
    }

    void Update()
    {
        
    }
}
