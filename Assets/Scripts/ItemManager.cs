using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public Point[] points = new Point[] {
        new Point(1, 2),
        new Point(3, 4),
        new Point(5, 6),
        new Point(7, 8),
        new Point(9, 0),
        new Point(-1, 1),
        new Point(-3, 3),
        new Point(-5, 5),
        new Point(-7, 7),
        new Point(-9, 9),
    };

    public int ItemCount = 3;
    bool SpawnCool = true;

    public GameObject[] ItemPrefab = new GameObject[2];

    void SpawnItem()
    {   
        for(int i = 0; i < ItemCount; i++)
        {
            GameObject prefabs = ItemPrefab[Random.Range(0, ItemPrefab.Length - 1)];
            Vector2 pos = points[Random.Range(0, points.Length)].GetPosition();

            GameObject obj = Instantiate(prefabs);
            obj.transform.position = pos;
        }

        SpawnCool = true;
    }

    void Update()
    {
        if(SpawnCool)
        {
            SpawnCool = false;
            Invoke("SpawnItem", 3);
        }
    }


    // public void SpawnItem(GameObject Prefabs, Vector2 position)
    // {
    //     for(int i = 0; i < points.Length; i++)
    //     {
    //         GameObject obj = Instantiate(ItemPrefab[i % 2]);
    //         obj.transform.position = points[i].GetPosition();
    //     }
    // }

    // void Start()
    // {
    //     SpawnItem(ItemPrefab[1], new Vector2(1, 1));
    // }
}

public struct Point
{
    public int x, y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Vector2 GetPosition()
    {
        return new Vector2(x, y);
    }
}
