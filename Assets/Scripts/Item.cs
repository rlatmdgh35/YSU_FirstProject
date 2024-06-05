using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public abstract void DestroyAfterTime();
    public abstract void ApplyItem();

    void Start()
    {
        DestroyAfterTime();
    }
}

public interface IEffect
{
    public void GetOpaque();
}