using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : Item
{
    public override void DestroyAfterTime()
    {
        Invoke("DestroyItem", 5f);
    }

    public void DestroyItem()
    {
        Destroy(this.gameObject);
    }

    public override void ApplyItem()
    {
        GameObject playerObj = GameObject.Find("Player");
        PlayerController playerCon = playerObj.GetComponent<PlayerController>();
        playerCon.speed *= 2f;

        DestroyItem();
    }

    public void OnCollisionEnter2D(Collision2D input)
    {
        if (input.gameObject.CompareTag("Player"))
        {
            ApplyItem();
        }
    }
}
