using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Item, IEffect
{
    public override void DestroyAfterTime()
    {
        Invoke("GetOpaque", 3f);
        Invoke("DestroyItem", 5f);
    }

    public void GetOpaque()
    {
        Color32 color = GetComponent<SpriteRenderer>().color;
        GetComponent<SpriteRenderer>().color = new Color32(color.r, color.g, color.b, 64);
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
