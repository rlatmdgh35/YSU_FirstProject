using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Item
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
        playerCon.bulletCount += 2;

        DestroyItem();
    }

    public void OnCollisionEnter2D(Collision2D input)
    {
        if (input.gameObject.CompareTag("Player"))
            ApplyItem();
    }
}
